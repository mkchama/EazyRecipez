﻿#pragma checksum "..\..\AppetizerRecipe2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "424AF11C68415AACC6F49E63C327FCF0BC09F3F88D7A5C0BA654B3D1ADE8A017"
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
    /// AppetizerRecipe2
    /// </summary>
    public partial class AppetizerRecipe2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer sv1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton cb;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel heartPanel;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image emp_heart;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock subHeaderText;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox commentsField;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\AppetizerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\AppetizerRecipe2.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EazyRecipez;component/appetizerrecipe2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppetizerRecipe2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 14 "..\..\AppetizerRecipe2.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BackToAppetizerPage);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sv1 = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 31 "..\..\AppetizerRecipe2.xaml"
            this.sv1.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cb = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 40 "..\..\AppetizerRecipe2.xaml"
            this.cb.Checked += new System.Windows.RoutedEventHandler(this.HandleChecked);
            
            #line default
            #line hidden
            
            #line 40 "..\..\AppetizerRecipe2.xaml"
            this.cb.Unchecked += new System.Windows.RoutedEventHandler(this.HandleUnchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.heartPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.emp_heart = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            
            #line 66 "..\..\AppetizerRecipe2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.svPageLeft);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 69 "..\..\AppetizerRecipe2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.svPageRight);
            
            #line default
            #line hidden
            return;
            case 8:
            this.subHeaderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.commentsField = ((System.Windows.Controls.TextBox)(target));
            
            #line 134 "..\..\AppetizerRecipe2.xaml"
            this.commentsField.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.comment_MouseDown);
            
            #line default
            #line hidden
            
            #line 134 "..\..\AppetizerRecipe2.xaml"
            this.commentsField.LostFocus += new System.Windows.RoutedEventHandler(this.comment_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\AppetizerRecipe2.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\AppetizerRecipe2.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.Profile_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\AppetizerRecipe2.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

