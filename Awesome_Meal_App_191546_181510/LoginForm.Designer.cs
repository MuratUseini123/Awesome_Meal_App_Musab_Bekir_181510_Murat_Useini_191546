
namespace Awesome_Meal_App_191546_181510
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmployeePass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chckShowPass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(59, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 3);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Id";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(57, 186);
            this.txtEmployeeId.MinimumSize = new System.Drawing.Size(241, 40);
            this.txtEmployeeId.Multiline = true;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(241, 40);
            this.txtEmployeeId.TabIndex = 2;
            this.txtEmployeeId.Text = "Enter some text";
            this.txtEmployeeId.Enter += new System.EventHandler(this.txtEmployeeId_Enter);
            this.txtEmployeeId.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeId_Validating_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(57, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel3.Location = new System.Drawing.Point(57, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 3);
            this.panel3.TabIndex = 7;
            // 
            // txtEmployeePass
            // 
            this.txtEmployeePass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmployeePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmployeePass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePass.Location = new System.Drawing.Point(57, 306);
            this.txtEmployeePass.Multiline = true;
            this.txtEmployeePass.Name = "txtEmployeePass";
            this.txtEmployeePass.PasswordChar = '*';
            this.txtEmployeePass.Size = new System.Drawing.Size(241, 40);
            this.txtEmployeePass.TabIndex = 3;
            this.txtEmployeePass.Text = "123456789";
            this.txtEmployeePass.Enter += new System.EventHandler(this.txtEmployeePass_Enter);
            this.txtEmployeePass.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeePass_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Password";
            // 
            // chckShowPass
            // 
            this.chckShowPass.AutoSize = true;
            this.chckShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckShowPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chckShowPass.Location = new System.Drawing.Point(59, 371);
            this.chckShowPass.Name = "chckShowPass";
            this.chckShowPass.Size = new System.Drawing.Size(136, 25);
            this.chckShowPass.TabIndex = 4;
            this.chckShowPass.Text = "Show password";
            this.chckShowPass.UseVisualStyleBackColor = true;
            this.chckShowPass.CheckedChanged += new System.EventHandler(this.chckShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(57, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(241, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log-in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 544);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chckShowPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmployeePass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmployeePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chckShowPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}