﻿#pragma checksum "..\..\..\..\View\frmCadastrarLocacao.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6F5158C69810A344B1661016FDECB7E04476F0F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetoLocacao.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProjetoLocacao.View {
    
    
    /// <summary>
    /// frmCadastrarLocacao
    /// </summary>
    public partial class frmCadastrarLocacao : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboClientes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboVeiculos;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboFuncionarios;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboFormaPagamento;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtDataEntrega;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\frmCadastrarLocacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salvar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjetoLocacao;component/view/frmcadastrarlocacao.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\frmCadastrarLocacao.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\View\frmCadastrarLocacao.xaml"
            ((ProjetoLocacao.View.frmCadastrarLocacao)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboClientes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cboVeiculos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cboFuncionarios = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cboFormaPagamento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.txtDataEntrega = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.Salvar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\frmCadastrarLocacao.xaml"
            this.Salvar.Click += new System.Windows.RoutedEventHandler(this.Salvar_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

