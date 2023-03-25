using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;
           
          
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet1.Employee_Portal' table. You can move, or remove it, as needed.
            this.employee_PortalTableAdapter1.Fill(this.inventory_ManagementDataSet1.Employee_Portal);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet.Employee_Portal' table. You can move, or remove it, as needed.
            //this.employee_PortalTableAdapter.Fill(this.inventory_ManagementDataSet.Employee_Portal);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlUserData sql = new SqlUserData();
                bool flag = sql.SetUserData(textBox1.Text, dateTimePicker1.Value.Date, Convert.ToInt32(textBox3.Text), textBox4.Text);
                if (flag == true)
                {
                    MessageBox.Show("Data Save successfully", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //this.employee_PortalTableAdapter.Fill(this.inventory_ManagementDataSet.Employee_Portal);
                }
                else
                {
                    MessageBox.Show("Error while saving the record", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetBaseException().Message + "\n" + exp.StackTrace, "Error");
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            button1.Enabled= false;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlUserData obj =new SqlUserData();
            bool flag = obj.Updatedata(textBox1.Text, dateTimePicker1.Value.Date, Convert.ToInt32(textBox3.Text), 
                textBox4.Text,Convert.ToInt32(textBox2.Text));
            if (flag == true)
            {
                MessageBox.Show("Data Update successfully", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //this.employee_PortalTableAdapter.Fill(this.inventory_ManagementDataSet.Employee_Portal);
            }
            else
            {
                MessageBox.Show("Error while updating the record", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlUserData obj = new SqlUserData();
            bool flag = obj.Deletedata( Convert.ToInt32(textBox2.Text));
            if (flag == true)
            {
                MessageBox.Show("Data delete successfully", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //this.employee_PortalTableAdapter.Fill(this.inventory_ManagementDataSet.Employee_Portal);
            }
            else
            {
                MessageBox.Show("Error while deleting the record", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            button2.Enabled = true;
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Butt()
        {
            int ii = ee.RowIndex;
            button1.Enabled = false;
            button2.Enabled=true;
            button3.Enabled=true;
            textBox2.Text = dataGridView1.Rows[ii].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[ii].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[ii].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[ii].Cells[3].Value.ToString();
            dateTimePicker.Value=
        }
    }
    
}


