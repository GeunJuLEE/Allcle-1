﻿#pragma checksum "..\..\DefineGuestMajor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C7FB705A6D7C18238E3D17E39F30B40D05C436D"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
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


namespace Client {
    
    
    /// <summary>
    /// DefineGuestMajor
    /// </summary>
    public partial class DefineGuestMajor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\DefineGuestMajor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hakbun_cbox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DefineGuestMajor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hakbun_cbox_text;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\DefineGuestMajor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox major_cbox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\DefineGuestMajor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock major_cbox_text;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/defineguestmajor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DefineGuestMajor.xaml"
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
            this.hakbun_cbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\DefineGuestMajor.xaml"
            this.hakbun_cbox.DropDownClosed += new System.EventHandler(this.hakbun_cbx_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.hakbun_cbox_text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.major_cbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\DefineGuestMajor.xaml"
            this.major_cbox.DropDownClosed += new System.EventHandler(this.major_cbx_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.major_cbox_text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 45 "..\..\DefineGuestMajor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

