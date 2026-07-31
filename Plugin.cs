using System;
using BepInEx;
using UnityEngine;
using Diros.Rigging;

namespace Diros.Plugin;

[BepInPlugin("com.diros.gorillatag.diros", "Diros", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    public static Plugin instance;

    private void Awake()
    {
        instance = this;
        Debug.Log("[Diros] Plugin initialized");
        gameObject.AddComponent<InputHandler>();
        gameObject.AddComponent<Rig>();
    }
}
