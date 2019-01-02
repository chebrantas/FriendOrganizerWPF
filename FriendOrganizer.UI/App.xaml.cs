using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            
            //geriau su Autofac profesionaliau
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
            //paleidimui MainWindowFormos be Autofac. Autofac automatizuoja kad paleidziant automatiskai supranta
            //kur kam koki methoda pasiimti kaip aprasyta pvz 1.MainViewMode 2.FriendDataService ir tt
            //var mainWindow = new MainWindow(
            //    new MainViewModel(
            //        new FriendDataService()));
            //mainWindow.Show();
        }
    }
}
