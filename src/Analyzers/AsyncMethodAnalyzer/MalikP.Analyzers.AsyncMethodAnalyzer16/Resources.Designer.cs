﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MalikP.Analyzers.AsyncMethodAnalyzer
{
    using System;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MalikP.Analyzers.AsyncMethodAnalyzer.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Each asynchronous method or method returning &apos;Task&apos;, &apos;Task&lt;T&gt;&apos; should have &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_TaskMethod_Rule_Description
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_TaskMethod_Rule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; missing &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_TaskMethod_Rule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_TaskMethod_Rule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method missing &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_TaskMethod_Rule_Title
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_TaskMethod_Rule_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Each asynchronous method or method returning &apos;Task&apos;, &apos;Task&lt;T&gt;&apos; should have &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_VoidMethod_Rule_Description
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_VoidMethod_Rule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; missing &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_VoidMethod_Rule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_VoidMethod_Rule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method missing &apos;Async&apos; suffix.
        /// </summary>
        internal static string MethodMissingAsyncSuffix_VoidMethod_Rule_Title
        {
            get
            {
                return ResourceManager.GetString("MethodMissingAsyncSuffix_VoidMethod_Rule_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Each Asynchronous method or method returning &apos;Task&apos; or &apos;Task&lt;T&gt;&apos; should contains &apos;CancellationToken&apos; parameter to be possible cancel operation.
        /// </summary>
        internal static string MissingCancellationTokenParameter_TaskMethod_Rule_Description
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_TaskMethod_Rule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; missing &apos;CancellationToken&apos; parameter.
        /// </summary>
        internal static string MissingCancellationTokenParameter_TaskMethod_Rule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_TaskMethod_Rule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method missing &apos;CancellationToken&apos; parameter.
        /// </summary>
        internal static string MissingCancellationTokenParameter_TaskMethod_Rule_Title
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_TaskMethod_Rule_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Each Asynchronous method or method returning &apos;Task&apos; or &apos;Task&lt;T&gt;&apos; should contains &apos;CancellationToken&apos; parameter to be possible cancel operation.
        /// </summary>
        internal static string MissingCancellationTokenParameter_VoidMethod_Rule_Description
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_VoidMethod_Rule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; missing &apos;CancellationToken&apos; parameter.
        /// </summary>
        internal static string MissingCancellationTokenParameter_VoidMethod_Rule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_VoidMethod_Rule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method missing &apos;CancellationToken&apos; parameter.
        /// </summary>
        internal static string MissingCancellationTokenParameter_VoidMethod_Rule_Title
        {
            get
            {
                return ResourceManager.GetString("MissingCancellationTokenParameter_VoidMethod_Rule_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;CancellationToken&apos; should always have name &apos;cancellationToken&apos;.
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterNameRule_Description
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterNameRule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CancellationToken parameter &apos;{0}&apos; name differs from &apos;cancellationToken&apos;.
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterNameRule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterNameRule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;CancellationToken&apos; has incorrect name.
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterNameRule_Title
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterNameRule_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Reorder methods parameter and set &apos;CancellationToken&apos; as last parameter..
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterPositionRule_Description
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterPositionRule_Description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; does not contain parameter &apos;CancellationToken&apos; as last parameter..
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterPositionRule_MessageFormat
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterPositionRule_MessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Add &apos;CancellationToken&apos; as last parameter.
        /// </summary>
        internal static string WrongCancellationTokenMethodParameterPositionRule_Title
        {
            get
            {
                return ResourceManager.GetString("WrongCancellationTokenMethodParameterPositionRule_Title", resourceCulture);
            }
        }
    }
}
