// Using Region
#region Using 

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using BepInEx;
using BepInEx.Logging;
using SideLoader;
using SideLoader.Helpers;
using UnityEngine;
using Object = System.Object;

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

    public class StackablePeacemaker : BaseUnityPlugin
    {
        private const string ID = "com.nathanielgarro.stackablepeacemaker"; // I understand it's better using lowercase ? maybe ? idk
        private const string NAME = "Stackable Peacemaker";
        private const string VERSION = "0.2";
        private PassiveSkill m_OriginalPeacemakerElixirPassiveSkill = null;
        private Item m_OriginalPeacemakerElixirItem = null;


        // This is your entry-point for the mod.
        // BepInEx has created a GameObject and added the class as a component to it.
        internal void Awake()
        {
            // Waiting for SideLoader to load its packs before proceeding
            SL.OnPacksLoaded += GetOriginalSkill;
            //SL.OnPacksLoaded += GetOriginalItem;
           
            /*
            // Cloning the skill
            CloneSkill
            (
                m_OriginalPeacemakerElixirPassiveSkill, 
                -16001, 
                "Peacemaker Elixir(s)", 
                m_OriginalPeacemakerElixirPassiveSkill.Description + " Maybe this effect will increase if you manage to find more Elixirs ?"
            );

            */
            
            Logger.Log(LogLevel.Message, NAME + " version " + VERSION + " has successfully been loaded."); /* Prints to "BepInEx\LogOutput.log" */
        }

        //Get the original Peacemaker Elixir skill and save an instance of it
        private void GetOriginalSkill()
        {
            Logger.Log(LogLevel.Message, "Trying to get original Skill...");
            try
            {
                // Getting the Peacemaker Elixir skill using ResourcesPrefabManager
                m_OriginalPeacemakerElixirPassiveSkill = ResourcesPrefabManager.Instance.GetItemPrefab("8205320") as PassiveSkill;
                if (m_OriginalPeacemakerElixirPassiveSkill != null)
                    Logger.Log(LogLevel.Message, " Item ID 8205320 successfully loaded.");
                else
                    Logger.Log(LogLevel.Error, "Item ID 8205320 couldn't be loaded.");
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Error, " Item ID 8205320 couldn't be loaded, an exception occured : " + e);
                throw;
            }
        }

        private void GetOriginalItem()
        {
            Logger.Log(LogLevel.Message, "Trying to get original Item...");
            try
            {
                // Getting the Peacemaker Elixir Item using ResourcesPrefabManager
                m_OriginalPeacemakerElixirItem = ResourcesPrefabManager.Instance.GetItemPrefab("4300270");
                if (m_OriginalPeacemakerElixirItem != null)
                    Logger.Log(LogLevel.Message, " Item ID 4300270 successfully loaded.");
                else
                    Logger.Log(LogLevel.Error, "Item ID 4300270 couldn't be loaded.");
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Error, " Item ID 4300270 couldn't be loaded, an exception occured : " + e);
                throw;
            }
        }

        //Clone the original skill and edit it to add the new effects
        private void CloneSkill(Skill m_OriginalSkill, int m_NewItemID, string m_NewName, string m_NewDescription)
        {
            SL_Skill m_ClonedSkill = new SL_Skill()
            {
                Target_ItemID = m_OriginalSkill.ItemID,
                New_ItemID = m_NewItemID,
                Name = m_NewName,
                Description = m_NewDescription,
                
            };

        }
    }
}
