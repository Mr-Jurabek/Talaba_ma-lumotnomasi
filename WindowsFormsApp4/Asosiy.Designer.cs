namespace WindowsFormsApp4
{
    partial class Asosiy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.talabaDataSet = new talaba.talabaDataSet();
            this.talabaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talabaTableAdapter = new talaba.talabaDataSetTableAdapters.talabaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jinsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugilgankuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yashashmanziliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talabaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talabaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 46);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(663, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(727, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.ismDataGridViewTextBoxColumn,
            this.sharifDataGridViewTextBoxColumn,
            this.jinsiDataGridViewTextBoxColumn,
            this.tugilgankuniDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telnomerDataGridViewTextBoxColumn,
            this.yashashmanziliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.talabaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 214);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(518, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Qo‘shish";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(88, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "O‘chirish";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 59);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DarkViolet;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(307, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Yangilash";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // talabaDataSet
            // 
            this.talabaDataSet.DataSetName = "talabaDataSet";
            this.talabaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talabaBindingSource
            // 
            this.talabaBindingSource.DataMember = "talaba";
            this.talabaBindingSource.DataSource = this.talabaDataSet;
            // 
            // talabaTableAdapter
            // 
            this.talabaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            this.familiyaDataGridViewTextBoxColumn.Width = 104;
            // 
            // ismDataGridViewTextBoxColumn
            // 
            this.ismDataGridViewTextBoxColumn.DataPropertyName = "ism";
            this.ismDataGridViewTextBoxColumn.HeaderText = "Ism";
            this.ismDataGridViewTextBoxColumn.Name = "ismDataGridViewTextBoxColumn";
            this.ismDataGridViewTextBoxColumn.Width = 64;
            // 
            // sharifDataGridViewTextBoxColumn
            // 
            this.sharifDataGridViewTextBoxColumn.DataPropertyName = "sharif";
            this.sharifDataGridViewTextBoxColumn.HeaderText = "Otasining ismi";
            this.sharifDataGridViewTextBoxColumn.Name = "sharifDataGridViewTextBoxColumn";
            this.sharifDataGridViewTextBoxColumn.Width = 152;
            // 
            // jinsiDataGridViewTextBoxColumn
            // 
            this.jinsiDataGridViewTextBoxColumn.DataPropertyName = "jinsi";
            this.jinsiDataGridViewTextBoxColumn.HeaderText = "Jinsi";
            this.jinsiDataGridViewTextBoxColumn.Name = "jinsiDataGridViewTextBoxColumn";
            this.jinsiDataGridViewTextBoxColumn.Width = 72;
            // 
            // tugilgankuniDataGridViewTextBoxColumn
            // 
            this.tugilgankuniDataGridViewTextBoxColumn.DataPropertyName = "tugilgan_kuni";
            this.tugilgankuniDataGridViewTextBoxColumn.HeaderText = "Tug‘ilgan kuni";
            this.tugilgankuniDataGridViewTextBoxColumn.Name = "tugilgankuniDataGridViewTextBoxColumn";
            this.tugilgankuniDataGridViewTextBoxColumn.Width = 153;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 82;
            // 
            // telnomerDataGridViewTextBoxColumn
            // 
            this.telnomerDataGridViewTextBoxColumn.DataPropertyName = "tel_nomer";
            this.telnomerDataGridViewTextBoxColumn.HeaderText = "Telefon nomer";
            this.telnomerDataGridViewTextBoxColumn.Name = "telnomerDataGridViewTextBoxColumn";
            this.telnomerDataGridViewTextBoxColumn.Width = 159;
            // 
            // yashashmanziliDataGridViewTextBoxColumn
            // 
            this.yashashmanziliDataGridViewTextBoxColumn.DataPropertyName = "yashash_manzili";
            this.yashashmanziliDataGridViewTextBoxColumn.HeaderText = "Yashash manzili";
            this.yashashmanziliDataGridViewTextBoxColumn.Name = "yashashmanziliDataGridViewTextBoxColumn";
            this.yashashmanziliDataGridViewTextBoxColumn.Width = 155;
            // 
            // Asosiy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(791, 405);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Asosiy";
            this.Text = "Asosiy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Asosiy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.talabaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talabaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private talaba.talabaDataSet talabaDataSet;
        private System.Windows.Forms.BindingSource talabaBindingSource;
        private talaba.talabaDataSetTableAdapters.talabaTableAdapter talabaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jinsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugilgankuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yashashmanziliDataGridViewTextBoxColumn;
    }
}