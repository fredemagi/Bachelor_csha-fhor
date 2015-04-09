using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using Voting_System.Backend;
using Voting_System.Database;
using Voting_System.DTO;
using DataGrid = System.Windows.Forms.DataGrid;
using MessageBox = System.Windows.MessageBox;

namespace Voting_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        
        public List<VSDTO> Data { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var dh = new DataHandler();




            this.DataContext = Data;
            //Henter alle data fra databasen for partier.
            Data = dh.GetParties();




            datagrid1.ItemsSource = Data;  //ESSENTIAL PART. SET TO DATA SOURCE!
        


              
        

          






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


