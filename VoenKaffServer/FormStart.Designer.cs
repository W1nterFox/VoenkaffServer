namespace VoenKaffServer
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСФлешкойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТестыНаФлешкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТестыСФлешкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridResultTest = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlTest = new System.Windows.Forms.TabControl();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridResultStudy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultTest)).BeginInit();
            this.tabControlTest.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выйтиИзАккаунтаToolStripMenuItem,
            this.скачатьДокументToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem,
            this.работаСФлешкойToolStripMenuItem,
            this.удалениеРезультатовToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(930, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = " Меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзАккаунтаToolStripMenuItem_Click);
            // 
            // скачатьДокументToolStripMenuItem
            // 
            this.скачатьДокументToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестированиеToolStripMenuItem,
            this.обучениеToolStripMenuItem,
            this.скачатьВсеToolStripMenuItem});
            this.скачатьДокументToolStripMenuItem.Name = "скачатьДокументToolStripMenuItem";
            this.скачатьДокументToolStripMenuItem.Size = new System.Drawing.Size(207, 20);
            this.скачатьДокументToolStripMenuItem.Text = "Сохранить в виде документа Word";
            // 
            // тестированиеToolStripMenuItem
            // 
            this.тестированиеToolStripMenuItem.Name = "тестированиеToolStripMenuItem";
            this.тестированиеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.тестированиеToolStripMenuItem.Text = "Тестирование";
            this.тестированиеToolStripMenuItem.Click += new System.EventHandler(this.тестированиеToolStripMenuItem_Click);
            // 
            // обучениеToolStripMenuItem
            // 
            this.обучениеToolStripMenuItem.Name = "обучениеToolStripMenuItem";
            this.обучениеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.обучениеToolStripMenuItem.Text = "Обучение";
            this.обучениеToolStripMenuItem.Click += new System.EventHandler(this.обучениеToolStripMenuItem_Click);
            // 
            // скачатьВсеToolStripMenuItem
            // 
            this.скачатьВсеToolStripMenuItem.Name = "скачатьВсеToolStripMenuItem";
            this.скачатьВсеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.скачатьВсеToolStripMenuItem.Text = "Сохранить все";
            this.скачатьВсеToolStripMenuItem.Click += new System.EventHandler(this.скачатьВсеToolStripMenuItem_Click);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // работаСФлешкойToolStripMenuItem
            // 
            this.работаСФлешкойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem,
            this.сохранитьТестыНаФлешкуToolStripMenuItem,
            this.загрузитьТестыСФлешкиToolStripMenuItem});
            this.работаСФлешкойToolStripMenuItem.Name = "работаСФлешкойToolStripMenuItem";
            this.работаСФлешкойToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.работаСФлешкойToolStripMenuItem.Text = "Работа с флешкой";
            // 
            // сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem
            // 
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem.Name = "сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem";
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem.Text = "Сохранить результаты на флешку";
            this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem_Click);
            // 
            // сохранитьТестыНаФлешкуToolStripMenuItem
            // 
            this.сохранитьТестыНаФлешкуToolStripMenuItem.Name = "сохранитьТестыНаФлешкуToolStripMenuItem";
            this.сохранитьТестыНаФлешкуToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.сохранитьТестыНаФлешкуToolStripMenuItem.Text = "Сохранить тесты на флешку";
            this.сохранитьТестыНаФлешкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТестыНаФлешкуToolStripMenuItem_Click);
            // 
            // загрузитьТестыСФлешкиToolStripMenuItem
            // 
            this.загрузитьТестыСФлешкиToolStripMenuItem.Name = "загрузитьТестыСФлешкиToolStripMenuItem";
            this.загрузитьТестыСФлешкиToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.загрузитьТестыСФлешкиToolStripMenuItem.Text = "Загрузить тесты с флешки";
            this.загрузитьТестыСФлешкиToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТестыСФлешкиToolStripMenuItem_Click);
            // 
            // удалениеРезультатовToolStripMenuItem
            // 
            this.удалениеРезультатовToolStripMenuItem.Name = "удалениеРезультатовToolStripMenuItem";
            this.удалениеРезультатовToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.удалениеРезультатовToolStripMenuItem.Text = "Удаление результатов";
            this.удалениеРезультатовToolStripMenuItem.Click += new System.EventHandler(this.удалениеРезультатовToolStripMenuItem_Click);
            // 
            // GridResultTest
            // 
            this.GridResultTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridResultTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.TestName,
            this.Platoon,
            this.StudentName,
            this.Mark,
            this.Timestamp});
            this.GridResultTest.Location = new System.Drawing.Point(5, 5);
            this.GridResultTest.Margin = new System.Windows.Forms.Padding(2);
            this.GridResultTest.Name = "GridResultTest";
            this.GridResultTest.RowTemplate.Height = 24;
            this.GridResultTest.Size = new System.Drawing.Size(884, 483);
            this.GridResultTest.TabIndex = 2;
            this.GridResultTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellContentClick);
            // 
            // Course
            // 
            this.Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course.FillWeight = 120F;
            this.Course.HeaderText = "Предмет";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.FillWeight = 120F;
            this.TestName.HeaderText = "Название Теста";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Platoon
            // 
            this.Platoon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Platoon.FillWeight = 120F;
            this.Platoon.HeaderText = "Взвод";
            this.Platoon.Name = "Platoon";
            this.Platoon.ReadOnly = true;
            this.Platoon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.FillWeight = 120F;
            this.StudentName.HeaderText = "ФИО";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mark.FillWeight = 120F;
            this.Mark.HeaderText = "Оценка";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Timestamp.FillWeight = 120F;
            this.Timestamp.HeaderText = "Дата";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabControlTest
            // 
            this.tabControlTest.Controls.Add(this.tabPageTest);
            this.tabControlTest.Controls.Add(this.tabPage2);
            this.tabControlTest.Location = new System.Drawing.Point(12, 27);
            this.tabControlTest.Name = "tabControlTest";
            this.tabControlTest.SelectedIndex = 0;
            this.tabControlTest.Size = new System.Drawing.Size(902, 519);
            this.tabControlTest.TabIndex = 3;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.GridResultTest);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(894, 493);
            this.tabPageTest.TabIndex = 0;
            this.tabPageTest.Text = "Тестирование";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridResultStudy);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обучение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridResultStudy
            // 
            this.GridResultStudy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridResultStudy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultStudy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.GridResultStudy.Location = new System.Drawing.Point(5, 5);
            this.GridResultStudy.Margin = new System.Windows.Forms.Padding(2);
            this.GridResultStudy.Name = "GridResultStudy";
            this.GridResultStudy.RowTemplate.Height = 24;
            this.GridResultStudy.Size = new System.Drawing.Size(884, 483);
            this.GridResultStudy.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название Теста";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 120F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Взвод";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 558);
            this.Controls.Add(this.tabControlTest);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStart";
            this.Text = "Сервер тестирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultTest)).EndInit();
            this.tabControlTest.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridResultStudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.DataGridView GridResultTest;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlTest;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GridResultStudy;
        private System.Windows.Forms.ToolStripMenuItem скачатьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучениеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem скачатьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСФлешкойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТестыНаФлешкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТестыСФлешкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеРезультатовToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

