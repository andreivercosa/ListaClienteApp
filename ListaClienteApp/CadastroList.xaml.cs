using System;
using System.Collections.Generic;
using ListaClienteApp.Model;

using Xamarin.Forms;

namespace ListaClienteApp
{
    public partial class CadastroList : ContentPage
    {
        public CadastroList(List<Pessoa> Pessoalist)
        {
            InitializeComponent();
            listView_lista.ItemsSource = Pessoalist;
        }
    }
}
