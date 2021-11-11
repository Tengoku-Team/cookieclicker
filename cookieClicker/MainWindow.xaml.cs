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

namespace cookieClicker {
    public partial class MainWindow : Window {

        variables gameData = new variables(100); // calling contructor

        public MainWindow() {
            InitializeComponent();

            cookiesLabel.Content = gameData.getCookies(); // set value of cookies to label
        }

        private void cookie_MouseDown(object sender, MouseButtonEventArgs e) {
            gameData.setCookies(gameData.getCookies() + 1); // increment value of cookies
            cookiesLabel.Content = gameData.getCookies(); // updating label
        }
    }
}
