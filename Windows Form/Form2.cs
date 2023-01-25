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
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Visual_Project
{
    public partial class Form2 : Form
    {
        public String Currentuser;
        SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=Users.db;Version=3");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet dt = new DataSet();
        DataTable ds;
        SQLiteDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void Date_Birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RadBtn_Married_CheckedChanged(object sender, EventArgs e)
        {
            Nmc_NumberChildren.Show();
            Lbl_numberofchildren.Show();
        }

        private void RadBtn_Unmarried_CheckedChanged(object sender, EventArgs e)
        {
            Nmc_NumberChildren.Hide();
            Lbl_numberofchildren.Hide();
            Nmc_NumberChildren.Value=0;

        }

        private void Chk_Associate_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Associate.Checked)
                Pnl_Associate.Show();
            else
            {
                Pnl_Associate.Hide();
                Chk_Bach.Checked = false;
                Chk_Master.Checked = false;
            }
        }

        private void Chk_Bach_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Bach.Checked)
            {
                Chk_Associate.Checked = true;
                Pnl_Bach.Show();
            }
            else
            {
                Pnl_Bach.Hide();
                Chk_Master.Checked = false;
            }     
        }

        private void Chk_Master_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Master.Checked)
            {
                Pnl_Master.Show();
            }
            else
                Pnl_Master.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BTN_Submit.Enabled = false;
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(Txt_Email.Text, pattern) == false)
            {
                MessageBox.Show("your email is wrong");
                return;
            }

            pattern = @"^[0-9]{10}$";
            if (Regex.IsMatch(Txt_Phone.Text, pattern) == false)
            {
                MessageBox.Show("your Phone Number is wrong");
                return;
            }


            myConnection.Open();
            cmd.Connection = myConnection;
            cmd.CommandText = "Update users set First_Name=@fname, Middle_Name=@mname, Last_Name=@lname, Gender=@gender, Birth_Date=@BDate,Email=@email, Phone_Num =@Phone , Address=@Address, Marital_Status=@Married, NumOfChildren=@Children, Experience=@Ex, Associate=@asso, Major_Associate=@Mjr_Asso, Uni_Associate=@Uni_Asso, Grade_Associate=@Grade_Asso, Bechelor=@Bech, Major_Bechelor=@Mjr_Bech, Uni_Bechelor=@Uni_Bech, Grade_Bechelor=@Grade_Bech, Master=@Master, Major_Master=@Mjr_Master, Uni_Master=@Uni_Master, Grade_Master=@Grade_Master, Applied=@Applied Where National_Number=@NAT_NUM";
            cmd.Parameters.AddWithValue("NAT_NUM", Currentuser);
            cmd.Parameters.AddWithValue("fname", TxtBox_FName.Text);
            cmd.Parameters.AddWithValue("mname", TxtBox_MName.Text);
            cmd.Parameters.AddWithValue("lname", TxtBox_LName.Text);

            if (RadBtn_Gender_Female.Checked)
            cmd.Parameters.AddWithValue("gender", 1);
            else
           cmd.Parameters.AddWithValue("gender", 0);

           cmd.Parameters.AddWithValue("BDate", Date_Birthday.Value);

            cmd.Parameters.AddWithValue("email",Txt_Email.Text);
            cmd.Parameters.AddWithValue("Phone", Txt_Phone.Text);
            cmd.Parameters.AddWithValue("Address", Txt_Address.Text);
            if (RadBtn_Married.Checked)
            {
                cmd.Parameters.AddWithValue("Married", 1);

                cmd.Parameters.AddWithValue("Children", Nmc_NumberChildren.Value.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("Married", 0);
                cmd.Parameters.AddWithValue("Children", 0);
            }
            
            cmd.Parameters.AddWithValue("EX", Txt_Experience.Text);

            if (Chk_Associate.Checked)
            {
                cmd.Parameters.AddWithValue("Mjr_Asso", Cmb_Field_Associate.Text);
                cmd.Parameters.AddWithValue("Uni_Asso", Cmb_University_Associate.Text);
                cmd.Parameters.AddWithValue("Grade_Asso", Cmb_Grade_Associate.Text);
                cmd.Parameters.AddWithValue("asso", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("Mjr_Asso", "");
                cmd.Parameters.AddWithValue("Uni_Asso", "");
                cmd.Parameters.AddWithValue("Grade_Asso", "");
                cmd.Parameters.AddWithValue("asso", 0);
            }
            if (Chk_Bach.Checked)
            {
                cmd.Parameters.AddWithValue("Mjr_Bech", Cmb_Field_Bach.Text);
                cmd.Parameters.AddWithValue("Uni_Bech", Cmb_University_Bach.Text);
                cmd.Parameters.AddWithValue("Grade_Bech", Cmb_Grade_Bach.Text);
                cmd.Parameters.AddWithValue("Bech", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("Mjr_Bech", "");
                cmd.Parameters.AddWithValue("Uni_Bech", "");
                cmd.Parameters.AddWithValue("Grade_Bech", "");
                cmd.Parameters.AddWithValue("Bech", 0);
            }

            if (Chk_Master.Checked)
            {
                cmd.Parameters.AddWithValue("Mjr_Master", Cmb_Field_Master.Text);
                cmd.Parameters.AddWithValue("Uni_Master", Cmb_University_Master.Text);
                cmd.Parameters.AddWithValue("Grade_Master", Cmb_Grade_Master.Text);
                cmd.Parameters.AddWithValue("Master", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("Master", 0);
                cmd.Parameters.AddWithValue("Mjr_Master", "");
                cmd.Parameters.AddWithValue("Uni_Master", "");
                cmd.Parameters.AddWithValue("Grade_Master", "");
            }

            cmd.Parameters.AddWithValue("Applied", 1);

            cmd.ExecuteNonQuery();  
            myConnection.Close();
            Application.Exit();
    
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            myConnection.Open();
            cmd.Connection = myConnection;
            cmd.CommandText = "SELECT * FROM users";  
            dr= cmd.ExecuteReader();
            var writer = new StreamWriter("Database_Instance.txt");
            writer.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
                dr.GetName(0), dr.GetName(1), dr.GetName(2), dr.GetName(3), dr.GetName(4), dr.GetName(5), dr.GetName(6), dr.GetName(7), dr.GetName(8), dr.GetName(9), dr.GetName(10), dr.GetName(11), dr.GetName(12), dr.GetName(13), dr.GetName(14), dr.GetName(15), dr.GetName(16), dr.GetName(17), dr.GetName(18), dr.GetName(19), dr.GetName(20), dr.GetName(21), dr.GetName(22), dr.GetName(23), dr.GetName(24), dr.GetName(25)));
            while (dr.Read()) {
                writer.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
                 dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11], dr[12], dr[13], dr[14], dr[15], dr[16], dr[17], dr[18], dr[19], dr[20], dr[21], dr[22], dr[23], dr[24], dr[25]));
            }
            writer.Close();

            dr.Close();
           
            myConnection.Close();
                MessageBox.Show("Database Successfully Exported to: bin\\Debug\\Database_Instance.txt");
            }
            catch(Exception v) {
                MessageBox.Show("Database Didnt Successfully Export..");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Chk_Associate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Chk_Associate.Checked)
                Pnl_Associate.Show();
            else
            {
                Pnl_Associate.Hide();
                Chk_Bach.Checked = false;
                Chk_Master.Checked = false;
            }
        }

        private void Chk_Bach_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Chk_Bach.Checked)
            {
                Chk_Bach.Checked = true;
            }
            else
            {
                Chk_Master.Checked = false;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.csb.gov.jo/web/index.php?option=com_k2&view=item&layout=item&id=18&Itemid=163&lang=ar");
            Process.Start(sInfo);
        }

        private void RadBtn_Married_CheckedChanged_1(object sender, EventArgs e)
        {
            if(RadBtn_Married.Checked)
            { Lbl_numberofchildren.Show();
                Nmc_NumberChildren.Show();
            }
        }

        private void RadBtn_Unmarried_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadBtn_Unmarried.Checked)
            {
                Lbl_numberofchildren.Hide();
                Nmc_NumberChildren.Hide();
                Nmc_NumberChildren.Value = 0;
            }

        }

        private void Cmb_University_Associate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox_FName.Text == "" || TxtBox_MName.Text == "" || TxtBox_LName.Text == "" || Txt_Email.Text == "" || Txt_Phone.Text == "")
            {
                BTN_Submit.Enabled = false;
            }
            else
            {
                BTN_Submit.Enabled = true;
            }
        }

        private void TxtBox_FName_TextChanged(object sender, EventArgs e)
        {

            if (TxtBox_FName.Text == "" || TxtBox_MName.Text == "" || TxtBox_LName.Text == "" || Txt_Email.Text == "" || Txt_Phone.Text == "")
            {
                BTN_Submit.Enabled = false;
            }
            else
            {
                BTN_Submit.Enabled = true;
            }
        }

        private void TxtBox_MName_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox_FName.Text == "" || TxtBox_MName.Text == "" || TxtBox_LName.Text == "" || Txt_Email.Text == "" || Txt_Phone.Text == "")
            {
                BTN_Submit.Enabled = false;
            }
            else
            {
                BTN_Submit.Enabled = true;
            }
        }

        private void TxtBox_LName_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox_FName.Text == "" || TxtBox_MName.Text == "" || TxtBox_LName.Text == "" || Txt_Email.Text == "" || Txt_Phone.Text == "")
            {
                BTN_Submit.Enabled = false;
            }
            else
            {
                BTN_Submit.Enabled = true;
            }
        }

        private void Txt_Phone_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox_FName.Text == "" || TxtBox_MName.Text == "" || TxtBox_LName.Text == "" || Txt_Email.Text == "" || Txt_Phone.Text == "")
            {
                BTN_Submit.Enabled = false;
            }
            else
            {
                BTN_Submit.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nmc_NumberChildren_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}