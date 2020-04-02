namespace Vigenere
{
    partial class frVigenere
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.bttnEncrypt = new System.Windows.Forms.Button();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.lblNewKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(94, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(610, 22);
            this.txtKey.TabIndex = 0;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 15);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(47, 17);
            this.lblKey.TabIndex = 5;
            this.lblKey.Text = "Clave:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 43);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(73, 17);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(94, 40);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(610, 22);
            this.txtPwd.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 17);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(94, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(610, 22);
            this.txtResult.TabIndex = 4;
            // 
            // bttnEncrypt
            // 
            this.bttnEncrypt.Location = new System.Drawing.Point(710, 12);
            this.bttnEncrypt.Name = "bttnEncrypt";
            this.bttnEncrypt.Size = new System.Drawing.Size(106, 106);
            this.bttnEncrypt.TabIndex = 2;
            this.bttnEncrypt.Text = "Encriptar";
            this.bttnEncrypt.UseVisualStyleBackColor = true;
            this.bttnEncrypt.Click += new System.EventHandler(this.BttnEncrypt_Click);
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(94, 68);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.ReadOnly = true;
            this.txtNewKey.Size = new System.Drawing.Size(610, 22);
            this.txtNewKey.TabIndex = 3;
            // 
            // lblNewKey
            // 
            this.lblNewKey.AutoSize = true;
            this.lblNewKey.Location = new System.Drawing.Point(12, 71);
            this.lblNewKey.Name = "lblNewKey";
            this.lblNewKey.Size = new System.Drawing.Size(65, 17);
            this.lblNewKey.TabIndex = 7;
            this.lblNewKey.Text = "New key:";
            // 
            // frVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 130);
            this.Controls.Add(this.lblNewKey);
            this.Controls.Add(this.txtNewKey);
            this.Controls.Add(this.bttnEncrypt);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Name = "frVigenere";
            this.Text = "Vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button bttnEncrypt;
        private System.Windows.Forms.TextBox txtNewKey;
        private System.Windows.Forms.Label lblNewKey;
    }
}

