namespace RealState
{
    partial class LoginForm
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonLoginRegister = new System.Windows.Forms.Button();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labeUser = new System.Windows.Forms.Label();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonLoginRegister);
            this.groupBoxLogin.Controls.Add(this.textBoxPasswordConfirm);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelPasswordConfirm);
            this.groupBoxLogin.Controls.Add(this.linkLabelRegister);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.labeUser);
            this.groupBoxLogin.Controls.Add(this.labelLoginTitle);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(776, 426);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // buttonLoginRegister
            // 
            this.buttonLoginRegister.Location = new System.Drawing.Point(347, 235);
            this.buttonLoginRegister.Name = "buttonLoginRegister";
            this.buttonLoginRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginRegister.TabIndex = 8;
            this.buttonLoginRegister.Text = "Entrar";
            this.buttonLoginRegister.UseVisualStyleBackColor = true;
            this.buttonLoginRegister.Click += new System.EventHandler(this.buttonLoginRegister_Click);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(283, 199);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswordConfirm.TabIndex = 7;
            this.textBoxPasswordConfirm.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(283, 165);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(283, 131);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 20);
            this.textBoxUser.TabIndex = 5;
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.AutoSize = true;
            this.labelPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirm.Location = new System.Drawing.Point(150, 202);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(127, 13);
            this.labelPasswordConfirm.TabIndex = 4;
            this.labelPasswordConfirm.Text = "Confirmar contraseña";
            this.labelPasswordConfirm.Visible = false;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(355, 275);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(60, 13);
            this.linkLabelRegister.TabIndex = 3;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Registrarse";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(150, 168);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Contraseña";
            // 
            // labeUser
            // 
            this.labeUser.AutoSize = true;
            this.labeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeUser.Location = new System.Drawing.Point(150, 134);
            this.labeUser.Name = "labeUser";
            this.labeUser.Size = new System.Drawing.Size(54, 13);
            this.labeUser.TabIndex = 1;
            this.labeUser.Text = "Usuario:";
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.Location = new System.Drawing.Point(325, 44);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(117, 20);
            this.labelLoginTitle.TabIndex = 0;
            this.labelLoginTitle.Text = "REAL STATE";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonLoginRegister;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPasswordConfirm;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labeUser;
        private System.Windows.Forms.Label labelLoginTitle;
    }
}