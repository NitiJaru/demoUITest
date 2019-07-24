using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoUITest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebviewPage : ContentPage
    {
        public WebviewPage()
        {
            InitializeComponent();
        }
    }
}