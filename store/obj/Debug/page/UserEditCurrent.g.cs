﻿#pragma checksum "..\..\..\page\UserEditCurrent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EAA3CFF7D8CA7778DC07241A480C70A06773A24C"
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
    /// UserEditCurrent
    /// </summary>
    public partial class UserEditCurrent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_name;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_mail;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_phone;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker data_bithday;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Gender;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Type;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\page\UserEditCurrent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_new_pas;
        
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
            System.Uri resourceLocater = new System.Uri("/store;component/page/usereditcurrent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\page\UserEditCurrent.xaml"
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
            this.Txt_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Txt_mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Txt_phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.data_bithday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cmb_Gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cmb_Type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\page\UserEditCurrent.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.Btn_save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_new_pas = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\page\UserEditCurrent.xaml"
            this.btn_new_pas.Click += new System.Windows.RoutedEventHandler(this.Btn_new_pas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

