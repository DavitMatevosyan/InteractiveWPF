﻿#pragma checksum "..\..\..\Windows\CreateAccountWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B34005D7E3ADB35B14F210AA942C313F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PrivateData.Windows;
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


namespace PrivateData.Windows {
    
    
    /// <summary>
    /// CreateAccountWindow
    /// </summary>
    public partial class CreateAccountWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fnametxt;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lnametxt;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox daytxt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox monthtxt;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yeartxt;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logintxt;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailtxt;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passtxt;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passreptxt;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbQuestions;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\CreateAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sqanstxt;
        
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
            System.Uri resourceLocater = new System.Uri("/PrivateData;component/windows/createaccountwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\CreateAccountWindow.xaml"
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
            
            #line 35 "..\..\..\Windows\CreateAccountWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fnametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lnametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.daytxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.monthtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.yeartxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.logintxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.emailtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.passtxt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            this.passreptxt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 11:
            this.cbQuestions = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.sqanstxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 93 "..\..\..\Windows\CreateAccountWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registerbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

