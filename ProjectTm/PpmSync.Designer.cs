namespace ProjectTm
{
    partial class PpmSync
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
            this.projectTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbsIsSync = new System.Windows.Forms.CheckBox();
            this.taskIsSync = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.syncProjectsBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectTree
            // 
            this.projectTree.CheckBoxes = true;
            this.projectTree.Location = new System.Drawing.Point(6, 19);
            this.projectTree.Name = "projectTree";
            this.projectTree.Size = new System.Drawing.Size(316, 184);
            this.projectTree.TabIndex = 0;
            this.projectTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.projectTree_AfterCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.taskIsSync);
            this.groupBox1.Controls.Add(this.wbsIsSync);
            this.groupBox1.Location = new System.Drawing.Point(347, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры синхронизации";
            // 
            // wbsIsSync
            // 
            this.wbsIsSync.AutoSize = true;
            this.wbsIsSync.Location = new System.Drawing.Point(16, 19);
            this.wbsIsSync.Name = "wbsIsSync";
            this.wbsIsSync.Size = new System.Drawing.Size(223, 17);
            this.wbsIsSync.TabIndex = 0;
            this.wbsIsSync.Text = "Иерархическая структура работ (WBS)";
            this.wbsIsSync.UseVisualStyleBackColor = true;
            // 
            // taskIsSync
            // 
            this.taskIsSync.AutoSize = true;
            this.taskIsSync.Location = new System.Drawing.Point(16, 42);
            this.taskIsSync.Name = "taskIsSync";
            this.taskIsSync.Size = new System.Drawing.Size(154, 17);
            this.taskIsSync.TabIndex = 2;
            this.taskIsSync.Text = "Задачи и связи проектов";
            this.taskIsSync.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(7, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коды работ";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код Ответственного:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код Исполнителя:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(123, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код внешней задачи:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // syncProjectsBtn
            // 
            this.syncProjectsBtn.Location = new System.Drawing.Point(347, 199);
            this.syncProjectsBtn.Name = "syncProjectsBtn";
            this.syncProjectsBtn.Size = new System.Drawing.Size(313, 23);
            this.syncProjectsBtn.TabIndex = 2;
            this.syncProjectsBtn.Text = "Синхронизировать";
            this.syncProjectsBtn.UseVisualStyleBackColor = true;
            this.syncProjectsBtn.Click += new System.EventHandler(this.syncProjectsBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.projectTree);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 209);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дерево проектов";
            // 
            // PpmSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 234);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.syncProjectsBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "PpmSync";
            this.Text = "Синхронизация ";
            this.Load += new System.EventHandler(this.PpmSync_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView projectTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox taskIsSync;
        private System.Windows.Forms.CheckBox wbsIsSync;
        private System.Windows.Forms.Button syncProjectsBtn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}