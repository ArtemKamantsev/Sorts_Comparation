﻿#pragma checksum "..\..\WrongPair.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A07219108982F744AD0596EE7D1B8F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sorts;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
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


namespace Sorts {
    
    
    /// <summary>
    /// WrongPair
    /// </summary>
    public partial class WrongPair : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Back;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_elementCount;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_WrongPairAccuracy;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_WrongPair;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Clear;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost host;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WrongPair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart;
        
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
            System.Uri resourceLocater = new System.Uri("/Sorts;component/wrongpair.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WrongPair.xaml"
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
            
            #line 11 "..\..\WrongPair.xaml"
            ((Sorts.WrongPair)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Back = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\WrongPair.xaml"
            this.button_Back.Click += new System.Windows.RoutedEventHandler(this.button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_elementCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_WrongPairAccuracy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Button_WrongPair = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\WrongPair.xaml"
            this.Button_WrongPair.Click += new System.Windows.RoutedEventHandler(this.Button_WrongPair_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_Clear = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\WrongPair.xaml"
            this.Button_Clear.Click += new System.Windows.RoutedEventHandler(this.Button_Clear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.host = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 8:
            this.chart = ((System.Windows.Forms.DataVisualization.Charting.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

