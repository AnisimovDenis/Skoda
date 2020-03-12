using Skoda.Windows;
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

namespace Skoda
{
    /// <summary>
    /// Interaction logic for WinAvtorization.xaml
    /// </summary>
    public partial class WinAvtorization : Window
    {
        public WinAvtorization()
        {
            InitializeComponent();

            tbDrager.MouseDown += delegate { this.DragMove(); };

            btnBack.Click += delegate
            {
                WinMainMenu winMainMenu = new WinMainMenu();
                winMainMenu.Show();
                this.Close();
            };

            btnExit.Click += delegate { this.Close(); };
        }
    }
}
