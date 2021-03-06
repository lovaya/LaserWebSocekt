﻿namespace MyWebSocketServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printing_text_label = new System.Windows.Forms.Label();
            this.waiting_dataGridView = new System.Windows.Forms.DataGridView();
            this.print_code_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridView_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteGridItem_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomStateLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.server_state_label = new System.Windows.Forms.Label();
            this.connected_client_count_label = new System.Windows.Forms.Label();
            this.printingQcode_pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.currentTemplateName_label = new System.Windows.Forms.Label();
            this.loadTemplateBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.markBtn = new System.Windows.Forms.Button();
            this.redLightBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiting_dataGridView)).BeginInit();
            this.gridView_contextMenu.SuspendLayout();
            this.bottomStateLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingQcode_pictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Controls.Add(this.printing_text_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.waiting_dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bottomStateLayout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.printingQcode_pictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.31746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.68254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 297);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // printing_text_label
            // 
            this.printing_text_label.AutoSize = true;
            this.printing_text_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.printing_text_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printing_text_label.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.printing_text_label.Location = new System.Drawing.Point(3, 135);
            this.printing_text_label.Name = "printing_text_label";
            this.printing_text_label.Size = new System.Drawing.Size(393, 88);
            this.printing_text_label.TabIndex = 3;
            this.printing_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waiting_dataGridView
            // 
            this.waiting_dataGridView.AllowUserToAddRows = false;
            this.waiting_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waiting_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.waiting_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waiting_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.print_code_col,
            this.in_time_col,
            this.state_col});
            this.waiting_dataGridView.ContextMenuStrip = this.gridView_contextMenu;
            this.waiting_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waiting_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waiting_dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.waiting_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.waiting_dataGridView.Name = "waiting_dataGridView";
            this.waiting_dataGridView.ReadOnly = true;
            this.waiting_dataGridView.RowHeadersVisible = false;
            this.waiting_dataGridView.RowTemplate.Height = 27;
            this.waiting_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.waiting_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waiting_dataGridView.Size = new System.Drawing.Size(393, 129);
            this.waiting_dataGridView.TabIndex = 4;
            // 
            // print_code_col
            // 
            this.print_code_col.HeaderText = "编码";
            this.print_code_col.Name = "print_code_col";
            this.print_code_col.ReadOnly = true;
            this.print_code_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // in_time_col
            // 
            this.in_time_col.HeaderText = "入队时间";
            this.in_time_col.Name = "in_time_col";
            this.in_time_col.ReadOnly = true;
            this.in_time_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // state_col
            // 
            this.state_col.HeaderText = "状态";
            this.state_col.Name = "state_col";
            this.state_col.ReadOnly = true;
            this.state_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridView_contextMenu
            // 
            this.gridView_contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gridView_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteGridItem_MenuItem});
            this.gridView_contextMenu.Name = "gridView_contextMenu";
            this.gridView_contextMenu.Size = new System.Drawing.Size(109, 28);
            // 
            // deleteGridItem_MenuItem
            // 
            this.deleteGridItem_MenuItem.Name = "deleteGridItem_MenuItem";
            this.deleteGridItem_MenuItem.Size = new System.Drawing.Size(108, 24);
            this.deleteGridItem_MenuItem.Text = "删除";
            this.deleteGridItem_MenuItem.Click += new System.EventHandler(this.deleteGridItem);
            // 
            // bottomStateLayout
            // 
            this.bottomStateLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.bottomStateLayout.ColumnCount = 2;
            this.bottomStateLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.07662F));
            this.bottomStateLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.92338F));
            this.bottomStateLayout.Controls.Add(this.label1, 0, 0);
            this.bottomStateLayout.Controls.Add(this.label2, 0, 1);
            this.bottomStateLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.bottomStateLayout.Controls.Add(this.connected_client_count_label, 1, 1);
            this.bottomStateLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomStateLayout.Location = new System.Drawing.Point(1, 224);
            this.bottomStateLayout.Margin = new System.Windows.Forms.Padding(1);
            this.bottomStateLayout.Name = "bottomStateLayout";
            this.bottomStateLayout.RowCount = 2;
            this.bottomStateLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomStateLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomStateLayout.Size = new System.Drawing.Size(397, 72);
            this.bottomStateLayout.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "打印服务";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "连接数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.server_state_label, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(117, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 33);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // server_state_label
            // 
            this.server_state_label.AutoSize = true;
            this.server_state_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.server_state_label.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.server_state_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.server_state_label.Location = new System.Drawing.Point(3, 0);
            this.server_state_label.Name = "server_state_label";
            this.server_state_label.Size = new System.Drawing.Size(272, 33);
            this.server_state_label.TabIndex = 0;
            this.server_state_label.Text = "- - 未启动 - -";
            this.server_state_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connected_client_count_label
            // 
            this.connected_client_count_label.AutoSize = true;
            this.connected_client_count_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connected_client_count_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.connected_client_count_label.Location = new System.Drawing.Point(120, 37);
            this.connected_client_count_label.Name = "connected_client_count_label";
            this.connected_client_count_label.Size = new System.Drawing.Size(272, 33);
            this.connected_client_count_label.TabIndex = 3;
            this.connected_client_count_label.Text = "当前连接数0";
            this.connected_client_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printingQcode_pictureBox
            // 
            this.printingQcode_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.printingQcode_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printingQcode_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printingQcode_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printingQcode_pictureBox.Location = new System.Drawing.Point(402, 3);
            this.printingQcode_pictureBox.Name = "printingQcode_pictureBox";
            this.printingQcode_pictureBox.Size = new System.Drawing.Size(177, 129);
            this.printingQcode_pictureBox.TabIndex = 6;
            this.printingQcode_pictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.currentTemplateName_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.loadTemplateBtn, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(402, 226);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(177, 68);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // currentTemplateName_label
            // 
            this.currentTemplateName_label.AutoSize = true;
            this.currentTemplateName_label.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.currentTemplateName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTemplateName_label.Location = new System.Drawing.Point(3, 0);
            this.currentTemplateName_label.Name = "currentTemplateName_label";
            this.currentTemplateName_label.Size = new System.Drawing.Size(171, 34);
            this.currentTemplateName_label.TabIndex = 0;
            // 
            // loadTemplateBtn
            // 
            this.loadTemplateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTemplateBtn.Location = new System.Drawing.Point(3, 37);
            this.loadTemplateBtn.Name = "loadTemplateBtn";
            this.loadTemplateBtn.Size = new System.Drawing.Size(171, 28);
            this.loadTemplateBtn.TabIndex = 1;
            this.loadTemplateBtn.Text = "加载模板";
            this.loadTemplateBtn.UseVisualStyleBackColor = true;
            this.loadTemplateBtn.Click += new System.EventHandler(this.loadTemplateBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.markBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.redLightBtn, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(402, 138);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(172, 82);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // markBtn
            // 
            this.markBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.markBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markBtn.ForeColor = System.Drawing.Color.White;
            this.markBtn.Location = new System.Drawing.Point(87, 1);
            this.markBtn.Margin = new System.Windows.Forms.Padding(1);
            this.markBtn.Name = "markBtn";
            this.markBtn.Size = new System.Drawing.Size(84, 80);
            this.markBtn.TabIndex = 1;
            this.markBtn.Text = "标刻";
            this.markBtn.UseVisualStyleBackColor = false;
            this.markBtn.Click += new System.EventHandler(this.markBtn_Click);
            // 
            // redLightBtn
            // 
            this.redLightBtn.BackColor = System.Drawing.Color.Yellow;
            this.redLightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redLightBtn.ForeColor = System.Drawing.Color.Red;
            this.redLightBtn.Location = new System.Drawing.Point(1, 1);
            this.redLightBtn.Margin = new System.Windows.Forms.Padding(1);
            this.redLightBtn.Name = "redLightBtn";
            this.redLightBtn.Size = new System.Drawing.Size(84, 80);
            this.redLightBtn.TabIndex = 0;
            this.redLightBtn.Text = "红光";
            this.redLightBtn.UseVisualStyleBackColor = false;
            this.redLightBtn.Click += new System.EventHandler(this.redLightBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 297);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 344);
            this.MinimumSize = new System.Drawing.Size(400, 344);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "激光打码队列";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closedForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiting_dataGridView)).EndInit();
            this.gridView_contextMenu.ResumeLayout(false);
            this.bottomStateLayout.ResumeLayout(false);
            this.bottomStateLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingQcode_pictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label printing_text_label;
        private System.Windows.Forms.DataGridView waiting_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn print_code_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_col;
        private System.Windows.Forms.TableLayoutPanel bottomStateLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label server_state_label;
        private System.Windows.Forms.Label connected_client_count_label;
        private System.Windows.Forms.PictureBox printingQcode_pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label currentTemplateName_label;
        private System.Windows.Forms.Button loadTemplateBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button redLightBtn;
        private System.Windows.Forms.Button markBtn;
        private System.Windows.Forms.ContextMenuStrip gridView_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteGridItem_MenuItem;
    }
}

