﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShell.Providers.UI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)\\{%\\s?include (\\\"[\\w./]*\\\"|\\\'[\\w./]*\\\')\\s?%\\}")]
        public string Reg_Include {
            get {
                return ((string)(this["Reg_Include"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)\\{%\\s?block \\w*\\s?%\\}(.|\\r\\n)*\\{%\\s?endblock\\s?%\\}")]
        public string Reg_Block {
            get {
                return ((string)(this["Reg_Block"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)\\{%\\s?extends \\\"[\\w./]*\\\"\\s?%\\}")]
        public string Reg_Extend {
            get {
                return ((string)(this["Reg_Extend"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\"[\\w./]*\\\"|\\\'[\\w./]*\\\'")]
        public string Reg_FilePath {
            get {
                return ((string)(this["Reg_FilePath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)\\{%\\s?block \\w*\\s?%\\}")]
        public string Reg_BlockStart {
            get {
                return ((string)(this["Reg_BlockStart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{%\\s?endblock\\s?%\\}")]
        public string Reg_BlockEnd {
            get {
                return ((string)(this["Reg_BlockEnd"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(.|\\r\\n)*?")]
        public string Reg_BlockContent {
            get {
                return ((string)(this["Reg_BlockContent"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)\\{%|\\s|block|%\\}")]
        public string Reg_BlockName {
            get {
                return ((string)(this["Reg_BlockName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\{\\{\\s?\\w*\\s?\\}\\}")]
        public string Reg_VarPattern {
            get {
                return ((string)(this["Reg_VarPattern"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\{\\s\\}]*")]
        public string Reg_VarName {
            get {
                return ((string)(this["Reg_VarName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("((?i)\\{%\\s?block \\w*\\s?%\\})|((?i)\\{%\\s?endblock\\s?%\\})")]
        public string Reg_BlockValue {
            get {
                return ((string)(this["Reg_BlockValue"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?<=(?i)\\{%\\s?block \\w*\\s?%\\})")]
        public string Reg_BlockStartSearch {
            get {
                return ((string)(this["Reg_BlockStartSearch"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?=(?i)\\{%\\s?endblock\\s?%\\})")]
        public string Reg_BlockEndSearch {
            get {
                return ((string)(this["Reg_BlockEndSearch"]));
            }
        }
    }
}
