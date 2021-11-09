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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Updlistview()

        }
        void Updlistview()
        {
            Main1 main = new Main1();
            lvViewGroup.ItemsSource = main.ReadGroup();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Group  group = new Group()
            {
                NameGroup = tbNamberGroup.Text,
                NumberGroup = tbNamberGroup.Text,
                CuratorGroup = tbCurator.Text
            };
            Main1 main = new Main1();
            main.AddGroup(group);
            Updlistview();
        }
        }
    }

