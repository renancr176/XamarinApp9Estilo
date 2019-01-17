using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp9Estilo.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicStylePage : ContentPage
	{
		public DynamicStylePage ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Random rand = new Random();
            var cores = this.Resources.Keys.Where(c => c != "LblColor").ToList();
            var indiceCorAleatorio = rand.Next(0, cores.Count);
            var cor = cores[indiceCorAleatorio];
            this.Resources["LblColor"] = this.Resources[cor];
        }
    }
}