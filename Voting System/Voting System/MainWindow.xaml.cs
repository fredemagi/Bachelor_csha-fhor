using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Voting_System.Backend;
using Voting_System.DTO;
using Color = System.Windows.Media.Color;
using DataGrid = System.Windows.Forms.DataGrid;
using MessageBox = System.Windows.MessageBox;

namespace Voting_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DataHandler dh;
        private List<GUIDTO> list; 
        
        
        public MainWindow()
        {
            InitializeComponent();
//            dh = new DataHandler();
  //          list = new List<GUIDTO>();
           // datagrid1.ItemsSource = dh.GetPartyPeople();  //ESSENTIAL PART. SET TO DATA SOURCE!
    //        datagrid1.ColumnWidth = 500;
      //      datagrid1.FontSize = 15;
        //    datagrid1.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;


            Scanner s = new Scanner();
            s.Encode("C:/Users/SATLP850132/Desktop/election15.txt");
        }



        /// <summary>
        /// Prompts for a user's accept before a vote is passed to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     /**   private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (!list.Any())
            {
                MessageBox.Show("You need to select a candidate before you can vote.");
            }

            else
            {
                try
                {
                    //Retrieves the last candidate in the list. The rest aren't needed.
                    var candidate = list.Last();
                    var message = "Are you sure that you want to vote on " + candidate.Name + "?";
                    var title = "Confirm vote!";
                        
                    var result = MessageBox.Show(message, title, MessageBoxButton.YesNo);

                    if (MessageBoxResult.Yes.Equals(result))
                    {
                        //If name is a person
                        if (candidate.Name != "Socialdemokraterne" && candidate.Name != "Venstre" &&
                            candidate.Name != "Konservative")
                        {
                            dh.CastVote(candidate.Name, false);

                        }
                    
                            //If name is a party
                        else
                        {
                            dh.CastVote(candidate.Name, true);
                        }
                    }
                    
                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("Couldn't cast a vote. Try again.");
                }
                
            }
            
        }**/


        /// <summary>
        /// Adds a voting choice to a list. This list is to be used when a vote is passed to the database. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    /**    private void datagrid1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e) 
        {

            list.Add(datagrid1.SelectedItem as GUIDTO);

        }
        **/

        /// <summary>
        /// Retrieves all votes given from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    /**    private void votes_box_Checked(object sender, RoutedEventArgs e)
        {
           var sb =  dh.GetAllVotes();
           MessageBox.Show(sb.ToString());
        }
        **/
    }
}


