namespace ClientApp
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LettersGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFIOSen = new System.Windows.Forms.TextBox();
            this.textBoxAdressSen = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCityRec = new System.Windows.Forms.TextBox();
            this.textBoxFIOrec = new System.Windows.Forms.TextBox();
            this.textBoxAdrrec = new System.Windows.Forms.TextBox();
            this.StatusRegcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCurier = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LettersGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LettersGridView
            // 
            this.LettersGridView.AllowUserToAddRows = false;
            this.LettersGridView.AllowUserToDeleteRows = false;
            this.LettersGridView.AllowUserToResizeColumns = false;
            this.LettersGridView.AllowUserToResizeRows = false;
            this.LettersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LettersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LettersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LettersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LettersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LettersGridView.ColumnHeadersHeight = 25;
            this.LettersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LettersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.LettersGridView.Location = new System.Drawing.Point(6, 19);
            this.LettersGridView.MultiSelect = false;
            this.LettersGridView.Name = "LettersGridView";
            this.LettersGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LettersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LettersGridView.RowHeadersVisible = false;
            this.LettersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LettersGridView.Size = new System.Drawing.Size(452, 332);
            this.LettersGridView.TabIndex = 5;
            this.LettersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LettersGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LettersGridView);
            this.groupBox1.Location = new System.Drawing.Point(314, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список писем";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxCurier);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.StatusRegcomboBox);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 366);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об отправлении";
            // 
            // textBoxFIOSen
            // 
            this.textBoxFIOSen.Enabled = false;
            this.textBoxFIOSen.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFIOSen.ForeColor = System.Drawing.Color.Black;
            this.textBoxFIOSen.Location = new System.Drawing.Point(6, 19);
            this.textBoxFIOSen.Name = "textBoxFIOSen";
            this.textBoxFIOSen.Size = new System.Drawing.Size(265, 23);
            this.textBoxFIOSen.TabIndex = 1;
            this.textBoxFIOSen.Text = "ФИО отправителя";
            this.textBoxFIOSen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFIOSen.Enter += new System.EventHandler(this.textBoxFIOSen_Enter);
            this.textBoxFIOSen.Leave += new System.EventHandler(this.textBoxFIOSen_Leave);
            // 
            // textBoxAdressSen
            // 
            this.textBoxAdressSen.Enabled = false;
            this.textBoxAdressSen.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdressSen.ForeColor = System.Drawing.Color.Black;
            this.textBoxAdressSen.Location = new System.Drawing.Point(6, 78);
            this.textBoxAdressSen.Name = "textBoxAdressSen";
            this.textBoxAdressSen.Size = new System.Drawing.Size(265, 23);
            this.textBoxAdressSen.TabIndex = 2;
            this.textBoxAdressSen.Text = "Адрес отправителя";
            this.textBoxAdressSen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAdressSen.Enter += new System.EventHandler(this.textBoxAdressSen_Enter);
            this.textBoxAdressSen.Leave += new System.EventHandler(this.textBoxAdressSen_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Город отправителя";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBoxFIOSen);
            this.groupBox3.Controls.Add(this.textBoxAdressSen);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 114);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отправитель";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCityRec);
            this.groupBox4.Controls.Add(this.textBoxFIOrec);
            this.groupBox4.Controls.Add(this.textBoxAdrrec);
            this.groupBox4.Location = new System.Drawing.Point(7, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 114);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Получатель";
            // 
            // textBoxCityRec
            // 
            this.textBoxCityRec.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCityRec.ForeColor = System.Drawing.Color.Silver;
            this.textBoxCityRec.Location = new System.Drawing.Point(6, 49);
            this.textBoxCityRec.Name = "textBoxCityRec";
            this.textBoxCityRec.Size = new System.Drawing.Size(265, 23);
            this.textBoxCityRec.TabIndex = 3;
            this.textBoxCityRec.Text = "Город получателя";
            this.textBoxCityRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCityRec.Enter += new System.EventHandler(this.textBoxCityRec_Enter);
            this.textBoxCityRec.Leave += new System.EventHandler(this.textBoxCityRec_Leave);
            // 
            // textBoxFIOrec
            // 
            this.textBoxFIOrec.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFIOrec.ForeColor = System.Drawing.Color.Silver;
            this.textBoxFIOrec.Location = new System.Drawing.Point(6, 19);
            this.textBoxFIOrec.Name = "textBoxFIOrec";
            this.textBoxFIOrec.Size = new System.Drawing.Size(265, 23);
            this.textBoxFIOrec.TabIndex = 1;
            this.textBoxFIOrec.Text = "ФИО получателя";
            this.textBoxFIOrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFIOrec.Enter += new System.EventHandler(this.textBoxFIOrec_Enter);
            this.textBoxFIOrec.Leave += new System.EventHandler(this.textBoxFIOrec_Leave);
            // 
            // textBoxAdrrec
            // 
            this.textBoxAdrrec.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdrrec.ForeColor = System.Drawing.Color.Silver;
            this.textBoxAdrrec.Location = new System.Drawing.Point(6, 78);
            this.textBoxAdrrec.Name = "textBoxAdrrec";
            this.textBoxAdrrec.Size = new System.Drawing.Size(265, 23);
            this.textBoxAdrrec.TabIndex = 2;
            this.textBoxAdrrec.Text = "Адрес получателя";
            this.textBoxAdrrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAdrrec.Enter += new System.EventHandler(this.textBoxAdrrec_Enter);
            this.textBoxAdrrec.Leave += new System.EventHandler(this.textBoxAdrrec_Leave);
            // 
            // StatusRegcomboBox
            // 
            this.StatusRegcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusRegcomboBox.FormattingEnabled = true;
            this.StatusRegcomboBox.Items.AddRange(new object[] {
            "Отправлено",
            "Прибыло в город назначения",
            "Доставлено"});
            this.StatusRegcomboBox.Location = new System.Drawing.Point(13, 260);
            this.StatusRegcomboBox.Name = "StatusRegcomboBox";
            this.StatusRegcomboBox.Size = new System.Drawing.Size(211, 21);
            this.StatusRegcomboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Статус";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Курьер";
            // 
            // comboBoxCurier
            // 
            this.comboBoxCurier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurier.Enabled = false;
            this.comboBoxCurier.FormattingEnabled = true;
            this.comboBoxCurier.Location = new System.Drawing.Point(13, 289);
            this.comboBoxCurier.Name = "comboBoxCurier";
            this.comboBoxCurier.Size = new System.Drawing.Size(211, 21);
            this.comboBoxCurier.TabIndex = 13;
            // 
            // SendButton
            // 
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(12, 325);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(265, 26);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "Отправить письмо";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Получатель";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Статус";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Почта России ";
            ((System.ComponentModel.ISupportInitialize)(this.LettersGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LettersGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCityRec;
        private System.Windows.Forms.TextBox textBoxFIOrec;
        private System.Windows.Forms.TextBox textBoxAdrrec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxFIOSen;
        private System.Windows.Forms.TextBox textBoxAdressSen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusRegcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCurier;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

