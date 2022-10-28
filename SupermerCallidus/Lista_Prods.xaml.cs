using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SupermerCallidus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista_Prods : ContentPage
    {
        MainPage mainPage = new MainPage();
        public Lista_Prods(List<string> prods)
        {
            InitializeComponent();
            lista.ItemsSource = prods;
        }

    }
}