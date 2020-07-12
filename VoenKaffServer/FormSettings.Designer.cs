namespace VoenKaffServer
{
    partial class FormSettings
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
            this.TestDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestDirectory
            // 
            this.TestDirectory.Location = new System.Drawing.Point(160, 66);
            this.TestDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.TestDirectory.Name = "TestDirectory";
            this.TestDirectory.Size = new System.Drawing.Size(165, 20);
            this.TestDirectory.TabIndex = 0;
            this.TestDirectory.Leave += new System.EventHandler(this.TestDirectory_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка с тестами:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(160, 104);
            this.Port.Margin = new System.Windows.Forms.Padding(2);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(51, 20);
            this.Port.TabIndex = 2;
            this.Port.Leave += new System.EventHandler(this.Port_Leave);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.Location = new System.Drawing.Point(11, 107);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 15);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Порт:";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(140, 210);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(146, 46);
            this.Close.TabIndex = 4;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.close_Click);
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(160, 141);
            this.IpAddress.Margin = new System.Windows.Forms.Padding(2);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(165, 20);
            this.IpAddress.TabIndex = 5;
            this.IpAddress.Leave += new System.EventHandler(this.IpAddress_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Папка с результатами:";
            // 
            // resultsDirectory
            // 
            this.resultsDirectory.Location = new System.Drawing.Point(160, 30);
            this.resultsDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.resultsDirectory.Name = "resultsDirectory";
            this.resultsDirectory.Size = new System.Drawing.Size(165, 20);
            this.resultsDirectory.TabIndex = 8;
            this.resultsDirectory.Leave += new System.EventHandler(this.resultsDirectory_Leave);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultsDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestDirectory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TestDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultsDirectory;
    }
}