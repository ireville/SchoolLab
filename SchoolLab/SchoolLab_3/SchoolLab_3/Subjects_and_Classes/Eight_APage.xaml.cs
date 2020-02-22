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
    public partial class Eight_APage : ContentPage
    {
        public Eight_APage()
        {
            InitializeComponent();
        }

        public void Add_Student_Clicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.Eight_AR_Repo.AddNewStudent();

            statusMessage.Text = App.Eight_AR_Repo.StatusMessage;
        }

        public void Get_All_StudentsClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<Eight_A_Student> eight_A_students = App.Eight_AR_Repo.GetItems();
            studentsTable.ItemsSource = eight_A_students;
        }
    }
}