﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.18444
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompositeExtensions.Unity.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
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
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CompositeExtensions.Unity.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   The ILoggerFacade is required and cannot be null. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NullLoggerFacadeException {
            get {
                return ResourceManager.GetString("NullLoggerFacadeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The IModuleEnumerator is required and cannot be null in order to initialize the modules. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NullModuleEnumeratorException {
            get {
                return ResourceManager.GetString("NullModuleEnumeratorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The IModuleLoader is required and cannot be null in order to initialize the modules. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NullModuleLoaderException {
            get {
                return ResourceManager.GetString("NullModuleLoaderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The IUnityContainer is required and cannot be null. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NullUnityContainerException {
            get {
                return ResourceManager.GetString("NullUnityContainerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Type &apos;{0}&apos; was already registered by the application. Skipping... に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TypeMappingAlreadyRegistered {
            get {
                return ResourceManager.GetString("TypeMappingAlreadyRegistered", resourceCulture);
            }
        }
    }
}
