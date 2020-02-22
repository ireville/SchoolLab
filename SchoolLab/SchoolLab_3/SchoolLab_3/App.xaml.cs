using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Library;

namespace SchoolLab_3
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("Eight_A.db3");

        public static Eight_AR_Repository Eight_AR_Repo { get; private set; }

        public App()
        {
            InitializeComponent();

            Eight_AR_Repo = new Eight_AR_Repository(dbPath);

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
