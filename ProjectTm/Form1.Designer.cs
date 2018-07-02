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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.eppmStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectTree = new System.Windows.Forms.TreeView();
            this.getMilstonesEppm = new System.Windows.Forms.Button();
            this.milstoneDgv = new ADGV.AdvancedDataGridView();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eppmConnectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.calcCriticalTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.eppmSyncTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milstoneDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eppmConnectBtn,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.projectTree.Location = new System.Drawing.Point(12, 44);
            this.projectTree.Name = "projectTree";
            this.projectTree.Size = new System.Drawing.Size(280, 513);
            this.projectTree.TabIndex = 2;
            this.projectTree.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectTree_BeforeCheck);
            this.projectTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.projectTree_AfterCheck);
            this.projectTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTree_NodeMouseDoubleClick);
            // 
            // getMilstonesEppm
            // 
            this.getMilstonesEppm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getMilstonesEppm.Location = new System.Drawing.Point(164, 563);
            this.getMilstonesEppm.Name = "getMilstonesEppm";
            this.getMilstonesEppm.Size = new System.Drawing.Size(128, 23);
            this.getMilstonesEppm.TabIndex = 4;
            this.getMilstonesEppm.Text = "Синхронизировать с EPPM";
            this.getMilstonesEppm.UseVisualStyleBackColor = true;
            this.getMilstonesEppm.Click += new System.EventHandler(this.getMilstonesEppm_Click);
            // 
            // milstoneDgv
            // 
            this.milstoneDgv.AllowUserToAddRows = false;
            this.milstoneDgv.AllowUserToDeleteRows = false;
            this.milstoneDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.milstoneDgv.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.milstoneDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.milstoneDgv.Location = new System.Drawing.Point(302, 44);
            this.milstoneDgv.Name = "milstoneDgv";
            this.milstoneDgv.RowHeadersVisible = false;
            this.milstoneDgv.Size = new System.Drawing.Size(667, 200);
            this.milstoneDgv.TabIndex = 5;
            this.milstoneDgv.TimeFilter = false;
            this.milstoneDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.milstoneDgv_CellFormatting);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.advancedDataGridView1.Location = new System.Drawing.Point(302, 263);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(667, 323);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список событий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список поручений и критических задач";
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eppmSyncTool,
            this.addNewTask,
            this.calcCriticalTasks});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripDropDownButton1.Text = "Операции";
            // 
            // addNewTask
            // 
            this.addNewTask.Name = "addNewTask";
            this.addNewTask.Size = new System.Drawing.Size(248, 22);
            this.addNewTask.Text = "Создать поручение";
            // 
            // calcCriticalTasks
            // 
            this.calcCriticalTasks.Name = "calcCriticalTasks";
            this.calcCriticalTasks.Size = new System.Drawing.Size(248, 22);
            this.calcCriticalTasks.Text = "Рассчитать критические задачи";
            // 
            // eppmSyncTool
            // 
            this.eppmSyncTool.Name = "eppmSyncTool";
            this.eppmSyncTool.Size = new System.Drawing.Size(248, 22);
            this.eppmSyncTool.Text = "Синхронизация EPPM";
            this.eppmSyncTool.Click += new System.EventHandler(this.eppmSyncTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.milstoneDgv);
            this.Controls.Add(this.advancedDataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
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
        private ADGV.AdvancedDataGridView milstoneDgv;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addNewTask;
        private System.Windows.Forms.ToolStripMenuItem calcCriticalTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem eppmSyncTool;
    }
}

