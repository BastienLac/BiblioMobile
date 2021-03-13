﻿using System;
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
    public partial class VoirLivre : ContentPage
    {
        public VoirLivre()
        {
            InitializeComponent();
        }
        HttpClient ws;

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Livre> lesLivres = new List<Livre>();

            ws = new HttpClient();
            var reponse = await ws.GetAsync("http://127.0.0.1/Bibliotheque/APIGSB/livres/");
            var content = await reponse.Content.ReadAsStringAsync();
            lesLivres = JsonConvert.DeserializeObject<List<Livre>>(content);
            lvLivres.ItemsSource = lesLivres;
        }
    }
}