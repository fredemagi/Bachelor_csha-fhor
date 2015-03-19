using System.Windows;
using Voting_System.Backend;
using Voting_System.DTO;

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
            var party = new PartyDTO {name = "TEEEESTING"};

             

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
