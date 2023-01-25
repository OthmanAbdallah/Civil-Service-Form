using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Visual_Project
{

    public partial class FORM_LoignRegester : Form
    {
        SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=Users.db;Version=3");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet dt = new DataSet();
        DataTable ds;
        SQLiteDataReader dr;

        public FORM_LoignRegester()
        {
            InitializeComponent();
        }

        public event EventHandler ContentChanged;

        private void button3_Click(object sender, EventArgs e)
        {
            BTN_LoginView.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            BTN_Signup.FlatAppearance.BorderColor = Color.RoyalBlue;
            PNL_Login.Hide();
            PNL_Regester.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BTN_LoginView.FlatAppearance.BorderColor = Color.RoyalBlue;
            BTN_Signup.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            PNL_Regester.Hide();
            PNL_Login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            cmd.Connection = myConnection;
            cmd.CommandText = "SELECT * FROM Users WHERE National_Number=@NAT_NUM";

            cmd.Parameters.AddWithValue("NAT_NUM", TxtBox_Login_NatNum.Text);
            dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                MessageBox.Show("No Account Found.");
            }
            else
            {
                if(TxtBox_Login_Password.Text == dr["Password"].ToString())
                {
                    if ((dr["Applied"]).ToString() == "1")
                    {
                        MessageBox.Show("You have already applied.");
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.Currentuser = TxtBox_Login_NatNum.Text;
                        form3.Show();
                    }
                    else
                    {
                        dr.Close();
                        myConnection.Close();
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Currentuser = TxtBox_Login_NatNum.Text;
                        form2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }

            dr.Close();
            myConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FORM_LoignRegester_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BTN_RegesterAndLogin_Click(object sender, EventArgs e)
        {
            string pattern = @"[^0-9]{10}$";
            if (Regex.IsMatch(TxtBox_Signup_NatNum.Text, pattern))
            {
                MessageBox.Show("your National Number is wrong");
                return;
            }
            else
            {
                myConnection.Open();
                cmd.Connection = myConnection;
                cmd.CommandText = "SELECT * FROM users WHERE National_Number=@NAT_NUM";
                cmd.Parameters.AddWithValue("NAT_NUM", TxtBox_Signup_NatNum.Text);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("The National Number you're trying to add is already registered.");
                }
                else
                {

                    if (TxtBox_PasswordConfirm.Text != TxtBox_Signup_Password.Text)
                    {
                        MessageBox.Show("Passwords don't match.");
                    }
                    else
                    {
                        dr.Close();

                        cmd.CommandText = "INSERT INTO users (National_Number,Password) Values (@NEW_NAT,@Pass)";
                        cmd.Parameters.AddWithValue("NEW_NAT", TxtBox_Signup_NatNum.Text);
                        cmd.Parameters.AddWithValue("Pass", TxtBox_Signup_Password.Text);
                        cmd.ExecuteNonQuery();
                        myConnection.Close();


                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Currentuser = TxtBox_Signup_NatNum.Text;
                        form2.Show();

                    }
                }
                dr.Close();
                myConnection.Close();
            }
        }

        private void TxtBox_Signup_NatNum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PNL_Regester_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.National_Number = TxtBox_Login_NatNum.Text;
            
            if (user1.EasterEgg())
            {
                MessageBox.Show($"{user1.National_Number}");
                this.BackColor = Color.Red;
            }
        }
    }
}