
namespace DbExample332.Forms
{
    partial class UsersAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LLogin = new System.Windows.Forms.Label();
            this.LPass = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(96, 54);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(96, 80);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 2;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(33, 31);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(29, 13);
            this.LName.TabIndex = 3;
            this.LName.Text = "Имя";
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(33, 57);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(38, 13);
            this.LLogin.TabIndex = 4;
            this.LLogin.Text = "Логин";
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Location = new System.Drawing.Point(33, 83);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(45, 13);
            this.LPass.TabIndex = 5;
            this.LPass.Text = "Пароль";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(27, 109);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(169, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "button1";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // UsersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 165);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbName);
            this.Name = "UsersAddForm";
            this.Text = "UsersAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.Button btAdd;
    }
}