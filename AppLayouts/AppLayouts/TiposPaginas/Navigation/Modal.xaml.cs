﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLayouts.TiposPaginas.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public Modal()
        {            
            InitializeComponent();
        }
        private void CloseModal (object sender, EventArgs agr)
        {
            //Navigation.PopToRootAsync(); usar este comando caso vc queira voltar para a primeira página da pilha
            Navigation.PopModalAsync();
        }
    }
}