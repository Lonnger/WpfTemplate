using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp.ViewModels;
using WpfApp.Views;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Initialize the DI container
            DependencyContainer.Initialize();

            // Create and show the main window
            var mainWindow = new MainWindow(new MainViewModel());
            mainWindow.Show();

        }
    }

}
