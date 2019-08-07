﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWpf.Views
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            passe(tbxLogin.Text, tbxSenha.Text);
        }

        public event EventHandler loginCorrect;
            

        public void passe (string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                loginCorrect(null, new EventArgs());
            }
            else
                MessageBox.Show("Login ou Senha Incorreto");
        }
    }
}
