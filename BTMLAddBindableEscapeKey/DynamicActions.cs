using BattleTech;
using BattleTech.UI;
using Harmony;
using InControl;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BattleTech.Data;
using BattleTech.UI.Tooltips;
using HBS;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BTMLAddBindableEscapeKey
{
    public class KeyBinding
    {
        public class Adapter<T>
        {
            public readonly T instance;
            public readonly Traverse traverse;

            protected Adapter(T instance)
            {
                this.instance = instance;
                traverse = Traverse.Create(instance);
            }
        }

        //[HarmonyPatch(typeof(InputManagerExtended),"Key_Escape")]
        //public static class InputManagerExtended_Patch
        //{ 
        //    public static PlayerAction Patch(BTInput __input)
        //    {
        //        Logger.LogLine("In Patch");
        //        try
        //        { 
        //            if(EscapeStatic == null)
        //            {
        //                Logger.LogLine("is null, fetching adapter");
        //                var adapter = new StaticActionsAdapter(__input.StaticActions);
        //                Logger.LogLine("fetched Adapter");
        //                EscapeStatic = adapter.CreatePlayerAction("Escape");
        //                Logger.LogLine("action created");
        //                EscapeStatic.AddDefaultBinding(new Key[]
        //                                {
        //                                    Key.Escape,
        //                                    Key.Space
        //                                });
        //                Logger.LogLine("New binding set");
        //            }
        //        }
        //        catch(Exception e)
        //        {
        //            Logger.LogError(e);
        //        }
        //        return EscapeStatic;
        //    }
        //}

        //    internal class StaticActionsAdapter : Adapter<StaticActions>
        //{
        //    internal StaticActionsAdapter(StaticActions instance) : base(instance)
        //    {
        //    }

        //    internal PlayerAction CreatePlayerAction(string name)
        //    {
        //        return traverse.Method("CreatePlayerAction", name).GetValue<PlayerAction>(name); ;
        //    }
        //}

        //public static PlayerAction EscapeStatic = null;

        //public static PlayerAction Escape1Keybind;

        //public static PlayerAction Escape2Keybind;

        //[HarmonyPatch(typeof(BattleTech.UI.UIManager), "Update")]
        //public static class UIManager_Patch { 
        //    public static bool Prefix(UIManager __instance)
        //    {
        //        if (Escape1Keybind.WasReleased)
        //        {
        //            Logger.LogLine($"EscapeKeybind Pressed [1: {Escape1Keybind.WasReleased}]");
        //            ReflectionHelper.InvokePrivateMethode(__instance, "HandleEscapeKeypress", null);
        //        }
        //        return true;
        //    }
        //}

        //[HarmonyPatch(typeof(BTInput),"BTInput")]
        //public static class BTInput_Patch
        //{
        //    public static void Postfix(BTInput __instance)
        //    {
        //        Logger.LogLine("Clearing Default Bindings for Escape");
        //        __instance.StaticActions.Escape.ClearBindings();
        //        Logger.LogLine("Setting Escape and Space defaults for Escape");
        //        __instance.StaticActions.Escape.AddDefaultBinding(new Key[]
        //        {
        //            Key.Escape,
        //            Key.Space
        //        });
        //        Logger.LogLine("New escape defaults set!");
        //    }
        //}

        //[HarmonyPatch(typeof(BTInput), "LoadDefaultBindings")]
        //public static class BTInput_Patch_LoadDefaultBindings
        //{
        //    public static void Postfix(BTInput __instance)
        //    {
        //        Logger.LogLine("Clearing void Default Bindings for Escape");
        //        __instance.StaticActions.Escape.ClearBindings();
        //        Logger.LogLine("Setting void Escape and Space defaults for Escape");
        //        __instance.StaticActions.Escape.AddDefaultBinding(new Key[]
        //        {
        //            Key.Escape,
        //            Key.Space
        //        });
        //        Logger.LogLine("New void escape defaults set!");
        //    }
        //}

        [HarmonyPatch(typeof(StaticActions), "CreateWithDefaultBindings")]
        public static class StaticActions_Patch_CreateWDB
        {
            public static void Postfix(ref StaticActions __result)
            {
                Logger.LogLine("Postfix for CreateWDB fired");
                Logger.LogLine("Clearing void Default Bindings for Escape");
                __result.Escape.ClearBindings();
                Logger.LogLine("Setting void Escape defaults for Escape");
                __result.Escape.AddDefaultBinding(new Key[]
                {
                    Key.Escape
                });
                Logger.LogLine("Setting void Now Space Default for Escape");
                __result.Escape.AddDefaultBinding(new Key[]
                {
                    Key.Space
                });
                Logger.LogLine("New void escape defaults set!");
            }
        }


        //[HarmonyPatch(typeof(DynamicActions), "CreateWithDefaultBindings")]
        //public static class DynamicActionsCreateWithDefaultBindingsPatch
        //{


        //    public static void Postfix(DynamicActions __result)
        //    {
        //        try
        //        {
        //            var adapter = new DynamicActionsAdapter(__result);
        //            Escape1Keybind = adapter.CreatePlayerAction("Escape 1");
        //            Escape1Keybind.AddDefaultBinding(Key.Space);
        //            Logger.LogLine("Keybind Escape 1 Added");

        //            //Escape1Keybind = adapter.CreatePlayerAction("Escape 2");
        //            //Escape1Keybind.AddDefaultBinding(Key.Space);
        //            //Logger.LogLine("Keybind Escape 2 Added");


        //        }
        //        catch (Exception e)
        //        {
        //            Logger.LogError(e);
        //        }
        //    }
        //}

        //internal class DynamicActionsAdapter : Adapter<DynamicActions>
        //{
        //    internal DynamicActionsAdapter(DynamicActions instance) : base(instance)
        //    {
        //    }

        //    internal PlayerAction CreatePlayerAction(string name)
        //    {
        //        return traverse.Method("CreatePlayerAction", name).GetValue<PlayerAction>(name); ;
        //    }
        //}
    }
}