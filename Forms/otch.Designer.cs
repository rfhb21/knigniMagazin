namespace knigniMagazin.Forms
{
    partial class otch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.exzemDataSet = new knigniMagazin.exzemDataSet();
            this.отчетBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отчетTableAdapter = new knigniMagazin.exzemDataSetTableAdapters.ОтчетTableAdapter();
            this.iDОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогЗаМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exzemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.отчетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 353);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 68);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список отчетов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОтчетаDataGridViewTextBoxColumn,
            this.iDПродажиDataGridViewTextBoxColumn,
            this.датаОтчетаDataGridViewTextBoxColumn,
            this.итогЗаМесяцDataGridViewTextBoxColumn,
            this.номерОтчетаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.отчетBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 157);
            this.dataGridView2.TabIndex = 6;
            // 
            // exzemDataSet
            // 
            this.exzemDataSet.DataSetName = "exzemDataSet";
            this.exzemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетBindingSource1
            // 
            this.отчетBindingSource1.DataMember = "Отчет";
            this.отчетBindingSource1.DataSource = this.exzemDataSet;
            // 
            // отчетTableAdapter
            // 
            this.отчетTableAdapter.ClearBeforeFill = true;
            // 
            // iDОтчетаDataGridViewTextBoxColumn
            // 
            this.iDОтчетаDataGridViewTextBoxColumn.DataPropertyName = "IDОтчета";
            this.iDОтчетаDataGridViewTextBoxColumn.HeaderText = "IDОтчета";
            this.iDОтчетаDataGridViewTextBoxColumn.Name = "iDОтчетаDataGridViewTextBoxColumn";
            this.iDОтчетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDПродажиDataGridViewTextBoxColumn
            // 
            this.iDПродажиDataGridViewTextBoxColumn.DataPropertyName = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.HeaderText = "IDПродажи";
            this.iDПродажиDataGridViewTextBoxColumn.Name = "iDПродажиDataGridViewTextBoxColumn";
            // 
            // датаОтчетаDataGridViewTextBoxColumn
            // 
            this.датаОтчетаDataGridViewTextBoxColumn.DataPropertyName = "ДатаОтчета";
            this.датаОтчетаDataGridViewTextBoxColumn.HeaderText = "ДатаОтчета";
            this.датаОтчетаDataGridViewTextBoxColumn.Name = "датаОтчетаDataGridViewTextBoxColumn";
            // 
            // итогЗаМесяцDataGridViewTextBoxColumn
            // 
            this.итогЗаМесяцDataGridViewTextBoxColumn.DataPropertyName = "ИтогЗаМесяц";
            this.итогЗаМесяцDataGridViewTextBoxColumn.HeaderText = "ИтогЗаМесяц";
            this.итогЗаМесяцDataGridViewTextBoxColumn.Name = "итогЗаМесяцDataGridViewTextBoxColumn";
            // 
            // номерОтчетаDataGridViewTextBoxColumn
            // 
            this.номерОтчетаDataGridViewTextBoxColumn.DataPropertyName = "НомерОтчета";
            this.номерОтчетаDataGridViewTextBoxColumn.HeaderText = "НомерОтчета";
            this.номерОтчетаDataGridViewTextBoxColumn.Name = "номерОтчетаDataGridViewTextBoxColumn";
            // 
            // otch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 419);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "otch";
            this.Text = "otch";
            this.Load += new System.EventHandler(this.otch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exzemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource отчетBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private exzemDataSet exzemDataSet;
        private System.Windows.Forms.BindingSource отчетBindingSource1;
        private exzemDataSetTableAdapters.ОтчетTableAdapter отчетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогЗаМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтчетаDataGridViewTextBoxColumn;
    }
}