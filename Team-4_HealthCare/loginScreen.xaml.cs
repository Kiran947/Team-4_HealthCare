using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Media;

namespace Team_4_HealthCare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
               
            
        }



        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            databaseConnection databaseconnection = new databaseConnection();
            if (databaseconnection.getVaildUser(txtUserName.Text, txtpasscode.Password))
            {
                HomeScreen homeScreen = new HomeScreen();
                this.Close();
                homeScreen.Show();
            }
            else
            {
                txtUserName.BorderBrush = txtUserName_Copy.BorderBrush;
                txtpasscode.BorderBrush = txtUserName_Copy.BorderBrush;
            }
        }
    }
}
