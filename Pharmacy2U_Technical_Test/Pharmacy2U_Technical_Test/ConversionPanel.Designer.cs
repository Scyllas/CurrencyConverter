namespace Pharmacy2U_Technical_Test
{
    partial class ConversionPanel
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
            this.txt_beforeConversion = new System.Windows.Forms.TextBox();
            this.txt_afterConversion = new System.Windows.Forms.TextBox();
            this.lbl_beforeConversion = new System.Windows.Forms.Label();
            this.lbl_afterConversion = new System.Windows.Forms.Label();
            this.cmb_beforeCurrency = new System.Windows.Forms.ComboBox();
            this.lbl_beforeCurrency = new System.Windows.Forms.Label();
            this.lbl_afterCurrency = new System.Windows.Forms.Label();
            this.cmb_afterCurrency = new System.Windows.Forms.ComboBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.dtp_Min = new System.Windows.Forms.DateTimePicker();
            this.dtp_Max = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_live = new System.Windows.Forms.Label();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.dgv_live = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_live)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_beforeConversion
            // 
            this.txt_beforeConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_beforeConversion.Location = new System.Drawing.Point(12, 41);
            this.txt_beforeConversion.Name = "txt_beforeConversion";
            this.txt_beforeConversion.Size = new System.Drawing.Size(100, 20);
            this.txt_beforeConversion.TabIndex = 0;
            // 
            // txt_afterConversion
            // 
            this.txt_afterConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_afterConversion.Location = new System.Drawing.Point(188, 41);
            this.txt_afterConversion.Name = "txt_afterConversion";
            this.txt_afterConversion.Size = new System.Drawing.Size(100, 20);
            this.txt_afterConversion.TabIndex = 1;
            // 
            // lbl_beforeConversion
            // 
            this.lbl_beforeConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_beforeConversion.AutoSize = true;
            this.lbl_beforeConversion.Location = new System.Drawing.Point(12, 25);
            this.lbl_beforeConversion.Name = "lbl_beforeConversion";
            this.lbl_beforeConversion.Size = new System.Drawing.Size(94, 13);
            this.lbl_beforeConversion.TabIndex = 3;
            this.lbl_beforeConversion.Text = "Before Conversion";
            // 
            // lbl_afterConversion
            // 
            this.lbl_afterConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_afterConversion.AutoSize = true;
            this.lbl_afterConversion.Location = new System.Drawing.Point(185, 25);
            this.lbl_afterConversion.Name = "lbl_afterConversion";
            this.lbl_afterConversion.Size = new System.Drawing.Size(85, 13);
            this.lbl_afterConversion.TabIndex = 4;
            this.lbl_afterConversion.Text = "After Conversion";
            // 
            // cmb_beforeCurrency
            // 
            this.cmb_beforeCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_beforeCurrency.FormattingEnabled = true;
            this.cmb_beforeCurrency.Location = new System.Drawing.Point(12, 86);
            this.cmb_beforeCurrency.Name = "cmb_beforeCurrency";
            this.cmb_beforeCurrency.Size = new System.Drawing.Size(121, 21);
            this.cmb_beforeCurrency.TabIndex = 5;
            // 
            // lbl_beforeCurrency
            // 
            this.lbl_beforeCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_beforeCurrency.AutoSize = true;
            this.lbl_beforeCurrency.Location = new System.Drawing.Point(12, 70);
            this.lbl_beforeCurrency.Name = "lbl_beforeCurrency";
            this.lbl_beforeCurrency.Size = new System.Drawing.Size(83, 13);
            this.lbl_beforeCurrency.TabIndex = 6;
            this.lbl_beforeCurrency.Text = "Before Currency";
            // 
            // lbl_afterCurrency
            // 
            this.lbl_afterCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_afterCurrency.AutoSize = true;
            this.lbl_afterCurrency.Location = new System.Drawing.Point(188, 70);
            this.lbl_afterCurrency.Name = "lbl_afterCurrency";
            this.lbl_afterCurrency.Size = new System.Drawing.Size(74, 13);
            this.lbl_afterCurrency.TabIndex = 9;
            this.lbl_afterCurrency.Text = "After Currency";
            // 
            // cmb_afterCurrency
            // 
            this.cmb_afterCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_afterCurrency.FormattingEnabled = true;
            this.cmb_afterCurrency.Location = new System.Drawing.Point(188, 86);
            this.cmb_afterCurrency.Name = "cmb_afterCurrency";
            this.cmb_afterCurrency.Size = new System.Drawing.Size(121, 21);
            this.cmb_afterCurrency.TabIndex = 8;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(324, 41);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(96, 66);
            this.btn_Convert.TabIndex = 10;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // dtp_Min
            // 
            this.dtp_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Min.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtp_Min.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Min.Location = new System.Drawing.Point(507, 15);
            this.dtp_Min.Name = "dtp_Min";
            this.dtp_Min.Size = new System.Drawing.Size(200, 20);
            this.dtp_Min.TabIndex = 11;
            // 
            // dtp_Max
            // 
            this.dtp_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Max.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtp_Max.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Max.Location = new System.Drawing.Point(713, 15);
            this.dtp_Max.Name = "dtp_Max";
            this.dtp_Max.Size = new System.Drawing.Size(200, 20);
            this.dtp_Max.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(919, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // lbl_live
            // 
            this.lbl_live.AutoSize = true;
            this.lbl_live.Location = new System.Drawing.Point(423, 233);
            this.lbl_live.Name = "lbl_live";
            this.lbl_live.Size = new System.Drawing.Size(48, 13);
            this.lbl_live.TabIndex = 15;
            this.lbl_live.Text = "Live Log";
            // 
            // dgv_search
            // 
            this.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.beforeCurrency,
            this.beforeValue,
            this.afterCurrency,
            this.afterValue});
            this.dgv_search.Location = new System.Drawing.Point(426, 41);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.Size = new System.Drawing.Size(571, 189);
            this.dgv_search.TabIndex = 16;
            // 
            // dgv_live
            // 
            this.dgv_live.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_live.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_live.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_live.Location = new System.Drawing.Point(426, 249);
            this.dgv_live.Name = "dgv_live";
            this.dgv_live.Size = new System.Drawing.Size(571, 189);
            this.dgv_live.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Before Currency";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Before Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "After Currency";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "After Value";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 200F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // beforeCurrency
            // 
            this.beforeCurrency.HeaderText = "Before Currency";
            this.beforeCurrency.Name = "beforeCurrency";
            // 
            // beforeValue
            // 
            this.beforeValue.HeaderText = "Before Value";
            this.beforeValue.Name = "beforeValue";
            // 
            // afterCurrency
            // 
            this.afterCurrency.HeaderText = "After Currency";
            this.afterCurrency.Name = "afterCurrency";
            // 
            // afterValue
            // 
            this.afterValue.HeaderText = "After Value";
            this.afterValue.Name = "afterValue";
            // 
            // ConversionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.dgv_live);
            this.Controls.Add(this.dgv_search);
            this.Controls.Add(this.lbl_live);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_Max);
            this.Controls.Add(this.dtp_Min);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.lbl_afterCurrency);
            this.Controls.Add(this.cmb_afterCurrency);
            this.Controls.Add(this.lbl_beforeCurrency);
            this.Controls.Add(this.cmb_beforeCurrency);
            this.Controls.Add(this.lbl_afterConversion);
            this.Controls.Add(this.lbl_beforeConversion);
            this.Controls.Add(this.txt_afterConversion);
            this.Controls.Add(this.txt_beforeConversion);
            this.Name = "ConversionPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConversionPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_live)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_beforeConversion;
        private System.Windows.Forms.TextBox txt_afterConversion;
        private System.Windows.Forms.Label lbl_beforeConversion;
        private System.Windows.Forms.Label lbl_afterConversion;
        private System.Windows.Forms.ComboBox cmb_beforeCurrency;
        private System.Windows.Forms.Label lbl_beforeCurrency;
        private System.Windows.Forms.Label lbl_afterCurrency;
        private System.Windows.Forms.ComboBox cmb_afterCurrency;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.DateTimePicker dtp_Min;
        private System.Windows.Forms.DateTimePicker dtp_Max;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_live;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.DataGridView dgv_live;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterValue;
    }
}

