using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace Voting_System
{
    public partial class Voting_Screen : Form
    {
        private Login_scanner_window mainWindow;
        public List<Login_scanner_window.StringValue> list { get; set; }
        private string cell;
        public event EventHandler ClosingWindow;


        /// <summary>
        /// Initializing components, and sets properties for the datagridview. 
        /// </summary>
        public Voting_Screen()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 22, FontStyle.Bold);
            dataGridView1.GridColor = Color.Maroon;
            dataGridView1.RowTemplate.MinimumHeight = 50;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(Target);

        }


        /// <summary>
        /// Responsible for unsetting selection for row 1 at startup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Target(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }


        /// <summary>
        /// Setting a field to the clicked cell value, representing the user voting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            InvokeVoteCasting(() =>
            {
                cell = dataGridView1.SelectedCells[0].Value as string;
                voting_button.Enabled = true;
                voting_button.BackColor = Color.LimeGreen;
            });
        }


        /// <summary>
        /// Setting datasource and other properties for the datagridview.
        /// </summary>
        public void Sourcelist()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[0].MinimumWidth = dataGridView1.Width;
        }


        /// <summary>
        /// Gets the user voting, prompts the user for acknowledgement, and upon yes prints out the user voting, in this case, to the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voting_button_Click(object sender, EventArgs e)
        {
            InvokeVoteCasting(() =>
            {
                    try
                    {
                        var message = "Er du sikker på, at du vil stemme på " + cell + "?";
                        var title = "Bekræft dit valg!";

                        var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                        if (DialogResult.Yes.Equals(result))
                        {
                            this.Dispose();
                            Printer printer = new Printer();
                            printer.SetOutput(cell);
                            printer.Print();
                            mainWindow = new Login_scanner_window();
                            mainWindow.ShowDialog();

                        }

                    }
                    catch (NullReferenceException)
                    {

                        MessageBox.Show("Kunne ikke bekræfte dit valg. Prøv igen.", "Der opstod en fejl!");
                    }
            });
        }


        /// <summary>
        /// Helper method for executing embedded method using a lampba expression. This is to ensure that no errors occur. 
        /// </summary>
        /// <param name="action">Embedded method to be called when this method is called.</param>
        private void InvokeVoteCasting(Action action)
        {
            BeginInvoke(action);
        }
    }
}
