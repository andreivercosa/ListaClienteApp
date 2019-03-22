using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaClienteApp.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace ListaClienteApp
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> listaPessoa = new List<Pessoa>();




        void Adicionar(object sender, System.EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = nome.Text;
            pessoa.logradouro = endereco.Text;
            pessoa.localidade = cidade.Text;
            pessoa.uf = uf.Text;

            listaPessoa.Add(pessoa);

            nome.Text = "";
            txtCEP.Text = "";
            endereco.Text = "";
            cidade.Text = "";
            uf.Text = "";

        }
        async void Handle_Completed(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            string cep = txtCEP.Text;
            var json = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
            var dados = JsonConvert.DeserializeObject<Pessoa>(json);

            endereco.Text = dados.logradouro;
            cidade.Text = dados.localidade;
            uf.Text = dados.uf;
            
        }

        void Listar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CadastroList(listaPessoa));
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }

}