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
using System.Windows.Shapes;

namespace Skoda.Windows
{
    /// <summary>
    /// Interaction logic for WinMainMenu.xaml
    /// </summary>
    public partial class WinMainMenu : Window
    {
        public WinMainMenu()
        {
            InitializeComponent();

            btnAvtorization.Click += delegate
            {
                WinAvtorization winAvtorization = new WinAvtorization();
                winAvtorization.Show();
                this.Close();
            };
        }
    }
}
