﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetadataExtensionsDemo.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MetadataExtensionsDemo.Web.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to First Name (from Resource).
        /// </summary>
        public static string Character_FirstName {
            get {
                return ResourceManager.GetString("Character_FirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first name is required. Really. (from Resource).
        /// </summary>
        public static string Character_FirstName_Required {
            get {
                return ResourceManager.GetString("Character_FirstName_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hit Points (from resource).
        /// </summary>
        public static string Character_HitPoints {
            get {
                return ResourceManager.GetString("Character_HitPoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Testing Hit Points required from resource.
        /// </summary>
        public static string Character_HitPoints_Required {
            get {
                return ResourceManager.GetString("Character_HitPoints_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last Name (from Resource).
        /// </summary>
        public static string Character_LastName {
            get {
                return ResourceManager.GetString("Character_LastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; Required Fallback Error Message from resource.
        /// </summary>
        public static string Error_Required {
            get {
                return ResourceManager.GetString("Error_Required", resourceCulture);
            }
        }
    }
}
