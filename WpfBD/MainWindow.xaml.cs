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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            
            
            InitializeComponent();
            Person person = new Person();
            Company company = new Company();
            Person_Company person_Company = new Person_Company();
            person.comp = company;
            company.pc = person_Company;
            person_Company.comp = company;
            company.person = person;
            person.PersonDataGrid.ItemsSource = person.adapter.GetData();
            company.CompanyDataGrid.ItemsSource = company.adapter2.GetData();
            person_Company.PCDataGrid.ItemsSource = person_Company.adapter3.GetData();
            MainFrame.Content = person;
        }
    }
}
