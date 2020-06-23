using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_API_CALL
{
    public partial class frmLogIn : MetroFramework.Forms.MetroForm
    {

        //frmLogIn m_frmLogIn = new frmLogIn();
        public frmLogIn()
        {
            InitializeComponent();
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            csUserCredential.Instance.UserName = txtUsername.Text;
            csUserCredential.Instance.Password = txtPassword.Text;
            this.Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            csWinAPI.AnimateWindow(this.Handle, 1000, csWinAPI.BLEND);
        }
    }
}
