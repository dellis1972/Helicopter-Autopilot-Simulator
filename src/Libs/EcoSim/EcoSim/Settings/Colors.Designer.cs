﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sim.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Colors : global::System.Configuration.ApplicationSettingsBase {
        
        private static Colors defaultInstance = ((Colors)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Colors())));
        
        public static Colors Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 255, 255")]
        public global::Microsoft.Xna.Framework.Graphics.Color ButtonUp {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["ButtonUp"]));
            }
            set {
                this["ButtonUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("112, 128, 144, 255")]
        public global::Microsoft.Xna.Framework.Graphics.Color ButtonDown {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["ButtonDown"]));
            }
            set {
                this["ButtonDown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("173, 216, 230, 255")]
        public global::Microsoft.Xna.Framework.Graphics.Color ButtonHover {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["ButtonHover"]));
            }
            set {
                this["ButtonHover"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0, 0, 128")]
        public global::Microsoft.Xna.Framework.Graphics.Color PanelBG {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["PanelBG"]));
            }
            set {
                this["PanelBG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 255, 255")]
        public global::Microsoft.Xna.Framework.Graphics.Color Text {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["Text"]));
            }
            set {
                this["Text"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0, 0, 128")]
        public global::Microsoft.Xna.Framework.Graphics.Color TextShadow {
            get {
                return ((global::Microsoft.Xna.Framework.Graphics.Color)(this["TextShadow"]));
            }
            set {
                this["TextShadow"] = value;
            }
        }
    }
}
