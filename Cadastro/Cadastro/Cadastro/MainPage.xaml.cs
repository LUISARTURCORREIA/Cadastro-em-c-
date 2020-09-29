using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cadastro
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        DateTime dataNascimentoMinima = DateTime.Now.AddYears(-18);

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string confirmacaoSenha;
        public string ConfirmacaoSenha
        {
            get { return confirmacaoSenha; }
            set { confirmacaoSenha = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            dtNascimento.MinimumDate = new DateTime(1900, 1, 1);
            dtNascimento.Date = dataNascimentoMinima;
        }

        private void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            if(DadosValidos())
            {
                CadastrarCliente();
            }
        }

        private void CadastrarCliente()
        {
            Nome = txtNome.Text;
            CPF = txtCPF.Text;
            DataNascimento = dtNascimento.Date;
            Email = txtEmail.Text;
            Senha = txtSenha.Text;
        }

        private bool DadosValidos()
        {
            if(String.IsNullOrEmpty(txtNome.Text))
            {
                DisplayAlert("Atenção", "Você deve informar um nome", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(txtCPF.Text))
            {
                DisplayAlert("Atenção", "Você deve informar um CPF", "Ok");
                return false;
            }

            if(dtNascimento.Date > dataNascimentoMinima)
            {
                DisplayAlert("Atenção", "Idade mínima é 18 anos", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                DisplayAlert("Atenção", "Você deve informar um email", "Ok");
                return false;
            }

            if(!txtEmail.Text.Contains("@"))
            {
                DisplayAlert("Atenção", "Informe um email válido", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                DisplayAlert("Atenção", "Você deve informar uma senha", "Ok");
                return false;
            }

            if (txtSenha.Text.Length < 8)
            {
                DisplayAlert("Atenção", "Senha deve ter 8 caracteres", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(txtConfirmaSenha.Text))
            {
                DisplayAlert("Atenção", "Você deve confirmar a senha", "Ok");
                return false;
            }

            if(txtSenha.Text != txtConfirmaSenha.Text)
            {
                DisplayAlert("Atenção", "A senha e a confirmação devem ser iguais", "Ok");
                return false;
            }

            return true;
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            dtNascimento.Date = dataNascimentoMinima;
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";

            Nome = "";
            CPF = "";
            DataNascimento = dataNascimentoMinima;
            Email = "";
            Senha = "";
            ConfirmacaoSenha = "";
        }

        private void BtnLista_Clicked(object sender, EventArgs e)
        {
            Lista page = new Lista();
            
            Navigation.PushModalAsync(page);
        }
    }
}
