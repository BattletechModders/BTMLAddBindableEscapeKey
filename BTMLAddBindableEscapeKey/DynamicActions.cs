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
    }
}