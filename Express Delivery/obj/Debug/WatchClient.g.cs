﻿#pragma checksum "..\..\WatchClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "094E72B44DB61FEECA109977176AEFDFA194EF1A79327C0D11F7D010BC5BEB58"
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
    /// WatchClient
    /// </summary>
    public partial class WatchClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridClient;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSurname;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPasport;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxAdress;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPhone;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSave;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\WatchClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/Express Delivery;component/watchclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WatchClient.xaml"
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
            
            #line 17 "..\..\WatchClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Return_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\WatchClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridClient = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\WatchClient.xaml"
            this.dataGridClient.Loaded += new System.Windows.RoutedEventHandler(this.dataGridClient_Loaded);
            
            #line default
            #line hidden
            
            #line 27 "..\..\WatchClient.xaml"
            this.dataGridClient.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.dataGridClient_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textBoxPasport = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textBoxAdress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textBoxPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 42 "..\..\WatchClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\WatchClient.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\WatchClient.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.button_Save_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\WatchClient.xaml"
            this.buttonEdit.Click += new System.Windows.RoutedEventHandler(this.Button_Edit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

