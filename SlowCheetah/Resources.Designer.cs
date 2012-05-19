﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17624
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlowCheetah.VisualStudio {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SlowCheetah.VisualStudio.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Slow Cheetah.
        /// </summary>
        internal static string _100 {
            get {
                return ResourceManager.GetString("100", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        internal static string _101 {
            get {
                return ResourceManager.GetString("101", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the preview tool {0}. Verify the settings in the &apos;Config Transform&apos; category of Tools\Options..
        /// </summary>
        internal static string Error_CantFindPreviewTool {
            get {
                return ResourceManager.GetString("Error_CantFindPreviewTool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No preview tool specified. You can set a preview tool in the &apos;Config Transform&apos; category of Tools\Options..
        /// </summary>
        internal static string Error_NoPreviewToolSpecified {
            get {
                return ResourceManager.GetString("Error_NoPreviewToolSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to save the project file {0}. {1}.
        /// </summary>
        internal static string Error_SavingProjectFile {
            get {
                return ResourceManager.GetString("Error_SavingProjectFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source file for the transform {0} was not found..
        /// </summary>
        internal static string Error_SourceFileNotFound {
            get {
                return ResourceManager.GetString("Error_SourceFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The transform file {0} was not found..
        /// </summary>
        internal static string Error_TransformFileNotFound {
            get {
                return ResourceManager.GetString("Error_TransformFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line to pass to the preview tool. {0} is the original file, {1} is the transformed file.
        /// </summary>
        internal static string PropDesc_PreviewToolCommandLine {
            get {
                return ResourceManager.GetString("PropDesc_PreviewToolCommandLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The full path to the tool used to show the results of the transformation.
        /// </summary>
        internal static string PropDesc_PreviewToolExecutablePath {
            get {
                return ResourceManager.GetString("PropDesc_PreviewToolExecutablePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set to false to disable the preview tool and just show the transformed file.
        /// </summary>
        internal static string PropDesc_RunPreviewTool {
            get {
                return ResourceManager.GetString("PropDesc_RunPreviewTool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preview Tool Command Line.
        /// </summary>
        internal static string PropName_PreviewToolCommandLine {
            get {
                return ResourceManager.GetString("PropName_PreviewToolCommandLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preview Tool Executable Path.
        /// </summary>
        internal static string PropName_PreviewToolExecutablePath {
            get {
                return ResourceManager.GetString("PropName_PreviewToolExecutablePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run Preview Tool.
        /// </summary>
        internal static string PropName_RunPreviewTool {
            get {
                return ResourceManager.GetString("PropName_RunPreviewTool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to support transforms your project file will need to be modified. This will cause your project to be unloaded and then reloaded. If your project is checked into source control then it may be checked out.\n\nChoose Yes to proceed otherwise No..
        /// </summary>
        internal static string String_AddImportText {
            get {
                return ResourceManager.GetString("String_AddImportText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Transform Project Import.
        /// </summary>
        internal static string String_AddImportTitle {
            get {
                return ResourceManager.GetString("String_AddImportTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.{1}{2}.
        /// </summary>
        internal static string String_FormatTransformFilename {
            get {
                return ResourceManager.GetString("String_FormatTransformFilename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $().
        /// </summary>
        internal static string String_ImportPath {
            get {
                return ResourceManager.GetString("String_ImportPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SlowCheetahImport.
        /// </summary>
        internal static string String_SlowCheetahImportProp {
            get {
                return ResourceManager.GetString("String_SlowCheetahImportProp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;\n&lt;!-- For more information on using transformations see the web.config examples at http://go.microsoft.com/fwlink/?LinkId=214134. --&gt;\n.
        /// </summary>
        internal static string String_TransformFileContents {
            get {
                return ResourceManager.GetString("String_TransformFileContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;!-- For more information on using transformations 
        ///     see the web.config examples at http://go.microsoft.com/fwlink/?LinkId=214134. --&gt;
        ///.
        /// </summary>
        internal static string TransformContents {
            get {
                return ResourceManager.GetString("TransformContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Preview.
        /// </summary>
        internal static string TransformPreview_Caption {
            get {
                return ResourceManager.GetString("TransformPreview_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Original {0}.
        /// </summary>
        internal static string TransformPreview_LeftLabel {
            get {
                return ResourceManager.GetString("TransformPreview_LeftLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformed {0}   (by  {1} ).
        /// </summary>
        internal static string TransformPreview_RightLabel {
            get {
                return ResourceManager.GetString("TransformPreview_RightLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Preview.
        /// </summary>
        internal static string TransformPreview_ToolTip {
            get {
                return ResourceManager.GetString("TransformPreview_ToolTip", resourceCulture);
            }
        }
    }
}
