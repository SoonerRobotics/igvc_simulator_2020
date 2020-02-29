﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

/// <summary>
/// Singletons could maybe improve this from having to be script ingame?
/// </summary>
public class ConfigLoader : MonoBehaviour
{
    public static ConfigLoader Instance;

    public ConfigExample configExample;

    void Start()
    {
        Instance = this;

        configExample = new ConfigExample("cfgExample");
        Debug.Log($"cfgExample: Loaded Camera Speed -> {configExample.cameraSpeed}");
        Debug.Log($"cfgExample: Loaded Directions -> {JsonConvert.SerializeObject(configExample.caridnals)}");

        DontDestroyOnLoad(this);
    }
}
