using System;
using System.Collections;
using System.Collections.Generic;
using Abyss.Api;
using Abyss.Extensions;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;
using static Abyss.AbyssLogger;

namespace Abyss;

[PublicAPI]
public abstract class DredgeMod : BaseUnityPlugin, IModContent
{
    public Harmony? HarmonyInstance { get; private set; }

    /// <summary>
    /// Called after the plugin is loaded by the initializer
    /// </summary>
    public virtual void Initialize()
    {
    }



    public virtual void Start()
    {
        foreach (var modContent in Content)
        {
            try
            {
                modContent.Register();
            }
            catch (Exception e)
            {
                Logger.LogError($"Failed to register {modContent.Id}");
                Logger.LogError(e);
                this.LoadErrors.Add($"Failed to register {modContent.Name}");

                foreach (var rollbackAction in modContent.RollbackActions)
                {
                    try
                    {
                        rollbackAction();
                    }
                    catch (Exception e2)
                    {
                        Logger.LogError($"Error while rolling back failed addition of {modContent.Id}");
                        Logger.LogError(e2);
                        break;
                    }
                }
            }
            finally
            {
                modContent.RollbackActions.Clear();
            }
        }
    }

    [UsedImplicitly]
    internal void InitDredgeMod()
    {
        ModContentInstances.AddInstance(GetType(), this);

        if (CreateHarmonyInstance)
        {
            HarmonyInstance = new Harmony(Info.Metadata.GUID);
            if (HarmonyPatchAll)
            {
                AccessTools.GetTypesFromAssembly(this.GetAssembly()).Do(ApplyHarmonyPatches);
            }
        }

        try
        {
            ResourceHandler.LoadEmbeddedTextures(this);
            ResourceHandler.LoadEmbeddedBundles(this);
            ModContent.LoadModContent(this);
        }
        catch (Exception e)
        {
            Error("Critical failure when loading resources for mod " + Info.Metadata.Name);
            Error(e);
        }

        Initialize();
    }

    /// <summary>
    /// Tries to apply all Harmony Patches defined within a type. Logs a warning and adds a load error if any fail.
    /// </summary>
    /// <param name="type"></param>
    public void ApplyHarmonyPatches(Type type)
    {
        try
        {
            HarmonyInstance!.CreateClassProcessor(type).Patch();
        }
        catch (Exception e)
        {
            Logger.LogWarning(
                $"Failed to apply {Info.Metadata.Name} patch(es) in {type.Name}: \"{e.InnerException?.Message ?? e.Message}\" " +
                $"The mod might not function correctly. This needs to be fixed by one of the plugin authors");

            LoadErrors.Add($"Failed to apply patch(es) in {type.Name}");
        }
    }


    public virtual bool CreateHarmonyInstance => true;

    public virtual bool HarmonyPatchAll => true;

    /// <inheritdoc cref="BaseUnityPlugin.Logger"/>
    public new ManualLogSource Logger => base.Logger;

    internal readonly List<string> LoadErrors = new();

    private List<ModContent> content;

    /// <summary>
    /// All ModContent in ths mod
    /// </summary>
    public IReadOnlyList<ModContent> Content
    {
        get => content;
        internal set => content = value as List<ModContent>;
    }

    /// <summary>
    /// The embedded resources (textures) of this mod
    /// </summary>
    public Dictionary<string, byte[]> Resources { get; internal set; }

    /// <summary>
    /// The prefix used for the IDs of towers, upgrades, etc for this mod to prevent conflicts with other mods
    /// </summary>
    public virtual string IDPrefix => this.GetAssembly().GetName().Name + "-";

    /// <summary>
    /// Signifies that the game shouldn't crash / the mod shouldn't stop loading if one of its patches fails
    /// </summary>
    public virtual bool OptionalPatches => true;
}