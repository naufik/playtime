﻿#pragma checksum "..\..\NewTaskWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5F65E1E67C7E2526D17C0D82F5632B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace Personal_Project {
    
    
    /// <summary>
    /// NewTaskWindow
    /// </summary>
    public partial class NewTaskWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Personal_Project.NewTaskWindow Window;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taskname;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OKbutton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepick;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hourbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minutebox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton am;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\NewTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton pm;
        
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
            System.Uri resourceLocater = new System.Uri("/Personal Project;component/newtaskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewTaskWindow.xaml"
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
            this.Window = ((Personal_Project.NewTaskWindow)(target));
            return;
            case 2:
            
            #line 15 "..\..\NewTaskWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Header_Drag);
            
            #line default
            #line hidden
            return;
            case 3:
            this.taskname = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\NewTaskWindow.xaml"
            this.taskname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ebb);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OKbutton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\NewTaskWindow.xaml"
            this.OKbutton.Click += new System.Windows.RoutedEventHandler(this.createTask);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\NewTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datepick = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.hourbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\NewTaskWindow.xaml"
            this.hourbox.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.cm_pe));
            
            #line default
            #line hidden
            
            #line 21 "..\..\NewTaskWindow.xaml"
            this.hourbox.GotFocus += new System.Windows.RoutedEventHandler(this.tbf);
            
            #line default
            #line hidden
            
            #line 21 "..\..\NewTaskWindow.xaml"
            this.hourbox.LostFocus += new System.Windows.RoutedEventHandler(this.hourlostfocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\NewTaskWindow.xaml"
            this.hourbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ptx);
            
            #line default
            #line hidden
            return;
            case 8:
            this.minutebox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\NewTaskWindow.xaml"
            this.minutebox.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.cm_pe));
            
            #line default
            #line hidden
            
            #line 22 "..\..\NewTaskWindow.xaml"
            this.minutebox.GotFocus += new System.Windows.RoutedEventHandler(this.tbf);
            
            #line default
            #line hidden
            
            #line 22 "..\..\NewTaskWindow.xaml"
            this.minutebox.LostFocus += new System.Windows.RoutedEventHandler(this.minutelostfocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\NewTaskWindow.xaml"
            this.minutebox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ptx);
            
            #line default
            #line hidden
            return;
            case 9:
            this.am = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.pm = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
