// Using Region
#region Using 

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using BepInEx;
using BepInEx.Logging;
using SideLoader;
using SideLoader.Helpers;
using UnityEngine;

#endregion

/* Comments
 *
 * Peacemaker Elixir (skill) ID : 8205320
 * Peacemaker Elixir (item) ID  : 4300270
 *
 */

namespace StackablePeacemakerMod
{
    // Don't forget this attribute. The ID, NAME and VERSION are your const values below.
    [BepInPlugin(ID, NAME, VERSION)]

    // You can delete this if you don't use ReSharper by JetBrains
    [SuppressMessage("ReSharper", "InconsistentNaming")]

    //
    public class StackablePeacemaker : BaseUnityPlugin
    {
        private const string ID = "com.NathanielGarro.StackablePeacemaker";
        private const string NAME = "Stackable Peacemaker";
        private const string VERSION = "0.1";

        // This is your entry-point for the mod.
        // BepInEx has created a GameObject and added the class as a component to it.
        internal void Awake()
        {
            SL.OnPacksLoaded += GetOriginalSkill;
            
            Logger.Log(LogLevel.Message, NAME + " version " + VERSION + " has successfully been loaded."); /* Prints to "BepInEx\LogOutput.log" */
        }

        // Get the original Peacemaker Elixir skill and save an instance of it
        private void GetOriginalSkill()
        {
            Logger.Log(LogLevel.Message, "Trying to get original Item...");
            try
            {
                var PeacemakerElixir = ResourcesPrefabManager.Instance.GetItemPrefab("8205320") as PassiveSkill;
                Logger.Log(LogLevel.Message, " Item ID 8205320 is : " + PeacemakerElixir.Name + " and is stackable : " + PeacemakerElixir.IsStackable);
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Message, " Item ID 8205320 couldn't be loaded : " + e);
                throw;
            }
        }
    }
}
