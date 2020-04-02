using System;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class frVigenere : Form
    {
        public frVigenere()
        {
            InitializeComponent();
        }

        private void BttnEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            string password = txtPwd.Text;

            Encryption encryption = new Encryption(key, password);

            key = encryption.getNewKey();
            password = encryption.getEncryption();

            txtNewKey.Text = key;
            txtResult.Text = password;
        }
    }
}