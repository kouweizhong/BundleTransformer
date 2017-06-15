﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BundleTransformer.Core.Resources {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BundleTransformer.Core.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Could not find the &apos;{0}&apos; file in the &apos;{1}&apos; bundle..
        /// </summary>
        public static string AssetHandler_BundleFileNotFound {
            get {
                return ResourceManager.GetString("AssetHandler_BundleFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bundle &apos;{0}&apos; not exist..
        /// </summary>
        public static string AssetHandler_BundleNotFound {
            get {
                return ResourceManager.GetString("AssetHandler_BundleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During the output text content of processed asset is not found one of its dependencies.
        ///See more details:
        ///{0}.
        /// </summary>
        public static string AssetHandler_DependencyNotFound {
            get {
                return ResourceManager.GetString("AssetHandler_DependencyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the transformer in the &apos;{0}&apos; bundle..
        /// </summary>
        public static string AssetHandler_TransformerNotFound {
            get {
                return ResourceManager.GetString("AssetHandler_TransformerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the translator of `{0}` type for the &apos;{1}&apos; asset..
        /// </summary>
        public static string AssetHandler_TranslatorNotFound {
            get {
                return ResourceManager.GetString("AssetHandler_TranslatorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During the output text content of processed asset an unknown error has occurred.
        ///See more details:
        ///{0}.
        /// </summary>
        public static string AssetHandler_UnknownError {
            get {
                return ResourceManager.GetString("AssetHandler_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pure wildcard ignore patterns `*` and `*.*` are not supported..
        /// </summary>
        public static string Assets_InvalidIgnorePattern {
            get {
                return ResourceManager.GetString("Assets_InvalidIgnorePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These assets are not scripts: {0}..
        /// </summary>
        public static string Assets_ScriptAssetsContainAssetsWithInvalidTypes {
            get {
                return ResourceManager.GetString("Assets_ScriptAssetsContainAssetsWithInvalidTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These assets are not style sheets: {0}..
        /// </summary>
        public static string Assets_StyleAssetsContainAssetsWithInvalidTypes {
            get {
                return ResourceManager.GetString("Assets_StyleAssetsContainAssetsWithInvalidTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter `{0}` must be a non-empty string..
        /// </summary>
        public static string Common_ArgumentIsEmpty {
            get {
                return ResourceManager.GetString("Common_ArgumentIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter `{0}` must be a non-nullable..
        /// </summary>
        public static string Common_ArgumentIsNull {
            get {
                return ResourceManager.GetString("Common_ArgumentIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not specified a name of assembly..
        /// </summary>
        public static string Common_AssemblyNameIsEmpty {
            get {
                return ResourceManager.GetString("Common_AssemblyNameIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not convert value &apos;{0}&apos; of enumeration type `{1}` to value of enumeration type `{2}`..
        /// </summary>
        public static string Common_EnumValueConversionFailed {
            get {
                return ResourceManager.GetString("Common_EnumValueConversionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find string code that corresponding to the value &apos;{0}&apos; of enumeration type `{1}`..
        /// </summary>
        public static string Common_EnumValueToCodeConversionFailed {
            get {
                return ResourceManager.GetString("Common_EnumValueToCodeConversionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; not exist..
        /// </summary>
        public static string Common_FileNotExist {
            get {
                return ResourceManager.GetString("Common_FileNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During instantiate an object of type `{0}` from assembly `{1}` error occurred..
        /// </summary>
        public static string Common_InstanceCreationFailed {
            get {
                return ResourceManager.GetString("Common_InstanceCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find a value of enumeration type `{0}` that corresponding to the severity level {1}..
        /// </summary>
        public static string Common_SeverityLevelToEnumValueConversionFailed {
            get {
                return ResourceManager.GetString("Common_SeverityLevelToEnumValueConversionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not specified a type name..
        /// </summary>
        public static string Common_TypeNameIsEmpty {
            get {
                return ResourceManager.GetString("Common_TypeNameIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error..
        /// </summary>
        public static string Common_UnknownError {
            get {
                return ResourceManager.GetString("Common_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to determine MIME type of the file &apos;{0}&apos;..
        /// </summary>
        public static string Common_UnknownMimeType {
            get {
                return ResourceManager.GetString("Common_UnknownMimeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty..
        /// </summary>
        public static string Common_ValueIsEmpty {
            get {
                return ResourceManager.GetString("Common_ValueIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null..
        /// </summary>
        public static string Common_ValueIsNull {
            get {
                return ResourceManager.GetString("Common_ValueIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default {0} minifier not specified..
        /// </summary>
        public static string Configuration_DefaultMinifierNotSpecified {
            get {
                return ResourceManager.GetString("Configuration_DefaultMinifierNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In the `name` attribute of `/configuration/bundleTransformer/{0}/jsEngine` configuration element not specified a name of JS engine.
        ///
        ///If you have not installed JS engine, then for correct working of this module is recommended to install one of the following NuGet packages: {1}
        ///
        ///After package is installed, need set a name of JS engine (for example, `{2}`) to the `name` attribute of `/configuration/bundleTransformer/{0}/jsEngine` configuration element..
        /// </summary>
        public static string Configuration_JsEngineNotSpecified {
            get {
                return ResourceManager.GetString("Configuration_JsEngineNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} minifier with name `{1}` is not registered in configuration file..
        /// </summary>
        public static string Configuration_MinifierNotRegistered {
            get {
                return ResourceManager.GetString("Configuration_MinifierNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} postprocessor with name `{1}` is not registered in configuration file..
        /// </summary>
        public static string Configuration_PostProcessorNotRegistered {
            get {
                return ResourceManager.GetString("Configuration_PostProcessorNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translator, which compiles the code on intermediate language to {0}, and has the name `{1}` is not registered in  configuration file..
        /// </summary>
        public static string Configuration_TranslatorNotRegistered {
            get {
                return ResourceManager.GetString("Configuration_TranslatorNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Column number.
        /// </summary>
        public static string ErrorDetails_ColumnNumber {
            get {
                return ResourceManager.GetString("ErrorDetails_ColumnNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End column.
        /// </summary>
        public static string ErrorDetails_EndColumn {
            get {
                return ResourceManager.GetString("ErrorDetails_EndColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End line.
        /// </summary>
        public static string ErrorDetails_EndLine {
            get {
                return ResourceManager.GetString("ErrorDetails_EndLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error code.
        /// </summary>
        public static string ErrorDetails_ErrorCode {
            get {
                return ResourceManager.GetString("ErrorDetails_ErrorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error type.
        /// </summary>
        public static string ErrorDetails_ErrorType {
            get {
                return ResourceManager.GetString("ErrorDetails_ErrorType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File.
        /// </summary>
        public static string ErrorDetails_File {
            get {
                return ResourceManager.GetString("ErrorDetails_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help keyword.
        /// </summary>
        public static string ErrorDetails_HelpKeyword {
            get {
                return ResourceManager.GetString("ErrorDetails_HelpKeyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line number.
        /// </summary>
        public static string ErrorDetails_LineNumber {
            get {
                return ResourceManager.GetString("ErrorDetails_LineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line source.
        /// </summary>
        public static string ErrorDetails_LineSource {
            get {
                return ResourceManager.GetString("ErrorDetails_LineSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message.
        /// </summary>
        public static string ErrorDetails_Message {
            get {
                return ResourceManager.GetString("ErrorDetails_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string ErrorDetails_Name {
            get {
                return ResourceManager.GetString("ErrorDetails_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script stack trace.
        /// </summary>
        public static string ErrorDetails_ScriptStackTrace {
            get {
                return ResourceManager.GetString("ErrorDetails_ScriptStackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Severity.
        /// </summary>
        public static string ErrorDetails_Severity {
            get {
                return ResourceManager.GetString("ErrorDetails_Severity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source error.
        /// </summary>
        public static string ErrorDetails_SourceError {
            get {
                return ResourceManager.GetString("ErrorDetails_SourceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source name.
        /// </summary>
        public static string ErrorDetails_SourceName {
            get {
                return ResourceManager.GetString("ErrorDetails_SourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start column.
        /// </summary>
        public static string ErrorDetails_StartColumn {
            get {
                return ResourceManager.GetString("ErrorDetails_StartColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start line.
        /// </summary>
        public static string ErrorDetails_StartLine {
            get {
                return ResourceManager.GetString("ErrorDetails_StartLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subcategory.
        /// </summary>
        public static string ErrorDetails_Subcategory {
            get {
                return ResourceManager.GetString("ErrorDetails_Subcategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to error.
        /// </summary>
        public static string ErrorType_Error {
            get {
                return ResourceManager.GetString("ErrorType_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to warning.
        /// </summary>
        public static string ErrorType_Warning {
            get {
                return ResourceManager.GetString("ErrorType_Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File extension &apos;{0}&apos; has already been added to mapping collection..
        /// </summary>
        public static string FileExtensionMapping_DuplicateFileExtension {
            get {
                return ResourceManager.GetString("FileExtensionMapping_DuplicateFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of {0} code, readed from the file &apos;{1}&apos;, by {2} error has occurred.	
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string Minifiers_MinificationFailed {
            get {
                return ResourceManager.GetString("Minifiers_MinificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of {0} code, readed from the file &apos;{1}&apos;, by {2} syntax error has occurred. 
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string Minifiers_MinificationSyntaxError {
            get {
                return ResourceManager.GetString("Minifiers_MinificationSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During postprocessing of {0} code, readed from the file &apos;{1}&apos;, by {2} error has occurred.	
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string PostProcessors_PostprocessingFailed {
            get {
                return ResourceManager.GetString("PostProcessors_PostprocessingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During postprocessing of {0} code, readed from the file &apos;{1}&apos;, by {2} syntax error has occurred. 
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string PostProcessors_PostprocessingSyntaxError {
            get {
                return ResourceManager.GetString("PostProcessors_PostprocessingSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource with name &apos;{0}&apos; is null..
        /// </summary>
        public static string Resources_ResourceIsNull {
            get {
                return ResourceManager.GetString("Resources_ResourceIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During translation of {0} code, readed from the file &apos;{2}&apos;, to {1} code error has occurred.
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string Translators_TranslationFailed {
            get {
                return ResourceManager.GetString("Translators_TranslationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During translation of {0} code, readed from the file &apos;{2}&apos;, to {1} code syntax error has occurred. 
        ///See more details:
        ///
        ///{3}.
        /// </summary>
        public static string Translators_TranslationSyntaxError {
            get {
                return ResourceManager.GetString("Translators_TranslationSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL &apos;{0}&apos; is not valid. Only application relative URLs (~/url) are allowed..
        /// </summary>
        public static string UrlMappings_OnlyAppRelativeUrlAllowed {
            get {
                return ResourceManager.GetString("UrlMappings_OnlyAppRelativeUrlAllowed", resourceCulture);
            }
        }
    }
}
