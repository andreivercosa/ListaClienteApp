using System;
namespace ListaClienteApp.Model
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }

        public string enderecoCompleto {
            get
            {
                return  logradouro + ". " + localidade + " - " + uf + " CEP: " + cep;
            }
        }


        public Pessoa()
        {
        }
    }
}
