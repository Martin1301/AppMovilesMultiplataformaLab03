using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoLayout2022
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            StackLayout stack = new StackLayout();
            Button button = new Button();
            button.Text = "Ejemplo";

            Label label = new Label();
            label.Text = "Ejeplo";

            stack.Children.Add(button);
            stack.Children.Add(label);

            this.Content = stack;

        }
    }
}