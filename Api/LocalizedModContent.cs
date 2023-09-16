using System;
using System.Collections.Generic;
using System.IO;
using Abyss.Extensions;
using Abyss.Extensions.SystemExtensions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine.Localization;

namespace Abyss.Api;

/// <summary>
/// ModContent that has includes localization
/// </summary>
[PublicAPI]
public abstract class LocalizedModContent : ModContent
{
    /// <summary>
    /// The name that will be used ingame
    /// </summary>
    public virtual string DisplayName => Name.Spaced();

    /// <summary>
    /// The description that will be used ingame
    /// </summary>
    public virtual string Description => $"{DisplayName} is from {Mod.GetName()}";


    /// <summary>
    /// Override this to register custom text in the LocalizationManager
    /// </summary>
    /// <param name="textTable"></param>
    /// <exclude />
    public virtual void RegisterText(Dictionary<string, string> textTable)
    {
    }
}