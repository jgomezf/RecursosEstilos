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
    public partial class EjemploView : ContentPage
    {
        public EjemploView()
        {
            InitializeComponent();
            //Inspeccionar el diccionario de recursos
            if (Resources.ContainsKey("MiColor"))
            {
                var myColor = (Color)Resources["MiColor"];
            }
            Resources.Add("pi", 3.1416);

            this.texto.Text = Resources["pi"].ToString();
        }
    }
}