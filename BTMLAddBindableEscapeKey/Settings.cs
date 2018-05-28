using InControl;

namespace BTMLAddBindableEscapeKey
{
    // the properties in in here are to be a deserializer step from JSON format
    // into the C# variables used by the mod.
    public class Settings
    {
        public bool EnableSpaceKey = true;

        public bool enableSpaceKey
        {
            set => EnableSpaceKey = value;
        }

        public bool EnableMouseButton = true;

        public bool enableMouseButton
        {
            set => EnableMouseButton = value;
        }

        public Mouse EscapeMouseButton = Mouse.Button4;
        public int _escapeMouseButtonInput = 4;

        public int escapeMouseButton
        {
            set
            {
                _escapeMouseButtonInput = value;
                if(value >= 4 && value <= 9)
                {
                    switch(value)
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
                        default:
                            EscapeMouseButton = Mouse.Button4;
                            break;
                    }
                }
                if(value == 2)
                {
                    Logger.LogLine("WARNING THIS IS UNSUPPORTED. THIS MAY BREAK FUNCTIONALITY SINCE RIGHT MOUSE IS BOUND IN GAME A BUNCH OF PLACES!!!");
                    EscapeMouseButton = Mouse.RightButton;
                }
                if (value == 3)
                {
                    Logger.LogLine("WARNING THIS IS UNSUPPORTED. THIS MAY BREAK FUNCTIONALITY SINCE RIGHT MOUSE IS BOUND IN GAME A BUNCH OF PLACES!!!");
                    EscapeMouseButton = Mouse.RightButton;
                }
            }
        }
    }
}