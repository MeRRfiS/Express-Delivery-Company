﻿#pragma checksum "..\..\CheckOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2371A72F8EAE7AB37C5A7590A99489F3D0B862B713A74379B6467F08F918F7C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Express_Delivery;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Express_Delivery {
    
    
    /// <summary>
    /// CheckOrder
    /// </summary>
    public partial class CheckOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockFullName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockFullNameReceiver;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPhone;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockCity;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockAdress;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPrice;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\CheckOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Express Delivery;component/checkorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CheckOrder.xaml"
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
            
            #line 17 "..\..\CheckOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Return_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\CheckOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\CheckOrder.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.StackPanel_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBlockFullName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.textBlockFullNameReceiver = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textBlockPhone = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.textBlockCity = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.textBlockAdress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBlockPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.dataGridBox = ((System.Windows.Controls.DataGrid)(target));
            
            #line 62 "..\..\CheckOrder.xaml"
            this.dataGridBox.Loaded += new System.Windows.RoutedEventHandler(this.dataGridBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 74 "..\..\CheckOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 75 "..\..\CheckOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Accses_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
