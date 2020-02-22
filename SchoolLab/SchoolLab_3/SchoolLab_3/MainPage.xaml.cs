using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Library;

namespace SchoolLab_3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<Library.MenuItem> MenuItems { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new StartPage());

            ToolbarItem homeicon = new ToolbarItem()
            {
                Icon = "Home.png",
                Text = "home"
            };

            homeicon.Clicked += (sender, e) =>
            {
                Detail = new NavigationPage(new StartPage());
            };
            ToolbarItems.Add(homeicon);


            InitializeComponent();

            MenuItems = new List<Library.MenuItem>()
            {
                new Library.MenuItem("Subjects.png", "Предметы"),
                new Library.MenuItem("Homework.png", "Домашнее задание"),
                new Library.MenuItem("Timetable.png", "Расписание уроков"),
                new Library.MenuItem("Options.png", "Настройки"),
                new Library.MenuItem("About.png", "О приложении")
            };

            BindingContext = this;
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            IsPresented = false;
            string name = ((Library.MenuItem)((ItemTappedEventArgs)e).Item).Name;

            Menu_Items_List.SelectedItem = null;
            switch (name)
            {
                case "Предметы":
                    Detail = new NavigationPage(new SubjectsPage());
                    break;
                case "Домашнее задание":
                    Detail = new NavigationPage(new HomeworkPage());
                    break;
                case "Расписание уроков":
                    Detail = new NavigationPage(new TimetablePage());
                    break;
                case "Настройки":
                    Detail = new NavigationPage(new OptionsPage());
                    break;
                case "О приложении":
                    Detail = new NavigationPage(new AboutPage());
                    break;
            }
        }

        public void Russian_Click(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new RussianPage());
        }

        public void Literature_Click(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new LiteraturePage());
        }
    }
}
