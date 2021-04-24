using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BiblioMobile.ClassesMetier;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BiblioMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCreerLivre : ContentPage
    {
        public PageCreerLivre()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<GenreLivre> lesGenres = new List<GenreLivre>();
            List<ThemeLivre> lesThemes = new List<ThemeLivre>();
        }
        private void btnAjouter_Clicked(object sender, EventArgs e)
        {

        }
    }
}