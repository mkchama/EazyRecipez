#pragma checksum "..\..\DinnerRecipe2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DB01D47AF6987433DFADE434C07B5C1833CFB94B4331719CBF2B81021E4DBF9"
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
    /// DinnerRecipe2
    /// </summary>
    public partial class DinnerRecipe2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\DinnerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer sv1;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\DinnerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock subHeaderText;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\DinnerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox commentsField;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\DinnerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\DinnerRecipe2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\DinnerRecipe2.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EazyRecipez;component/dinnerrecipe2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DinnerRecipe2.xaml"
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
            
            #line 13 "..\..\DinnerRecipe2.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BackToDinnerPage);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sv1 = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 29 "..\..\DinnerRecipe2.xaml"
            this.sv1.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\DinnerRecipe2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.svPageLeft);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\DinnerRecipe2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.svPageRight);
            
            #line default
            #line hidden
            return;
            case 5:
            this.subHeaderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.commentsField = ((System.Windows.Controls.TextBox)(target));
            
            #line 103 "..\..\DinnerRecipe2.xaml"
            this.commentsField.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.comment_MouseDown);
            
            #line default
            #line hidden
            
            #line 103 "..\..\DinnerRecipe2.xaml"
            this.commentsField.LostFocus += new System.Windows.RoutedEventHandler(this.comment_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\DinnerRecipe2.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\DinnerRecipe2.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.Profile_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\DinnerRecipe2.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

