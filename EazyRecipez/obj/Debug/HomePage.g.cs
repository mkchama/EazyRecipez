﻿#pragma checksum "..\..\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BD5D17CD81A94BCBB1AE67B8F9DA68E189DDEC9EB5D08ECAF06B3B4201022A75"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EazyRecipez;
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


namespace EazyRecipez {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Breakfast;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ThePanel;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/EazyRecipez;component/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomePage.xaml"
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
            
            #line 17 "..\..\HomePage.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Breakfast = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\HomePage.xaml"
            this.Breakfast.Click += new System.Windows.RoutedEventHandler(this.Breakfast_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Lunch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dinner_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dessert_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 47 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Appetizer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\HomePage.xaml"
            this.searchBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RecipeName_MouseDown);
            
            #line default
            #line hidden
            
            #line 58 "..\..\HomePage.xaml"
            this.searchBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeName_LostFocus);
            
            #line default
            #line hidden
            
            #line 58 "..\..\HomePage.xaml"
            this.searchBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.searchBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\HomePage.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ThePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 68 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Recipe_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 12:
            
            #line 125 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Profile_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 126 "..\..\HomePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

