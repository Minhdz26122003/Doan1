using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace DoAn1
{
    public partial class BieudoDT : Form
    {
       
        private int chisocbb = 0;
        Bieudo bd = new Bieudo();
        public BieudoDT()
        {
            InitializeComponent();
            
        }
      
        private string GetData(string time)//from
        {   
            string message = "";
            try
            {
                chrMain.Titles.Clear();
                DataTable dt = bd.GetBillForChart(chisocbb, dtmonth.Value, dtpyear.Value);
                if (dt == null)
                {
                    MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                chrMain.DataSource = dt;
                chrMain.Series["cot"].XValueMember =time;
                chrMain.Series["cot"].YValueMembers = "Tongtien";
                chrMain.Titles.Add("Biểu Đồ Thống Kê");
            }
            catch (Exception ex)
            {
                message = ex.Message;
                
            }       
            return message;
        }
        private void SaleChatr_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string message = GetData(" ");
                if (message.Length > 0)
                {
                    MessageBox.Show(message, "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
      
            return;
        }
    

        private void dtmonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string message = GetData(" ");
                if (message.Length > 0)
                {
                    MessageBox.Show(message, "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                chisocbb = cbbtime.SelectedIndex;
                dtmonth.Enabled = true;
                dtpyear.Enabled = true;

                lblMain.Text = cbbtime.Text + " " + DateTime.Now.ToString("MM/yyyy");
                if (chisocbb == 1)
                {
                    lblMain.Text = cbbtime.Text + " " + DateTime.Now.ToString("yyyy");
                    dtmonth.Enabled = false;
                    dtpyear.Enabled = true;
                }

                if (chisocbb == 2)
                {
                    lblMain.Text = cbbtime.Text;
                    dtmonth.Enabled = false;
                    dtpyear.Enabled = false;
                }

                string message = GetData(" ");
                if (message.Length > 0)
                {
                    MessageBox.Show(message, "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto TheEnd;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                goto TheEnd;
            }

        TheEnd:
            return;
        }
    
    }
}
