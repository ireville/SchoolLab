using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Library;

namespace SchoolLab_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubjectsPage : ContentPage
    {
        public SubjectsPage()
        {
            InitializeComponent();
        }

        public async void Russian_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RussianPage());
        }

        public async void Literature_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LiteraturePage());
        }
    }
}