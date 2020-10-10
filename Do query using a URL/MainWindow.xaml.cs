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

namespace Do_query_using_a_URL
{
    /// <summary>
    /// Method to send in GET strings to a PHP page. DO NOT USE THE LINK LISTED
    /// example of link: http://test.com/Files/Query.php?Name=THIS_IS_FROM_CODE
    /// For some reason the events do not work unless you are using a graphical object of WebBrowser defined via xaml in the window
    /// </summary>
    public partial class MainWindow : Window
    {
        WebBrowser browser = new WebBrowser();
        public MainWindow()
        {
            InitializeComponent();
            browser.Navigate(""); //(l'indirizzo è una pagina PHP che prende in GET delle stringhe e aggiorna il DB)
        }
    }
}
