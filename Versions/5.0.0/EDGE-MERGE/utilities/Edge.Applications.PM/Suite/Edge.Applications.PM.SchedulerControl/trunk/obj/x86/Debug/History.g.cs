﻿#pragma checksum "..\..\..\History.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F63B4E84491D397D08261F15F0F35C9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AC.AvalonControlsLibrary.Controls;
using Edge.Applications.PM.SchedulerControl.Objects;
using Edge.Core.Services;
using Ricciolo.Controls;
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


namespace Edge.Applications.PM.SchedulerControl {
    
    
    /// <summary>
    /// frmHistoryView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class frmHistoryView : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ricciolo.Controls.TreeListView _Tree;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView _outcomes;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _outComeCheckAll;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView _state;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _stateCheckAll;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView _Accounts;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _AccountsCheckAll;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView _Services;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _servicesCheckAll;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _isEnableCheckBox;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AC.AvalonControlsLibrary.Controls.DateTimePicker _from;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AC.AvalonControlsLibrary.Controls.DateTimePicker _to;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\History.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _loadHistory;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Edge.Applications.PM.SchedulerControl;component/history.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\History.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._Tree = ((Ricciolo.Controls.TreeListView)(target));
            return;
            case 3:
            this._outcomes = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this._outComeCheckAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 109 "..\..\..\History.xaml"
            this._outComeCheckAll.Click += new System.Windows.RoutedEventHandler(this._outComeCheckAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._state = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this._stateCheckAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 133 "..\..\..\History.xaml"
            this._stateCheckAll.Click += new System.Windows.RoutedEventHandler(this._stateCheckAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._Accounts = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this._AccountsCheckAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 157 "..\..\..\History.xaml"
            this._AccountsCheckAll.Click += new System.Windows.RoutedEventHandler(this._AccountsCheckAll_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this._Services = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this._servicesCheckAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 181 "..\..\..\History.xaml"
            this._servicesCheckAll.Click += new System.Windows.RoutedEventHandler(this._servicesCheckAll_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this._isEnableCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this._from = ((AC.AvalonControlsLibrary.Controls.DateTimePicker)(target));
            return;
            case 13:
            this._to = ((AC.AvalonControlsLibrary.Controls.DateTimePicker)(target));
            return;
            case 14:
            this._loadHistory = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\History.xaml"
            this._loadHistory.Click += new System.Windows.RoutedEventHandler(this._loadHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 29 "..\..\..\History.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._btnLog_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

