using ProjetoLocacao.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmConsultarCliente.xaml
    /// </summary>
    public partial class frmConsultarCliente : Window
    {
        public frmConsultarCliente()
        {
            InitializeComponent();

            dtaCliente.ItemsSource = ClienteDAO.Listar();
        }
    }
}
