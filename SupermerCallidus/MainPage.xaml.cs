using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SupermerCallidus
{
    public partial class MainPage : ContentPage
    {
        List<string> Produtos = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String prod = etComando.Text;
            Button button = (Button)sender;
            if (button.Text == "Adicionar Produto")
            {
                Produtos.Add(prod);
            }
            else if (button.Text == "Remover Produto")
            {
                Produtos.Remove(prod);
            }
            
            else if (button.Text == "Ver Lista")
            {
                await Navigation.PushAsync(new Lista_Prods(Produtos));
            }

        }

        public List<string> GetProdutos()
        {
            return Produtos;
        }
       
    }
}
