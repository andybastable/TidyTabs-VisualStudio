﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaveMcKeown.TidyTabs.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DaveMcKeown.TidyTabs.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum number of tabs that should be open. The oldest tabs will be closed until this number is met, even if they do not exceed the time-out value..
        /// </summary>
        public static string MaxOpenTabs_Description {
            get {
                return ResourceManager.GetString("MaxOpenTabs_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum Open Tabs.
        /// </summary>
        public static string MaxOpenTabs_DisplayName {
            get {
                return ResourceManager.GetString("MaxOpenTabs_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Behavior.
        /// </summary>
        public static string OptionPage_Behavior {
            get {
                return ResourceManager.GetString("OptionPage_Behavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        public static string OptionPage_Settings {
            get {
                return ResourceManager.GetString("OptionPage_Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controls if stale tabs should be automatically closed when opening a new document.
        /// </summary>
        public static string PurgeOnOpen_Description {
            get {
                return ResourceManager.GetString("PurgeOnOpen_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close on open.
        /// </summary>
        public static string PurgeOnOpen_DisplayName {
            get {
                return ResourceManager.GetString("PurgeOnOpen_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controls if stale tabs should be automatically closed when saving a document.
        /// </summary>
        public static string PurgeOnSave_Description {
            get {
                return ResourceManager.GetString("PurgeOnSave_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close on save.
        /// </summary>
        public static string PurgeOnSave_DisplayName {
            get {
                return ResourceManager.GetString("PurgeOnSave_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number tabs that must be open before inactive tabs begin to be closed by Tidy Tabs. Set to 0 to always close inactive tabs..
        /// </summary>
        public static string TabCloseThreshold_Description {
            get {
                return ResourceManager.GetString("TabCloseThreshold_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Tab Threshold.
        /// </summary>
        public static string TabCloseThreshold_DisplayName {
            get {
                return ResourceManager.GetString("TabCloseThreshold_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The time-out before a tab becomes inactive if not viewed or modified..
        /// </summary>
        public static string TabTimeoutMinutes_Description {
            get {
                return ResourceManager.GetString("TabTimeoutMinutes_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout Minutes.
        /// </summary>
        public static string TabTimeoutMinutes_DisplayName {
            get {
                return ResourceManager.GetString("TabTimeoutMinutes_DisplayName", resourceCulture);
            }
        }
    }
}
