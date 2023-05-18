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
using Task6._1.Model;

namespace Task6._1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private ModelContext? _db = null;
        private User _user = new User();
        public RegistrationPage()
        {
            InitializeComponent();

            _db = new ModelContext();
        }


    }
}
