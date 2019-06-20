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

namespace ExamplesListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var users = new List<User>();
            for (int i = 0; i < 10; ++i)
            {
                users.Add(new User { ID = i, Name = "Name " + i.ToString(), Age = 20 + i });
            }

            myListView.ItemsSource = users;
        }
    }
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
