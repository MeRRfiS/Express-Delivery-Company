#pragma checksum "..\..\WatchOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "144D630ED32CBBD8AA63072C32C9E7EE50B61122D074B2E4EC81141636B9F826"
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
    /// WatchOrder
    /// </summary>
    public partial class WatchOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridOrderMin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridOrder;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxID;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEdit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEdit;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridEdit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\WatchOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSave;
        
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
            System.Uri resourceLocater = new System.Uri("/Express Delivery;component/watchorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WatchOrder.xaml"
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
            
            #line 17 "..\..\WatchOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Return_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\WatchOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridOrderMin = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\WatchOrder.xaml"
            this.dataGridOrderMin.Loaded += new System.Windows.RoutedEventHandler(this.dataGridOrderMin_Loaded);
            
            #line default
            #line hidden
            
            #line 27 "..\..\WatchOrder.xaml"
            this.dataGridOrderMin.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.dataGridOrderMin_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGridOrder = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.textBoxID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 41 "..\..\WatchOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\WatchOrder.xaml"
            this.buttonEdit.Click += new System.Windows.RoutedEventHandler(this.Button_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.gridEdit = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.dataGridEdit = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\WatchOrder.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.Button_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

