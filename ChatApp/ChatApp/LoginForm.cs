using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.VisualBasic;

namespace ChatApp
{




    public partial class LoginForm : Form
    {
        Connect.WebService1SoapClient conn;
        public LoginForm()
        {
            InitializeComponent();
            conn = new Connect.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (user_name_text_box.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المستخدم", "مدخلات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user_name_text_box.Focus();
                    return;
                }
                if (password_text_box.Text == "")
                {
                    MessageBox.Show("يجب ادخال رقم الهاتف", "مدخلات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_text_box.Focus();
                    return;
                }

                if (conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows.Count == 0)
                {
                    MessageBox.Show("خطأ في اسم المستخدم او رقم الهاتف", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_name_text_box.Clear();
                    password_text_box.Clear();
                    user_name_text_box.Focus();
                }
                else
                {
                    if (conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["online"].ToString() == "1")
                    {
                        MessageBox.Show("You are already in", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChatForm chat = new ChatForm();
                        chat.User_id = int.Parse(conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["user_id"].ToString());
                        conn.LoginUser(chat.User_id);
                        chat.User_About = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["about"].ToString();
                        chat.User_name = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["user_name"].ToString();
                        chat.User_phone = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["phone"].ToString();
                        chat.Image_name = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["image"].ToString();
                        chat.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label5.Visible = true;
            about_text_box.Visible = true;
            create_account.Visible = true;
            button1.Visible = false;
            linkLabel1.Visible = false;
            label1.Text = "Create account";
        }

        private void create_account_Click(object sender, EventArgs e)
        {
            try
            {
                if (user_name_text_box.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المستخدم", "مدخلات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user_name_text_box.Focus();
                    return;
                }
                if (password_text_box.Text == "")
                {
                    MessageBox.Show("يجب ادخال رقم الهاتف", "مدخلات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_text_box.Focus();
                    return;
                }

                conn.CreateUser(user_name_text_box.Text, password_text_box.Text, about_text_box.Text);

                ChatForm chat = new ChatForm();
                chat.User_id = int.Parse(conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["user_id"].ToString());
                conn.LoginUser(chat.User_id);
                chat.User_About = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["about"].ToString();
                chat.User_name = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["user_name"].ToString();
                chat.User_phone = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["phone"].ToString();
                chat.Image_name = conn.CheckUser(user_name_text_box.Text, password_text_box.Text).Tables["Table"].Rows[0]["image"].ToString();
                chat.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
