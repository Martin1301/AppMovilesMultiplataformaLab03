using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoLayout2022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Primera página que se mostrará
            MainPage = new StackLayoutDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
