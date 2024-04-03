
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpeciaSoftwareInstaler.GUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public Action<Page> PageSelectionBorder_OnClick;
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void PackageInstallersBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageSelectionBorder_OnClick.Invoke(new PackageInstallersPage());
        }

        private void HardIntallationBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
           // PageSelectionBorder_OnClick.Invoke(new HardIntallersPage());
        }

        private void PrinterPackegInstaller_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}
