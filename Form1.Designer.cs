namespace Config
{
    partial class ConfigManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatTemplate = new System.Windows.Forms.Button();
            this.SelectProject = new System.Windows.Forms.Button();
            this.pathLable = new System.Windows.Forms.Label();
            this.CreatBinaryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatTemplate
            // 
            this.CreatTemplate.Location = new System.Drawing.Point(80, 319);
            this.CreatTemplate.Name = "CreatTemplate";
            this.CreatTemplate.Size = new System.Drawing.Size(75, 23);
            this.CreatTemplate.TabIndex = 0;
            this.CreatTemplate.Text = "生成模板";
            this.CreatTemplate.UseVisualStyleBackColor = true;
            this.CreatTemplate.Click += new System.EventHandler(this.CreatTemplate_Click);
            // 
            // SelectProject
            // 
            this.SelectProject.Location = new System.Drawing.Point(80, 104);
            this.SelectProject.Name = "SelectProject";
            this.SelectProject.Size = new System.Drawing.Size(131, 23);
            this.SelectProject.TabIndex = 0;
            this.SelectProject.Text = "选择项目目录";
            this.SelectProject.Click += new System.EventHandler(this.SelectProject_Click);
            // 
            // pathLable
            // 
            this.pathLable.AutoSize = true;
            this.pathLable.Location = new System.Drawing.Point(259, 109);
            this.pathLable.Name = "pathLable";
            this.pathLable.Size = new System.Drawing.Size(131, 12);
            this.pathLable.TabIndex = 1;
            this.pathLable.Text = global::Config.Properties.Settings.Default.PATH;
            // 
            // CreatBinaryBtn
            // 
            this.CreatBinaryBtn.Location = new System.Drawing.Point(240, 319);
            this.CreatBinaryBtn.Name = "CreatBinaryBtn";
            this.CreatBinaryBtn.Size = new System.Drawing.Size(150, 23);
            this.CreatBinaryBtn.TabIndex = 2;
            this.CreatBinaryBtn.Text = "创建c#结构和二进制文件";
            this.CreatBinaryBtn.UseVisualStyleBackColor = true;
            this.CreatBinaryBtn.Click += new System.EventHandler(this.CreatBinaryBtn_Click);
            // 
            // ConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreatBinaryBtn);
            this.Controls.Add(this.pathLable);
            this.Controls.Add(this.SelectProject);
            this.Controls.Add(this.CreatTemplate);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ConfigManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConfigManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatTemplate;
        private System.Windows.Forms.Button SelectProject;
        private System.Windows.Forms.Label pathLable;
        private System.Windows.Forms.Button CreatBinaryBtn;
    }
}

