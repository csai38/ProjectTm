namespace ProjectTm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.eppmConnectBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.eppmStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectTree = new System.Windows.Forms.TreeView();
            this.getMilstonesEppm = new System.Windows.Forms.Button();
            this.milstoneDgv = new ADGV.AdvancedDataGridView();
            this.taskCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskADateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskFDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCalcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ptmDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptmDs = new ProjectTm.PtmDs();
            this.pcm_milstonesTableAdapter = new ProjectTm.PtmDsTableAdapters.pcm_milstonesTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milstoneDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmDsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eppmConnectBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // eppmConnectBtn
            // 
            this.eppmConnectBtn.Image = global::ProjectTm.Properties.Resources.ppm;
            this.eppmConnectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eppmConnectBtn.Name = "eppmConnectBtn";
            this.eppmConnectBtn.Size = new System.Drawing.Size(143, 22);
            this.eppmConnectBtn.Text = "Подключиться EPPM";
            this.eppmConnectBtn.Click += new System.EventHandler(this.eppmConnectBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eppmStatusConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // eppmStatusConnection
            // 
            this.eppmStatusConnection.Name = "eppmStatusConnection";
            this.eppmStatusConnection.Size = new System.Drawing.Size(105, 17);
            this.eppmStatusConnection.Text = "EPPM Отключено";
            // 
            // projectTree
            // 
            this.projectTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projectTree.CheckBoxes = true;
            this.projectTree.Enabled = false;
            this.projectTree.Location = new System.Drawing.Point(12, 28);
            this.projectTree.Name = "projectTree";
            this.projectTree.Size = new System.Drawing.Size(280, 529);
            this.projectTree.TabIndex = 2;
            this.projectTree.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectTree_BeforeCheck);
            this.projectTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.projectTree_AfterCheck);
            this.projectTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTree_NodeMouseDoubleClick);
            // 
            // getMilstonesEppm
            // 
            this.getMilstonesEppm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getMilstonesEppm.Location = new System.Drawing.Point(150, 563);
            this.getMilstonesEppm.Name = "getMilstonesEppm";
            this.getMilstonesEppm.Size = new System.Drawing.Size(142, 23);
            this.getMilstonesEppm.TabIndex = 4;
            this.getMilstonesEppm.Text = "Обновить список вех";
            this.getMilstonesEppm.UseVisualStyleBackColor = true;
            this.getMilstonesEppm.Click += new System.EventHandler(this.getMilstonesEppm_Click);
            // 
            // milstoneDgv
            // 
            this.milstoneDgv.AllowUserToAddRows = false;
            this.milstoneDgv.AllowUserToDeleteRows = false;
            this.milstoneDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.milstoneDgv.AutoGenerateColumns = false;
            this.milstoneDgv.AutoGenerateContextFilters = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.milstoneDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.milstoneDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.milstoneDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskCodeDataGridViewTextBoxColumn,
            this.taskTypeDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskADateDataGridViewTextBoxColumn,
            this.taskFDateDataGridViewTextBoxColumn,
            this.isCalcDataGridViewTextBoxColumn});
            this.milstoneDgv.DataSource = this.ptmDsBindingSource;
            this.milstoneDgv.DateWithTime = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.milstoneDgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.milstoneDgv.Location = new System.Drawing.Point(302, 29);
            this.milstoneDgv.Name = "milstoneDgv";
            this.milstoneDgv.RowHeadersVisible = false;
            this.milstoneDgv.Size = new System.Drawing.Size(667, 200);
            this.milstoneDgv.TabIndex = 5;
            this.milstoneDgv.TimeFilter = false;
            this.milstoneDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.milstoneDgv_CellFormatting);
            // 
            // taskCodeDataGridViewTextBoxColumn
            // 
            this.taskCodeDataGridViewTextBoxColumn.DataPropertyName = "taskCode";
            this.taskCodeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.taskCodeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskCodeDataGridViewTextBoxColumn.Name = "taskCodeDataGridViewTextBoxColumn";
            this.taskCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taskCodeDataGridViewTextBoxColumn.ToolTipText = "Код вехи в проекте";
            // 
            // taskTypeDataGridViewTextBoxColumn
            // 
            this.taskTypeDataGridViewTextBoxColumn.DataPropertyName = "taskType";
            this.taskTypeDataGridViewTextBoxColumn.HeaderText = "Тип вехи";
            this.taskTypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskTypeDataGridViewTextBoxColumn.Name = "taskTypeDataGridViewTextBoxColumn";
            this.taskTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "taskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taskNameDataGridViewTextBoxColumn.ToolTipText = "Наименование вехи";
            // 
            // taskADateDataGridViewTextBoxColumn
            // 
            this.taskADateDataGridViewTextBoxColumn.DataPropertyName = "taskADate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.taskADateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskADateDataGridViewTextBoxColumn.HeaderText = "Дата утв.";
            this.taskADateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskADateDataGridViewTextBoxColumn.Name = "taskADateDataGridViewTextBoxColumn";
            this.taskADateDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskADateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taskADateDataGridViewTextBoxColumn.ToolTipText = "Утвержденная дата";
            // 
            // taskFDateDataGridViewTextBoxColumn
            // 
            this.taskFDateDataGridViewTextBoxColumn.DataPropertyName = "taskFDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.taskFDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.taskFDateDataGridViewTextBoxColumn.HeaderText = "Дата пр.";
            this.taskFDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskFDateDataGridViewTextBoxColumn.Name = "taskFDateDataGridViewTextBoxColumn";
            this.taskFDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskFDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taskFDateDataGridViewTextBoxColumn.ToolTipText = "Прогнозная дата";
            // 
            // isCalcDataGridViewTextBoxColumn
            // 
            this.isCalcDataGridViewTextBoxColumn.DataPropertyName = "isCalc";
            this.isCalcDataGridViewTextBoxColumn.HeaderText = "РКП";
            this.isCalcDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.isCalcDataGridViewTextBoxColumn.Name = "isCalcDataGridViewTextBoxColumn";
            this.isCalcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isCalcDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.isCalcDataGridViewTextBoxColumn.ToolTipText = "Включить в расчет критических путей";
            // 
            // ptmDsBindingSource
            // 
            this.ptmDsBindingSource.DataMember = "pcm_milstones";
            this.ptmDsBindingSource.DataSource = this.ptmDs;
            // 
            // ptmDs
            // 
            this.ptmDs.DataSetName = "PtmDs";
            this.ptmDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcm_milstonesTableAdapter
            // 
            this.pcm_milstonesTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(299, 235);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.advancedDataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.advancedDataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(673, 351);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(524, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сформировать задачи";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Критические задачи";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.advancedDataGridView1.Location = new System.Drawing.Point(3, 33);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(667, 139);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Суб-критические задачи";
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.DateWithTime = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.advancedDataGridView2.Location = new System.Drawing.Point(3, 21);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.advancedDataGridView2.Size = new System.Drawing.Size(667, 148);
            this.advancedDataGridView2.TabIndex = 0;
            this.advancedDataGridView2.TimeFilter = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.milstoneDgv);
            this.Controls.Add(this.getMilstonesEppm);
            this.Controls.Add(this.projectTree);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "ИС Управление исполнением";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milstoneDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmDsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmDs)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton eppmConnectBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel eppmStatusConnection;
        private System.Windows.Forms.TreeView projectTree;
        private System.Windows.Forms.Button getMilstonesEppm;
        private System.Windows.Forms.BindingSource ptmDsBindingSource;
        private PtmDs ptmDs;
        private PtmDsTableAdapters.pcm_milstonesTableAdapter pcm_milstonesTableAdapter;
        private ADGV.AdvancedDataGridView milstoneDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskADateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskFDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCalcDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

