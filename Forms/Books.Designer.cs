namespace knigniMagazin.Forms
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.MainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИздательстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСтеллажаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастныеОграниченияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обложкаКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exzemDataSet = new knigniMagazin.exzemDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltrComboBox = new System.Windows.Forms.ComboBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетTableAdapter = new knigniMagazin.exzemDataSetTableAdapters.ОтчетTableAdapter();
            this.книгиTableAdapter = new knigniMagazin.exzemDataSetTableAdapters.КнигиTableAdapter();
            this.книгиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exzemDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFlow
            // 
            this.MainFlow.AutoScroll = true;
            this.MainFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MainFlow.Controls.Add(this.dataGridView1);
            this.MainFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainFlow.Location = new System.Drawing.Point(0, 51);
            this.MainFlow.Name = "MainFlow";
            this.MainFlow.Size = new System.Drawing.Size(1154, 348);
            this.MainFlow.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКнигиDataGridViewTextBoxColumn,
            this.iDИздательстваDataGridViewTextBoxColumn,
            this.iDЖанраDataGridViewTextBoxColumn,
            this.iDСтеллажаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.возрастныеОграниченияDataGridViewTextBoxColumn,
            this.количествоСтраницDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.обложкаКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.книгиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1146, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDКнигиDataGridViewTextBoxColumn
            // 
            this.iDКнигиDataGridViewTextBoxColumn.DataPropertyName = "IDКниги";
            this.iDКнигиDataGridViewTextBoxColumn.HeaderText = "IDКниги";
            this.iDКнигиDataGridViewTextBoxColumn.Name = "iDКнигиDataGridViewTextBoxColumn";
            this.iDКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDИздательстваDataGridViewTextBoxColumn
            // 
            this.iDИздательстваDataGridViewTextBoxColumn.DataPropertyName = "IDИздательства";
            this.iDИздательстваDataGridViewTextBoxColumn.HeaderText = "IDИздательства";
            this.iDИздательстваDataGridViewTextBoxColumn.Name = "iDИздательстваDataGridViewTextBoxColumn";
            // 
            // iDЖанраDataGridViewTextBoxColumn
            // 
            this.iDЖанраDataGridViewTextBoxColumn.DataPropertyName = "IDЖанра";
            this.iDЖанраDataGridViewTextBoxColumn.HeaderText = "IDЖанра";
            this.iDЖанраDataGridViewTextBoxColumn.Name = "iDЖанраDataGridViewTextBoxColumn";
            // 
            // iDСтеллажаDataGridViewTextBoxColumn
            // 
            this.iDСтеллажаDataGridViewTextBoxColumn.DataPropertyName = "IDСтеллажа";
            this.iDСтеллажаDataGridViewTextBoxColumn.HeaderText = "IDСтеллажа";
            this.iDСтеллажаDataGridViewTextBoxColumn.Name = "iDСтеллажаDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // возрастныеОграниченияDataGridViewTextBoxColumn
            // 
            this.возрастныеОграниченияDataGridViewTextBoxColumn.DataPropertyName = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.HeaderText = "ВозрастныеОграничения";
            this.возрастныеОграниченияDataGridViewTextBoxColumn.Name = "возрастныеОграниченияDataGridViewTextBoxColumn";
            // 
            // количествоСтраницDataGridViewTextBoxColumn
            // 
            this.количествоСтраницDataGridViewTextBoxColumn.DataPropertyName = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.HeaderText = "КоличествоСтраниц";
            this.количествоСтраницDataGridViewTextBoxColumn.Name = "количествоСтраницDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // обложкаКнигиDataGridViewTextBoxColumn
            // 
            this.обложкаКнигиDataGridViewTextBoxColumn.DataPropertyName = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.HeaderText = "ОбложкаКниги";
            this.обложкаКнигиDataGridViewTextBoxColumn.Name = "обложкаКнигиDataGridViewTextBoxColumn";
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.exzemDataSet;
            // 
            // exzemDataSet
            // 
            this.exzemDataSet.DataSetName = "exzemDataSet";
            this.exzemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.Reg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 67);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.Reg.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg.Location = new System.Drawing.Point(29, 22);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(163, 33);
            this.Reg.TabIndex = 6;
            this.Reg.Text = "Back";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.FiltrComboBox);
            this.panel1.Controls.Add(this.SortComboBox);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 51);
            this.panel1.TabIndex = 3;
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.книгиBindingSource, "Наименование", true));
            this.FiltrComboBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrComboBox.FormattingEnabled = true;
            this.FiltrComboBox.Items.AddRange(new object[] {
            "Колобок",
            "Два капитана",
            "Три Мушкетера"});
            this.FiltrComboBox.Location = new System.Drawing.Point(523, 5);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(200, 41);
            this.FiltrComboBox.TabIndex = 1;
            this.FiltrComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrComboBox_SelectedIndexChanged_1);
            // 
            // SortComboBox
            // 
            this.SortComboBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.SortComboBox.Location = new System.Drawing.Point(320, 6);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(187, 41);
            this.SortComboBox.TabIndex = 1;
            this.SortComboBox.Text = "Сортировка";
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged_1);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(293, 41);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Введите для поиска";
            // 
            // отчетBindingSource
            // 
            this.отчетBindingSource.DataMember = "Отчет";
            this.отчетBindingSource.DataSource = this.exzemDataSet;
            // 
            // отчетTableAdapter
            // 
            this.отчетTableAdapter.ClearBeforeFill = true;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // книгиBindingSource1
            // 
            this.книгиBindingSource1.DataMember = "Книги";
            this.книгиBindingSource1.DataSource = this.exzemDataSet;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 466);
            this.Controls.Add(this.MainFlow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.MainFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exzemDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FiltrComboBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private exzemDataSet exzemDataSet;
        private System.Windows.Forms.BindingSource отчетBindingSource;
        private exzemDataSetTableAdapters.ОтчетTableAdapter отчетTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private exzemDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЖанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСтеллажаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастныеОграниченияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обложкаКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource книгиBindingSource1;
        private System.Windows.Forms.Button Reg;
    }
}