using System;
using Xamarin.Forms;
using XamarinApp9Estilo.Pages;

namespace XamarinApp9Estilo
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToHome(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToImplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImplicitStylePage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToExplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ExplicitStylePage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToGlobalStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GlobalStylePage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToInheritStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new InheritStylePage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToDynamicStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DynamicStylePage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }
    }
}
