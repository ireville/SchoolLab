using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolLab_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eight_BPage : ContentPage
    {
        public Eight_BPage()
        {
            InitializeComponent();
            BindingContext = new PickerMVVMViewModel();
        }

        public void ChangeProperties(object sender, EventArgs args)
        {
            Picker myPicker = (Picker)sender;
            string name = myPicker.Id.ToString();
            var MVVM = (PickerMVVMViewModel)BindingContext;

            MVVM.GetAndChangeNowPicker(myPicker);

            //pickerName = myPicker.SetValue()
        }
    }
}