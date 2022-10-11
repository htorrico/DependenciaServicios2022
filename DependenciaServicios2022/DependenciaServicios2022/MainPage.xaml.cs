using DependenciaServicios2022.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependenciaServicios2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRead_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(txtMessage.Text);
        }
    }
}
