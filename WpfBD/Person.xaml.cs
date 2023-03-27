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
using WpfBD.WPFDBDataSetTableAdapters;

namespace WpfBD
{
    /// <summary>
    /// Логика взаимодействия для Person.xaml
    /// </summary>
    public partial class Person : Page
    {
        public PersonTableAdapter adapter = new PersonTableAdapter();
        public Company comp;
        public Person()
        {
            InitializeComponent();
        }

        private void GoTab2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(comp);
        }
    }
}
