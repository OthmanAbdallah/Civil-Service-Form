using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Project
{
    public partial class Form3 : Form
    {
        public String Currentuser;
        SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=Users.db;Version=3");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet dt = new DataSet();
        DataTable ds;
        SQLiteDataReader dr;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myConnection.Open();

            cmd.Connection = myConnection;
            cmd.CommandText = "SELECT * from Users WHERE National_Number=@NAT_NUM";
            cmd.Parameters.AddWithValue("NAT_NUM", Currentuser);
            dr = cmd.ExecuteReader();

            TxtBox_FName.Text = dr["First_Name"].ToString();
            TxtBox_MName.Text = dr["Middle_Name"].ToString();
            TxtBox_LName.Text = dr["Last_Name"].ToString();

            if(dr["Gender"].ToString() == "0")
            {
                RadBtn_Gender_Male.Checked = true;
            }
            else
            {
                RadBtn_Gender_Female.Checked = true;
            }

            Date_Birthday.Text = dr["Birth_Date"].ToString();
            Txt_Email.Text = dr["Email"].ToString();
            Txt_Phone.Text = dr["Phone_Num"].ToString();
            Txt_Address.Text = dr["Address"].ToString();

            if (dr["Marital_Status"].ToString() == "0")
            {
                RadBtn_Unmarried.Checked= true;
            }
            else
            {
                RadBtn_Married.Checked = true;
            }

            Nmc_NumberChildren.Text = dr["NumOfChildren"].ToString();
            Txt_Experience.Text = dr["Experience"].ToString();

            if (dr["Associate"].ToString() == "1")
            {
                Chk_Associate.Checked = true;
                Pnl_Associate.Show();
                Cmb_Field_Associate.Text = dr["Major_Associate"].ToString();
                Cmb_University_Associate.Text = dr["Uni_Associate"].ToString();
                Cmb_Grade_Associate.Text = dr["Grade_Associate"].ToString();
            }

            if (dr["Bechelor"].ToString() == "1")
            {
                Chk_Bach.Checked = true;
                Pnl_Bach.Show();
                Cmb_Field_Bach.Text = dr["Major_Bechelor"].ToString();
                Cmb_University_Bach.Text = dr["Uni_Bechelor"].ToString();
                Cmb_Grade_Bach.Text = dr["Grade_Bechelor"].ToString();
            }

            if (dr["Master"].ToString() == "1")
            {
                Chk_Master.Checked = true;
                Pnl_Master.Show();
                Cmb_Field_Master.Text = dr["Major_Master"].ToString();
                Cmb_University_Master.Text = dr["Uni_Master"].ToString();
                Cmb_Grade_Master.Text = dr["Grade_Master"].ToString();
            }
            
            dr.Close();
            myConnection.Close();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            myConnection.Open();

            cmd.Connection = myConnection;
            cmd.CommandText = "DELETE FROM Users WHERE National_Number=@NAT_NUM";
            cmd.Parameters.AddWithValue("NAT_NUM", Currentuser);

            DialogResult result = MessageBox.Show("Are you Sure you want to delete this Record?", "Delete Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Record Deleted Successfully");
                cmd.ExecuteNonQuery();
                myConnection.Close();
                Application.Exit();
            } 
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Currentuser = Currentuser;
            form2.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                myConnection.Open();
                cmd.Connection = myConnection;
                cmd.CommandText = "SELECT * FROM users";
                dr = cmd.ExecuteReader();
                var writer = new StreamWriter("Database_Instance.txt");
                writer.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
                    dr.GetName(0), dr.GetName(1), dr.GetName(2), dr.GetName(3), dr.GetName(4), dr.GetName(5), dr.GetName(6), dr.GetName(7), dr.GetName(8), dr.GetName(9), dr.GetName(10), dr.GetName(11), dr.GetName(12), dr.GetName(13), dr.GetName(14), dr.GetName(15), dr.GetName(16), dr.GetName(17), dr.GetName(18), dr.GetName(19), dr.GetName(20), dr.GetName(21), dr.GetName(22), dr.GetName(23), dr.GetName(24), dr.GetName(25)));
                while (dr.Read())
                {
                    writer.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
                     dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11], dr[12], dr[13], dr[14], dr[15], dr[16], dr[17], dr[18], dr[19], dr[20], dr[21], dr[22], dr[23], dr[24], dr[25]));
                }
                writer.Close();

                dr.Close();

                myConnection.Close();
                MessageBox.Show("Database Successfully Exported to: bin\\Debug\\Database_Instance.txt");
            }
            catch (Exception v)
            {
                MessageBox.Show("Database Didnt Successfully Export..");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.csb.gov.jo/web/index.php?option=com_k2&view=item&layout=item&id=18&Itemid=163&lang=ar");
            Process.Start(sInfo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
