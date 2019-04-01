using SQLite;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Chapter7
{
    public partial class App : Application
    {
        public static SQLiteConnection Database;

        public App()
        {
            InitializeComponent();

            string filePath = System.IO.Path.Combine(FileSystem.AppDataDirectory,
                                                     "chapter7.demo");

            Database = new SQLiteConnection(filePath);

            Database.CreateTable<ItemModel>();

            MainPage = new NavigationPage(new MainPage());
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
