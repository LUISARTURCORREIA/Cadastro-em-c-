using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cadastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
       
        public List<Cliente> Clientes { get; private set; }
        public Lista()
        {
            InitializeComponent();

            Clientes = new List<Cliente>();

            Clientes.Add(new Cliente
            {
                Nome = "Silvio Santos",
                ImageUrl = "https://static.sbt.com.br/media/playlist/20100419153609/20150209162622/tn/20190405173603.jpg",
                Cpf = "1242352352",
            });

            Clientes.Add(new Cliente
            {
                Nome = "Messi",
                ImageUrl = "https://www.abola.pt//img/fotos/abola2015/FOTOSAP/ESPANHA/2018/Messi20.jpg",
                Cpf = "94919791919",
            });

            Clientes.Add(new Cliente
            {
                Nome = "Cristiano Ronaldo",
                ImageUrl = "https://static-wp-tor15-prd.torcedores.com/wp-content/uploads/2019/10/cristiano-ronaldo-comemorando-gol-foto-twitter-juventus-507x338.jpg",
                Cpf = "61919198489",
            });

            Clientes.Add(new Cliente
            {
                Nome = "Yoda",
                ImageUrl = "https://static-wp-tor15-prd.torcedores.com/wp-content/uploads/2019/10/cristiano-ronaldo-comemorando-gol-foto-twitter-juventus-507x338.jpg",
                Cpf = "3216516515",
            });

            Clientes.Add(new Cliente
            {
                Nome = "Faker",
                ImageUrl = "https://liquipedia.net/commons/images/thumb/7/76/SKT_Faker_2018LCK.jpg/294px-SKT_Faker_2018LCK.jpg",
                Cpf = "216165461645",
            }) ;

            

            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cliente selectedItem = e.SelectedItem as Cliente;
            DisplayAlert("Selecionado", selectedItem.Nome + " " + selectedItem.Cpf, "Ok");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}