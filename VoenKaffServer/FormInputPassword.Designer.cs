namespace VoenKaffServer
{
    partial class FormInputPassword
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonContinueDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelUserPassword.Location = new System.Drawing.Point(3, 10);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(62, 20);
            this.labelUserPassword.TabIndex = 6;
            this.labelUserPassword.Text = "Пароль";
            // 
            // buttonContinueDelete
            // 
            this.buttonContinueDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinueDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonContinueDelete.Location = new System.Drawing.Point(112, 53);
            this.buttonContinueDelete.Name = "buttonContinueDelete";
            this.buttonContinueDelete.Size = new System.Drawing.Size(131, 35);
            this.buttonContinueDelete.TabIndex = 7;
            this.buttonContinueDelete.Text = "Продолжить";
            this.buttonContinueDelete.UseVisualStyleBackColor = true;
            this.buttonContinueDelete.Click += new System.EventHandler(this.buttonContinueDelete_Click);
            // 
            // FormInputPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 100);
            this.Controls.Add(this.buttonContinueDelete);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormInputPassword";
            this.Text = "Введите пароль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInputPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button buttonContinueDelete;
    }
}