﻿#pragma checksum "..\..\BreakfastPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58664E9982FF47EB9F875CF945A83CDC3DF5A93A6F3A5C0CD04C5475257D2664"
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
    /// BreakfastPage
    /// </summary>
    public partial class BreakfastPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Breakfast;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ThePanel;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel RecipePanel;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\BreakfastPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\BreakfastPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EazyRecipez;component/breakfastpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BreakfastPage.xaml"
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
            
            #line 18 "..\..\BreakfastPage.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Breakfast = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\BreakfastPage.xaml"
            this.Breakfast.Click += new System.Windows.RoutedEventHandler(this.Breakfast_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\BreakfastPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Lunch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\BreakfastPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dinner_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\BreakfastPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dessert_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\BreakfastPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Appetizer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\BreakfastPage.xaml"
            this.searchBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RecipeName_MouseDown);
            
            #line default
            #line hidden
            
            #line 59 "..\..\BreakfastPage.xaml"
            this.searchBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeName_LostFocus);
            
            #line default
            #line hidden
            
            #line 59 "..\..\BreakfastPage.xaml"
            this.searchBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.searchBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\BreakfastPage.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ThePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.RecipePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 12:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\BreakfastPage.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 189 "..\..\BreakfastPage.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.Profile_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\BreakfastPage.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

