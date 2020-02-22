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
    public partial class TestingPage : ContentPage
    {
        public TestingPage()
        {
            InitializeComponent();
        }

        public void Text_Changed(object sender, TextChangedEventArgs args)
        {
            Entry entry = (Entry)sender;
            entry.Text = args.NewTextValue;
        }
    }
}