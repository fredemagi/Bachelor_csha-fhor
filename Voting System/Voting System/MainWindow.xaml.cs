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
            var party = new PartyDTO {Navn = "Hanne Lotte", Test = false};
            var party3 = new PartyDTO {Navn = "Lars Lonely Jensen", Test = true};
           
         
            List<PartyDTO> list = new List<PartyDTO>();

            list.Add(party);
            list.Add(party3);

            datagrid1.ItemsSource = list;   //ESSENTIAL PART. SET TO DATA SOURCE!


            /*  
            var adap = new SqlDataAdapter();
            //adap.SelectCommand = ;
            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);
            var bs = new BindingSource();
            bs.DataSource = dataTable;
            datagrid1.ItemsSource = bs;
            adap.Update(dataTable);*/






        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void datagrid1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var rows = datagrid1.SelectedCells;
         
        }
        
    }
}


