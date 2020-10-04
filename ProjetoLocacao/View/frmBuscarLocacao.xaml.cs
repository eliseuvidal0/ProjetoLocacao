using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
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
    /// Interaction logic for frmBuscarLocacao.xaml
    /// </summary>
    public partial class frmBuscarLocacao : Window
    {
        public frmBuscarLocacao()
        {
            InitializeComponent();
        }

        Locacao locacao = new Locacao();

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
