#pragma checksum "..\..\..\Pages\DataGridObjectKosmos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8F654030B58D4A9D5CB6FB5CA8B6CFC0B5FA0302033A9DF4DB597FDDFFF56D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KosmObj.Pages;
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


namespace KosmObj.Pages {
    
    
    /// <summary>
    /// DataGridObjectKosmos
    /// </summary>
    public partial class DataGridObjectKosmos : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Galaxy;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Object;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Kategory_object;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\DataGridObjectKosmos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstboxStore;
        
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
            System.Uri resourceLocater = new System.Uri("/KosmObj;component/pages/datagridobjectkosmos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DataGridObjectKosmos.xaml"
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
            this.Galaxy = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.Object = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Kategory_object = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.create = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Pages\DataGridObjectKosmos.xaml"
            this.create.Click += new System.Windows.RoutedEventHandler(this.create_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.edit = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Pages\DataGridObjectKosmos.xaml"
            this.edit.Click += new System.Windows.RoutedEventHandler(this.edit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Pages\DataGridObjectKosmos.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Pages\DataGridObjectKosmos.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lstboxStore = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

