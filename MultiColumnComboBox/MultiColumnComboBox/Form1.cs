using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColumnComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        #region Properties

        string text = "";

        bool dropDownOpened = false;

        #endregion

        #region Data Settting

        DataView GetData()
        {
            //Create dataTable
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("occupation");
            dt.Columns.Add("place");

            // Create a Data Set
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.Rows.Add(new string[] { "John", "Tina", "Doctor", "Italy" });
            dt.Rows.Add(new string[] { "Mary", "anu", "Teacher", "America" });
            dt.Rows.Add(new string[] { "asha", "roy", "Staff", "London" });
            dt.Rows.Add(new string[] { "George", "Gaskin", "Nurse", "germany" });
            dt.Rows.Add(new string[] { "sam", "jens", "Engineer", "Russia" });
            dt.Rows.Add(new string[] { "Ben", "Geo", "Developer", "India" });
            DataView view = new DataView(dt);
            return view;
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.multiColumnComboBox1.SelectedIndexChanged += multiColumnComboBox1_SelectedIndexChanged;
            this.multiColumnComboBox1.DropDown += multiColumnComboBox1_DropDown;
        }

        private void multiColumnComboBox1_DropDown(object sender, System.EventArgs e)
        {
            this.dropDownOpened = true;
        }

        private void multiColumnComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.dropDownOpened == true)
            {
                for (int i = 1; i <= this.multiColumnComboBox1.ListBox.Grid.ColCount; i++)
                {
                    text += this.multiColumnComboBox1.ListBox.Grid[this.multiColumnComboBox1.SelectedIndex + 1, i].Text + " ";
                }
                this.dropDownOpened = false;
                this.multiColumnComboBox1.Text = text;
            }
            text = "";
        }

        #endregion
    }
}
