using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolLab_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RussianPage : ContentPage
    {
        public RussianPage()
        {
            InitializeComponent();
        }

        public async void Eight_A_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eight_APage());
        }

        public async void Eight_B_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eight_BPage());
        }

        public async void Testing_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestingPage());
        }
    }
}