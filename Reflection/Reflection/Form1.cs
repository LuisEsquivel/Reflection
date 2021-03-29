using Reflection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string result = "";

        private void Generate_Click(object sender, EventArgs e)
        {
            int sqlOption = RdbSelect.Checked ? 0 :

          RdbUpdate.Checked ? 1 : RdbDelete.Checked ? 2 : 3;
            if (RdbEmployee.Checked)
                 result= new GenericEntity<Employee>(sqlOption).GetQuery();
         else if (RdbPosition.Checked)
                result = new GenericEntity<Position>(sqlOption).GetQuery();
            else
                result = new GenericEntity<Asset>(sqlOption).GetQuery();

            TxtSqlScript.Text = result;
        }
    }
}
