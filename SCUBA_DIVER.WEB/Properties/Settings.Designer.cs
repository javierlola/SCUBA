﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCUBA_DIVER.WEB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"metadata=res://*/ScubaData.csdl|res://*/ScubaData.ssdl|res://*/ScubaData.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=divesqlsrv.database.windows.net;initial catalog=dive_database;persist security info=True;user id=sqlbarryu;password=D@shboard123.;MultipleActiveResultSets=True;App=EntityFramework&quot;"" providerName=""System.Data.EntityClient")]
        public string ScubaDiveEntities {
            get {
                return ((string)(this["ScubaDiveEntities"]));
            }
        }
    }
}