namespace kitaptakipapp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datashow = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTakipDataSet = new kitaptakipapp.kitapTakipDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtwriter = new System.Windows.Forms.TextBox();
            this.cbkind = new System.Windows.Forms.ComboBox();
            this.kitaplarimTableAdapter = new kitaptakipapp.kitapTakipDataSetTableAdapters.kitaplarimTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BOOKNUM = new System.Windows.Forms.Label();
            this.PAGENUM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // datashow
            // 
            this.datashow.AllowUserToOrderColumns = true;
            this.datashow.AutoGenerateColumns = false;
            this.datashow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datashow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn});
            this.datashow.DataSource = this.kitaplarimBindingSource;
            this.datashow.Enabled = false;
            this.datashow.Location = new System.Drawing.Point(520, 12);
            this.datashow.Name = "datashow";
            this.datashow.RowHeadersWidth = 49;
            this.datashow.RowTemplate.Height = 24;
            this.datashow.Size = new System.Drawing.Size(596, 519);
            this.datashow.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.pageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.Width = 75;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kindDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            this.kindDataGridViewTextBoxColumn.Width = 150;
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "Writer";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.writerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.writerDataGridViewTextBoxColumn.HeaderText = "Writer";
            this.writerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            this.writerDataGridViewTextBoxColumn.Width = 160;
            // 
            // kitaplarimBindingSource
            // 
            this.kitaplarimBindingSource.DataMember = "kitaplarim";
            this.kitaplarimBindingSource.DataSource = this.kitapTakipDataSet;
            // 
            // kitapTakipDataSet
            // 
            this.kitapTakipDataSet.DataSetName = "kitapTakipDataSet";
            this.kitapTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Heading", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(46, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Sitka Heading", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(266, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbook
            // 
            this.txtbook.Font = new System.Drawing.Font("Trebuchet MS", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbook.Location = new System.Drawing.Point(102, 64);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(125, 24);
            this.txtbook.TabIndex = 3;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Trebuchet MS", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnum.Location = new System.Drawing.Point(307, 61);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(125, 24);
            this.txtnum.TabIndex = 4;
            // 
            // txtwriter
            // 
            this.txtwriter.Font = new System.Drawing.Font("Trebuchet MS", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtwriter.Location = new System.Drawing.Point(102, 125);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(125, 24);
            this.txtwriter.TabIndex = 5;
            // 
            // cbkind
            // 
            this.cbkind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkind.Font = new System.Drawing.Font("Trebuchet MS", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbkind.FormattingEnabled = true;
            this.cbkind.Location = new System.Drawing.Point(307, 123);
            this.cbkind.Name = "cbkind";
            this.cbkind.Size = new System.Drawing.Size(125, 26);
            this.cbkind.TabIndex = 6;
            this.cbkind.UseWaitCursor = true;
            // 
            // kitaplarimTableAdapter
            // 
            this.kitaplarimTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Writer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(239, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Page";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(239, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kind";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BOOKNUM
            // 
            this.BOOKNUM.BackColor = System.Drawing.Color.Transparent;
            this.BOOKNUM.Font = new System.Drawing.Font("Trebuchet MS", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BOOKNUM.Location = new System.Drawing.Point(289, 315);
            this.BOOKNUM.Name = "BOOKNUM";
            this.BOOKNUM.Size = new System.Drawing.Size(143, 40);
            this.BOOKNUM.TabIndex = 13;
            this.BOOKNUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAGENUM
            // 
            this.PAGENUM.BackColor = System.Drawing.Color.Transparent;
            this.PAGENUM.Font = new System.Drawing.Font("Trebuchet MS", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PAGENUM.Location = new System.Drawing.Point(84, 315);
            this.PAGENUM.Name = "PAGENUM";
            this.PAGENUM.Size = new System.Drawing.Size(143, 40);
            this.PAGENUM.TabIndex = 14;
            this.PAGENUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Book Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Page Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Trebuchet MS", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearch.Location = new System.Drawing.Point(152, 392);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(193, 24);
            this.txtsearch.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.Font = new System.Drawing.Font("Sitka Heading", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(89, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 65);
            this.button3.TabIndex = 18;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1128, 543);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PAGENUM);
            this.Controls.Add(this.BOOKNUM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbkind);
            this.Controls.Add(this.txtwriter);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datashow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Book Tracking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapTakipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datashow;
        private kitapTakipDataSet kitapTakipDataSet;
        private System.Windows.Forms.BindingSource kitaplarimBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtwriter;
        private System.Windows.Forms.ComboBox cbkind;
        private kitapTakipDataSetTableAdapters.kitaplarimTableAdapter kitaplarimTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BOOKNUM;
        private System.Windows.Forms.Label PAGENUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button3;
    }
}

