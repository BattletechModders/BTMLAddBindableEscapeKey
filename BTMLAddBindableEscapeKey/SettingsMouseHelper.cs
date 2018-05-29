using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InControl;

namespace BTMLAddBindableEscapeKey
{
    public static class SettingsMouseHelper
    {
        // Defaults to Mouse.Button4;
        public static Mouse GetButtonFromInt(int value)
        {
            Mouse EscapeMouseButton = Mouse.Button4;
 
            switch (value)
            {
                case 4:
                    EscapeMouseButton = Mouse.Button4;
                    break;
                case 5:
                    EscapeMouseButton = Mouse.Button5;
                    break;
                case 6:
                    EscapeMouseButton = Mouse.Button6;
                    break;
                case 7:
                    EscapeMouseButton = Mouse.Button7;
                    break;
                case 8:
                    EscapeMouseButton = Mouse.Button8;
                    break;
                case 9:
                    EscapeMouseButton = Mouse.Button9;
                    break;
                case 2:
                    Logger.LogLine("WARNING THIS IS UNSUPPORTED. THIS MAY BREAK FUNCTIONALITY SINCE RIGHT MOUSE IS BOUND IN GAME A BUNCH OF PLACES!!!");
                    EscapeMouseButton = Mouse.RightButton;
                    break;
                case 3:
                    Logger.LogLine("WARNING THIS IS UNSUPPORTED. THIS MAY BREAK FUNCTIONALITY SINCE RIGHT MOUSE IS BOUND IN GAME A BUNCH OF PLACES!!!");
                    EscapeMouseButton = Mouse.RightButton;
                    break;
                default:
                    EscapeMouseButton = Mouse.Button4;
                    break;
            }
            return EscapeMouseButton;
        }
    }
}

