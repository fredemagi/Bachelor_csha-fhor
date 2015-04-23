using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Voting_Screen : Form
    {

        private List<Person> list;
        public Voting_Screen()
        {
            Person p = new Person() { _age = 32, _name = "HELLE!!!!!!" };
            list = new List<Person>();
            list.Add(p);
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = list;    // SKAL SÆTTES TIL VÆLGERLISTEN FOR AT VISE DATA I DATAGRIDVIEW!!!!!


            
        }

    }
}
