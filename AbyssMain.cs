using System;
using System.IO;
using Abyss.Api;
using Abyss.Events;
using Abyss.UI;
using Abyss.Utilities;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using Coffee.UIExtensions;
using CommandTerminal;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Abyss;

[BepInPlugin(Id, Name, Version)]
internal sealed class AbyssMain : DredgeMod
{
    private const string Id = "com.grahamkracker.abyss.core";
    private const string Name = "Abyss.Core";
    private const string Version = "0.0.1";

    public static readonly ManualLogSource UnityLog = new("Abyss Unity Log");

    private void Awake()
    {
        AbyssUtils.Main = this;
        BepInEx.Logging.Logger.Sources.Add(UnityLog);
    }

    public override void Start()
    {
        base.Start();
        foreach (var localizedModContent in ModContent.GetContent<LocalizedModContent>())
        {
            LocalizationManager.AddModLocalization(localizedModContent);
        }

        GameObject terminal = new GameObject("Abyss.Terminal");
        terminal.AddComponent<Terminal>();
        DontDestroyOnLoad(terminal);

        GameObject taskScheduler = new GameObject("Abyss.TaskScheduler");
        taskScheduler.AddComponent<TaskScheduler>();
        DontDestroyOnLoad(taskScheduler);

        GameManager.Instance.BuildInfo.BuildNumber += $"\nAbyss v{Version}";

        SceneManager.sceneLoaded += SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        try
        {
            AbyssEvents.InvokeSceneLoaded(scene);

            if (scene.name == "Title")
            {
                var buttonContainer = GameObject.Find("ButtonContainer").transform;
                var modsButton = Instantiate(buttonContainer.GetChild(0), buttonContainer, false).gameObject;
                modsButton.transform.SetSiblingIndex(2);
                Destroy(modsButton.GetComponent<ContinueOrNewButton>());
                modsButton.name = modsButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = $"Mods ({Chainloader.PluginInfos.Count})";

                var settingsMenu = GameObject.Find("SettingsDialog");
                var modsMenu = Instantiate(settingsMenu, settingsMenu.transform.parent, false).gameObject;

                DestroyImmediate(modsButton.GetComponentInChildren<LocalizeStringEvent>());
                DestroyImmediate(modsMenu.GetComponent<SettingsDialog>());
                DestroyImmediate(modsButton.GetComponent<UITransitionEffect>());
                DestroyImmediate(modsButton.GetComponent<BasicButtonWrapper>());
                DestroyImmediate(modsButton.GetComponent<BasicButton>());
                DestroyImmediate(modsButton.GetComponent<UISelectable>());
                DestroyImmediate(modsButton.GetComponent<CustomSelectable>());

                var modsMenuComponent = modsMenu.AddComponent<ModsMenu>();

                var basicButton = modsButton.AddComponent<ModsMenuButton>();
                basicButton.onClick ??= new Button.ButtonClickedEvent();

                basicButton.onClick.AddListener(() =>
                {
                    modsMenu.SetActive(true);
                    modsMenuComponent.OnClick();
                });
            }

        }
        catch (Exception e)
        {
            AbyssLogger.Error("SceneLoaded errored: ");
            AbyssLogger.Error(e.ToString());
        }
    }
}