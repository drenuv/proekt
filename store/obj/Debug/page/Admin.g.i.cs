﻿#pragma checksum "..\..\..\page\Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722BAABAF996361C220C4893C3EB9CA7B8F01D7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using store.page;


namespace store.page {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_manufacter;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_type;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_product;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_storage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_user;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\page\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_deals;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/store;component/page/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\page\Admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btn_edit_manufacter = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\page\Admin.xaml"
            this.btn_edit_manufacter.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_manufacter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_edit_type = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\page\Admin.xaml"
            this.btn_edit_type.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_type_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_edit_product = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\page\Admin.xaml"
            this.btn_edit_product.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_product_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_edit_storage = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\page\Admin.xaml"
            this.btn_edit_storage.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_storage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_edit_user = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\page\Admin.xaml"
            this.btn_edit_user.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_user_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_edit_deals = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\page\Admin.xaml"
            this.btn_edit_deals.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_deals_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

