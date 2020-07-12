namespace VoenKaffServer
{
    partial class FormDeleteResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteResButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.deleteResButton);
            this.panel1.Controls.Add(this.panelCourses);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 383);
            this.panel1.TabIndex = 0;
            // 
            // panelCourses
            // 
            this.panelCourses.AutoScroll = true;
            this.panelCourses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCourses.Location = new System.Drawing.Point(19, 55);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(649, 265);
            this.panelCourses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удаление результатов";
            // 
            // deleteResButton
            // 
            this.deleteResButton.Enabled = false;
            this.deleteResButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteResButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.deleteResButton.Location = new System.Drawing.Point(245, 326);
            this.deleteResButton.Name = "deleteResButton";
            this.deleteResButton.Size = new System.Drawing.Size(178, 45);
            this.deleteResButton.TabIndex = 8;
            this.deleteResButton.Text = "Удалить результаты";
            this.deleteResButton.UseVisualStyleBackColor = true;
            this.deleteResButton.Click += new System.EventHandler(this.deleteResButton_Click);
            // 
            // FormDeleteResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 408);
            this.Controls.Add(this.panel1);
            this.Name = "FormDeleteResults";
            this.Text = "Удаление результатов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Button deleteResButton;
    }
}