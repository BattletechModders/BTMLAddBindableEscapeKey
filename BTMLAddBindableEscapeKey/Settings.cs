using InControl;
using System.Collections.Generic;

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

        public List<int> __additionalMouseButtons = new List<int>();

        public int escapeMouseButton
        {
            set
            {
                _escapeMouseButtonInput = value;
                if (value >= 4 && value <= 9)
                {
                    EscapeMouseButton = SettingsMouseHelper.GetButtonFromInt(value);
                }
            }
        }
    }
}


 