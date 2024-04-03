using DomainInstaller.BaseInterface.Repository;
using SpeciaSoftwareInstaler.GUI.Pages;
using SpeciaSoftwareInstaller.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpeciaSoftwareInstaler.GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        MainMenuPage mainMenuPage;
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public MainWindow()
        {
            InitializeComponent();
            mainMenuPage = new MainMenuPage();
            mainMenuPage.PageSelectionBorder_OnClick += FramePageSwitcher;
            MainFrame.Content = mainMenuPage;
            var test = StaticPath.ProjectDir;
           
        }
        private void FramePageSwitcher(Page page)
        {
            MainFrame.Content = page;
        }



    }
}
