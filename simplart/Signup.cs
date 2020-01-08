using simplart.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplart
{
    public partial class fv_signup : Form
    {
        public fv_signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            Dispose();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            lbl_error_msg.Text = "";

            if (txt_email.TextLength < 1 || txt_password.TextLength < 1 || txt_username.TextLength < 1 )
            {
                lbl_error_msg.Text = "Tous les champs sont obligatoires !";
            }

            if(UserAuthService.userExist(txt_email.Text, txt_username.Text))
            {
                lbl_error_msg.Text = "Veuillez indiquer un autre email ou nom d'utilisateur !";
            }

            try
            {
                SlaDataSet dataSet = new SlaDataSet();
                SlaDataSetTableAdapters.SLA_USERSTableAdapter usersTableAdapter = new SlaDataSetTableAdapters.SLA_USERSTableAdapter();
                // Create a new row.
                SlaDataSet.SLA_USERSRow usersRow;
                usersRow = dataSet.SLA_USERS.NewSLA_USERSRow();

                usersRow.USR_ID = 1;
                usersRow.USR_EMAIL = txt_email.Text;
                usersRow.USR_NAME = txt_username.Text;
                usersRow.USR_PASSWORD = txt_password.Text;
                usersRow.USR_AGE = (int)nud_age.Value;

                switch (cbo_type.SelectedText)
                {
                    case "Client":
                        usersRow.USR_TYPE = 1;
                        break;
                    case "Artiste":
                        usersRow.USR_TYPE = 2;
                        break;
                    default:
                        usersRow.USR_TYPE = 1;
                        break;
                }

                // Add the row to the Region table
                dataSet.SLA_USERS.Rows.Add(usersRow);

                // Save the new row to the database
                usersTableAdapter.Update(dataSet.SLA_USERS);


                lbl_error_msg.Text = "Votre compte a bien été enregistré !";
                Dispose();
            }
            catch(SqlException ex)
            {
                lbl_error_msg.Text = "Une erreur est survenue ! Veuillez introduire des champs valides !";
            }
        }
    }
}
