namespace DersProgrami
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tablo = new System.Windows.Forms.DataGridView();
            this.dersSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazartesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsambaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persembeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cizgeDataSet = new DersProgrami.CizgeDataSet();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dersTableAdapter = new DersProgrami.CizgeDataSetTableAdapters.DersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(107, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dersi Çizelgeye Gönder\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(107, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çizelgeyi Sıfıla\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ayrık İşlemler",
            "Algoritma I",
            "Algoritma II",
            "Organizasyon",
            "Mantık Devreleri",
            "Sayısal Analiz",
            "Web Teknolojileri",
            "Web Programlama"});
            this.comboBox1.Location = new System.Drawing.Point(12, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 27);
            this.comboBox1.TabIndex = 2;
            // 
            // tablo
            // 
            this.tablo.AutoGenerateColumns = false;
            this.tablo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersSaatiDataGridViewTextBoxColumn,
            this.pazartesiDataGridViewTextBoxColumn,
            this.saliDataGridViewTextBoxColumn,
            this.carsambaDataGridViewTextBoxColumn,
            this.persembeDataGridViewTextBoxColumn,
            this.cumaDataGridViewTextBoxColumn});
            this.tablo.DataSource = this.dersBindingSource;
            this.tablo.Location = new System.Drawing.Point(12, 259);
            this.tablo.Margin = new System.Windows.Forms.Padding(6);
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(670, 320);
            this.tablo.TabIndex = 4;
            // 
            // dersSaatiDataGridViewTextBoxColumn
            // 
            this.dersSaatiDataGridViewTextBoxColumn.DataPropertyName = "Ders_Saati";
            this.dersSaatiDataGridViewTextBoxColumn.HeaderText = "Ders_Saati";
            this.dersSaatiDataGridViewTextBoxColumn.Name = "dersSaatiDataGridViewTextBoxColumn";
            // 
            // pazartesiDataGridViewTextBoxColumn
            // 
            this.pazartesiDataGridViewTextBoxColumn.DataPropertyName = "Pazartesi";
            this.pazartesiDataGridViewTextBoxColumn.HeaderText = "Pazartesi";
            this.pazartesiDataGridViewTextBoxColumn.Name = "pazartesiDataGridViewTextBoxColumn";
            // 
            // saliDataGridViewTextBoxColumn
            // 
            this.saliDataGridViewTextBoxColumn.DataPropertyName = "Sali";
            this.saliDataGridViewTextBoxColumn.HeaderText = "Sali";
            this.saliDataGridViewTextBoxColumn.Name = "saliDataGridViewTextBoxColumn";
            // 
            // carsambaDataGridViewTextBoxColumn
            // 
            this.carsambaDataGridViewTextBoxColumn.DataPropertyName = "Carsamba";
            this.carsambaDataGridViewTextBoxColumn.HeaderText = "Carsamba";
            this.carsambaDataGridViewTextBoxColumn.Name = "carsambaDataGridViewTextBoxColumn";
            // 
            // persembeDataGridViewTextBoxColumn
            // 
            this.persembeDataGridViewTextBoxColumn.DataPropertyName = "Persembe";
            this.persembeDataGridViewTextBoxColumn.HeaderText = "Persembe";
            this.persembeDataGridViewTextBoxColumn.Name = "persembeDataGridViewTextBoxColumn";
            // 
            // cumaDataGridViewTextBoxColumn
            // 
            this.cumaDataGridViewTextBoxColumn.DataPropertyName = "Cuma";
            this.cumaDataGridViewTextBoxColumn.HeaderText = "Cuma";
            this.cumaDataGridViewTextBoxColumn.Name = "cumaDataGridViewTextBoxColumn";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.cizgeDataSet;
            // 
            // cizgeDataSet
            // 
            this.cizgeDataSet.DataSetName = "CizgeDataSet";
            this.cizgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(242, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(155, 27);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ders Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dersin Saati";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 248);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(221, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Çizelgeyi Oluştur\r\n\r\n";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(221, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Çıkış\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 597);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ders Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView tablo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private CizgeDataSet cizgeDataSet;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private CizgeDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazartesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsambaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persembeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

