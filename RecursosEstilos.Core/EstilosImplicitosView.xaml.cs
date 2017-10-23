using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecursosEstilos.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstilosImplicitosView : ContentPage
    {
        public EstilosImplicitosView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            panel.Children.Add(new Button() { Text=$"Botón {panel.Children.Count + 1}" });
        }
    }
}