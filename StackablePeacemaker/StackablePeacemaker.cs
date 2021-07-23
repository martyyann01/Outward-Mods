// Using Region
#region Using 

using System;
using System.Diagnostics.CodeAnalysis;
using BepInEx;
using BepInEx.Logging;
using UnityEngine;

#endregion

//
namespace StackablePeacemakerMod
{
    // Don't forget this attribute. The ID, NAME and VERSION are your const values below.
    [BepInPlugin(ID, NAME, VERSION)]

    // You can delete this if you don't use ReSharper by JetBrains
    [SuppressMessage("ReSharper", "InconsistentNaming")]

    public class StackablePeacemaker : BaseUnityPlugin
    {
        private const string ID = "com.NathanielGarro.StackablePeacemaker";
        private const string NAME = "Stackable Peacemaker";
        private const string VERSION = "0.1";

        internal void Awake()
        {
            // This is your entry-point for your mod.
            // BepInEx has created a GameObject and added our class as a component to it.

            Logger.Log(LogLevel.Message, NAME + " version " + VERSION + " has successfully been loaded."); /* Prints to "BepInEx\LogOutput.log" */
        }
    }
}
