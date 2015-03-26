using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using Voting_System.Backend;
using Voting_System.DTO;
using MessageBox = System.Windows.MessageBox;

namespace Voting_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dh = new DataHandler();

            //Henter alle data fra databasen for partier.
            var items = dh.method();

            
           
        

            datagrid1.ItemsSource = items;  //ESSENTIAL PART. SET TO DATA SOURCE!







        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void datagrid1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e) //DETTE EVENT SKAL BRUGES TIL AT OPDATERE COUNT I DATABASEN!!!!
        {
            var rows = datagrid1.SelectedCells;  //REN TESTING FOR AT SE, OM JEG KUNNE FÅ HELE DEN VALGTE RÆKKE I DATAGRID
         
        }
        
    }
}


