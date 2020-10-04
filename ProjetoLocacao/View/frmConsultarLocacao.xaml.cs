using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using ProjetoLocacao.Utility;
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
    /// Interaction logic for frmConsultarLocacao.xaml
    /// </summary>
    public partial class frmConsultarLocacao : Window
    {
        public frmConsultarLocacao()
        {
            InitializeComponent();

            foreach (Locacao l in LocacaoDAO.Listar())
            {
                dtaLocacao.Items.Add(new DataGridItems
                {
                    Id = l.id.ToString(),
                    Cliente = l.cliente.nome.ToString(),
                    Agente = l.agente.nome.ToString(),
                    Veiculo = l.veiculo.modelo,
                    Locacao = l.devolvido.ToString(),
                    Previsao = l.previsaoEntrega.ToString()
                });
            }

        }
    }
}
