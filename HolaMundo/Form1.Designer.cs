namespace HolaMundo
{
    partial class formValidatePassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            txtPass = new TextBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPass = new Label();
            lblPass = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Lucida Console", 18F);
            btnSubmit.Location = new Point(58, 211);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(142, 42);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Validar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Lucida Console", 18F);
            txtPass.Location = new Point(12, 48);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(242, 31);
            txtPass.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Lucida Console", 18F);
            txtConfirmPassword.Location = new Point(12, 118);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(242, 31);
            txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblConfirmPass.Location = new Point(12, 91);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(169, 21);
            lblConfirmPass.TabIndex = 3;
            lblConfirmPass.Text = "Confirmar Contraseña";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblPass.Location = new Point(12, 21);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(165, 21);
            lblPass.TabIndex = 3;
            lblPass.Text = "Ingrese su contraseña";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 170);
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(242, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            // 
            // formValidatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(266, 265);
            Controls.Add(progressBar1);
            Controls.Add(lblPass);
            Controls.Add(lblConfirmPass);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPass);
            Controls.Add(btnSubmit);
            ForeColor = SystemColors.ControlText;
            Name = "formValidatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtPass;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPass;
        private Label lblPass;
        private ProgressBar progressBar1;
    }
}
