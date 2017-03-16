namespace WindowsFormsApplication1
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
            this.btnAddPath = new System.Windows.Forms.Button();
            this.lbPathList = new System.Windows.Forms.ListBox();
            this.btnDeletePaths = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPath
            // 
            this.btnAddPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPath.Location = new System.Drawing.Point(3, 3);
            this.btnAddPath.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(169, 45);
            this.btnAddPath.TabIndex = 0;
            this.btnAddPath.Text = "添加虚拟路径";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // lbPathList
            // 
            this.lbPathList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPathList.FormattingEnabled = true;
            this.lbPathList.HorizontalScrollbar = true;
            this.lbPathList.ItemHeight = 12;
            this.lbPathList.Location = new System.Drawing.Point(3, 3);
            this.lbPathList.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbPathList.Name = "lbPathList";
            this.lbPathList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPathList.Size = new System.Drawing.Size(350, 237);
            this.lbPathList.TabIndex = 1;
            // 
            // btnDeletePaths
            // 
            this.btnDeletePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletePaths.Location = new System.Drawing.Point(178, 3);
            this.btnDeletePaths.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnDeletePaths.Name = "btnDeletePaths";
            this.btnDeletePaths.Size = new System.Drawing.Size(169, 45);
            this.btnDeletePaths.TabIndex = 2;
            this.btnDeletePaths.Text = "删除虚拟路径";
            this.btnDeletePaths.UseVisualStyleBackColor = true;
            this.btnDeletePaths.Click += new System.EventHandler(this.btnDeletePaths_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbPathList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.10749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.89251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 300);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeletePaths, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddPath, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 246);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(100, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "文件服务器虚拟路径配置工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.ListBox lbPathList;
        private System.Windows.Forms.Button btnDeletePaths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

