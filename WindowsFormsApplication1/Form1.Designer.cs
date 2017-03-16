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
            this.SuspendLayout();
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(12, 218);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(124, 23);
            this.btnAddPath.TabIndex = 0;
            this.btnAddPath.Text = "添加虚拟路径";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // lbPathList
            // 
            this.lbPathList.FormattingEnabled = true;
            this.lbPathList.ItemHeight = 12;
            this.lbPathList.Location = new System.Drawing.Point(12, 18);
            this.lbPathList.Name = "lbPathList";
            this.lbPathList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPathList.Size = new System.Drawing.Size(260, 184);
            this.lbPathList.TabIndex = 1;
            // 
            // btnDeletePaths
            // 
            this.btnDeletePaths.Location = new System.Drawing.Point(142, 218);
            this.btnDeletePaths.Name = "btnDeletePaths";
            this.btnDeletePaths.Size = new System.Drawing.Size(130, 23);
            this.btnDeletePaths.TabIndex = 2;
            this.btnDeletePaths.Text = "删除虚拟路径";
            this.btnDeletePaths.UseVisualStyleBackColor = true;
            this.btnDeletePaths.Click += new System.EventHandler(this.btnDeletePaths_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDeletePaths);
            this.Controls.Add(this.lbPathList);
            this.Controls.Add(this.btnAddPath);
            this.Name = "Form1";
            this.Text = "文件服务器虚拟路径配置工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.ListBox lbPathList;
        private System.Windows.Forms.Button btnDeletePaths;
    }
}

