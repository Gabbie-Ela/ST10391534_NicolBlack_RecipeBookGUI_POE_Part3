﻿#pragma checksum "..\..\..\DisplayWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AEC6AD0CADA56F70B70CEB8C6B1EBD5969DEDBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ST10391534_NicolBlack_RecipeBookGUI_POE_Part3 {
    
    
    /// <summary>
    /// DisplayWindow
    /// </summary>
    public partial class DisplayWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewRecipes_btn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_btn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_btn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Heading;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox displayRecipeLBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox scaleCBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scale_btn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reset_btn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label closeBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ST10391534_NicolBlack_RecipeBookGUI_POE_Part3;component/displaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DisplayWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.viewRecipes_btn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\DisplayWindow.xaml"
            this.viewRecipes_btn.Click += new System.Windows.RoutedEventHandler(this.ViewRecipes_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.search_btn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\DisplayWindow.xaml"
            this.search_btn.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\DisplayWindow.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\DisplayWindow.xaml"
            this.exit_btn.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Heading = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.displayRecipeLBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.scaleCBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.scale_btn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\DisplayWindow.xaml"
            this.scale_btn.Click += new System.Windows.RoutedEventHandler(this.Scale_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.reset_btn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\DisplayWindow.xaml"
            this.reset_btn.Click += new System.Windows.RoutedEventHandler(this.Reset_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.closeBtn = ((System.Windows.Controls.Label)(target));
            
            #line 71 "..\..\..\DisplayWindow.xaml"
            this.closeBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

