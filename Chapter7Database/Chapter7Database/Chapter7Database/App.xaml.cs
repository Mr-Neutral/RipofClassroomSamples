using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Xamarin.Essentials;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Chapter7Database
{
    public partial class App : Application
    {
        public static SQLiteConnection Database;

        public App()
        {
            InitializeComponent();

            // 1. Setup connection to database
            // 1a. Determine the file name
            string fileName = Path.Combine(FileSystem.AppDataDirectory,
                                           "database.db");

            // 1b. Create the connection
            Database = new SQLiteConnection(fileName);

            // 2. Create tables
            Database.CreateTable<PersonModel>();

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
