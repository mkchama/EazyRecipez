﻿#pragma checksum "..\..\AppetizerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42AD5021A6332F1974D7C93D5E583E9D0AB1AA4F8118F0B3948FFFCD7C4BA1BF"
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
    /// AppetizerPage
    /// </summary>
    public partial class AppetizerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Breakfast;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ThePanel;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button breadRecipe;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\AppetizerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EazyRecipez;component/appetizerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppetizerPage.xaml"
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
            
            #line 18 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Breakfast = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AppetizerPage.xaml"
            this.Breakfast.Click += new System.Windows.RoutedEventHandler(this.Breakfast_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Lunch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dinner_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dessert_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Appetizer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\AppetizerPage.xaml"
            this.searchBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RecipeName_MouseDown);
            
            #line default
            #line hidden
            
            #line 59 "..\..\AppetizerPage.xaml"
            this.searchBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeName_LostFocus);
            
            #line default
            #line hidden
            
            #line 59 "..\..\AppetizerPage.xaml"
            this.searchBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.searchBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\AppetizerPage.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ThePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 71 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AppetizerPage2_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 103 "..\..\AppetizerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buf_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.breadRecipe = ((System.Windows.Controls.Button)(target));
            
            #line 200 "..\..\AppetizerPage.xaml"
            this.breadRecipe.Click += new System.Windows.RoutedEventHandler(this.AppetizerPage1_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 14:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 251 "..\..\AppetizerPage.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 253 "..\..\AppetizerPage.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.Profile_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 255 "..\..\AppetizerPage.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

