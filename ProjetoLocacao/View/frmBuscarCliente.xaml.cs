﻿using ProjetoLocacao.DAL;
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
    /// Interaction logic for frmBuscarCliente.xaml
    /// </summary>
    public partial class frmBuscarCliente : Window
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
            txtCpf.Focus();
        }

        Cliente cliente = new Cliente();

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCpf.Text))
            {
                cliente = ClienteDAO.BuscarCpf(txtCpf.Text);
                if (cliente != null)
                {
                    txtNome.Text = cliente.nome;
                    txtCpf.Text = cliente.cpf;
                    txtEmail.Text = cliente.email;
                    txtTelefone.Text = cliente.telefone;
                    txtCnh.Text = cliente.cnh;

                    txtNome.IsEnabled = true;
                    txtEmail.IsEnabled = true;
                    txtTelefone.IsEnabled = true;
                    txtCnh.IsEnabled = true;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente não existente!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo CPF!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                cliente.nome = txtNome.Text;
                cliente.cpf = txtCpf.Text;
                cliente.email = txtEmail.Text;
                cliente.telefone = txtTelefone.Text;
                cliente.cnh = txtCnh.Text;
                ClienteDAO.Alterar(cliente);
                MessageBox.Show("Cliente alterado com sucesso!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não foi alterado!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                ClienteDAO.Remover(cliente);
                MessageBox.Show("Cliente removido com sucesso!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Cliente não foi removido!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}