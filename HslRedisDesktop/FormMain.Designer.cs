namespace HslRedisDesktop
{
	partial class FormMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip_db = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip_redis = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip_class = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.新增KeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.刷新数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.过滤KeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除所有KeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.服务器状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.控制台操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.刷新所有数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改连接配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.断开当前连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除当前链接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.展开所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip_db.SuspendLayout();
			this.contextMenuStrip_redis.SuspendLayout();
			this.contextMenuStrip_class.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.contactToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1143, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// sourceCodeToolStripMenuItem
			// 
			this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
			this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
			this.sourceCodeToolStripMenuItem.Text = "SourceCode";
			// 
			// contactToolStripMenuItem
			// 
			this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
			this.contactToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
			this.contactToolStripMenuItem.Text = "Contact";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 651);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
			this.toolStripStatusLabel1.Text = "准备就绪";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(1143, 626);
			this.splitContainer1.SplitterDistance = 330;
			this.splitContainer1.TabIndex = 3;
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.Location = new System.Drawing.Point(3, 29);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(324, 594);
			this.treeView1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器列表：";
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(809, 626);
			this.panel1.TabIndex = 0;
			// 
			// contextMenuStrip_db
			// 
			this.contextMenuStrip_db.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增KeyToolStripMenuItem,
            this.刷新数据ToolStripMenuItem,
            this.过滤KeyToolStripMenuItem,
            this.清除所有KeyToolStripMenuItem});
			this.contextMenuStrip_db.Name = "contextMenuStrip1";
			this.contextMenuStrip_db.Size = new System.Drawing.Size(146, 92);
			// 
			// contextMenuStrip_redis
			// 
			this.contextMenuStrip_redis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器状态ToolStripMenuItem,
            this.控制台操作ToolStripMenuItem,
            this.刷新所有数据ToolStripMenuItem,
            this.修改连接配置ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.断开当前连接ToolStripMenuItem,
            this.删除当前链接ToolStripMenuItem});
			this.contextMenuStrip_redis.Name = "contextMenuStrip_redis";
			this.contextMenuStrip_redis.Size = new System.Drawing.Size(181, 180);
			// 
			// contextMenuStrip_class
			// 
			this.contextMenuStrip_class.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.展开所有ToolStripMenuItem});
			this.contextMenuStrip_class.Name = "contextMenuStrip_class";
			this.contextMenuStrip_class.Size = new System.Drawing.Size(125, 26);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Image = global::HslRedisDesktop.Properties.Resources.action_add_16xLG;
			this.button1.Location = new System.Drawing.Point(296, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 23);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// 新增KeyToolStripMenuItem
			// 
			this.新增KeyToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.action_add_16xLG;
			this.新增KeyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.新增KeyToolStripMenuItem.Name = "新增KeyToolStripMenuItem";
			this.新增KeyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.新增KeyToolStripMenuItem.Text = "新增Key";
			// 
			// 刷新数据ToolStripMenuItem
			// 
			this.刷新数据ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.Activity_16xLG;
			this.刷新数据ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.刷新数据ToolStripMenuItem.Name = "刷新数据ToolStripMenuItem";
			this.刷新数据ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.刷新数据ToolStripMenuItem.Text = "刷新数据";
			// 
			// 过滤KeyToolStripMenuItem
			// 
			this.过滤KeyToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.filter;
			this.过滤KeyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.过滤KeyToolStripMenuItem.Name = "过滤KeyToolStripMenuItem";
			this.过滤KeyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.过滤KeyToolStripMenuItem.Text = "过滤Key";
			// 
			// 清除所有KeyToolStripMenuItem
			// 
			this.清除所有KeyToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.action_Cancel_16xLG;
			this.清除所有KeyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.清除所有KeyToolStripMenuItem.Name = "清除所有KeyToolStripMenuItem";
			this.清除所有KeyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.清除所有KeyToolStripMenuItem.Text = "清除所有Key";
			// 
			// 服务器状态ToolStripMenuItem
			// 
			this.服务器状态ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.server_info;
			this.服务器状态ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.服务器状态ToolStripMenuItem.Name = "服务器状态ToolStripMenuItem";
			this.服务器状态ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.服务器状态ToolStripMenuItem.Text = "服务器状态";
			// 
			// 控制台操作ToolStripMenuItem
			// 
			this.控制台操作ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.console;
			this.控制台操作ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.控制台操作ToolStripMenuItem.Name = "控制台操作ToolStripMenuItem";
			this.控制台操作ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.控制台操作ToolStripMenuItem.Text = "控制台操作";
			// 
			// 刷新所有数据ToolStripMenuItem
			// 
			this.刷新所有数据ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.Activity_16xLG;
			this.刷新所有数据ToolStripMenuItem.Name = "刷新所有数据ToolStripMenuItem";
			this.刷新所有数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.刷新所有数据ToolStripMenuItem.Text = "刷新所有数据";
			// 
			// 修改连接配置ToolStripMenuItem
			// 
			this.修改连接配置ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.settings;
			this.修改连接配置ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.修改连接配置ToolStripMenuItem.Name = "修改连接配置ToolStripMenuItem";
			this.修改连接配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.修改连接配置ToolStripMenuItem.Text = "修改连接配置";
			// 
			// 断开当前连接ToolStripMenuItem
			// 
			this.断开当前连接ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.disconnect;
			this.断开当前连接ToolStripMenuItem.Name = "断开当前连接ToolStripMenuItem";
			this.断开当前连接ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.断开当前连接ToolStripMenuItem.Text = "断开当前连接";
			// 
			// 删除当前链接ToolStripMenuItem
			// 
			this.删除当前链接ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.action_Cancel_16xLG1;
			this.删除当前链接ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.删除当前链接ToolStripMenuItem.Name = "删除当前链接ToolStripMenuItem";
			this.删除当前链接ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.删除当前链接ToolStripMenuItem.Text = "删除当前链接";
			// 
			// 修改密码ToolStripMenuItem
			// 
			this.修改密码ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.password;
			this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
			this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.修改密码ToolStripMenuItem.Text = "修改密码";
			// 
			// 展开所有ToolStripMenuItem
			// 
			this.展开所有ToolStripMenuItem.Image = global::HslRedisDesktop.Properties.Resources.expand;
			this.展开所有ToolStripMenuItem.Name = "展开所有ToolStripMenuItem";
			this.展开所有ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.展开所有ToolStripMenuItem.Text = "展开所有";
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1143, 673);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HslRedis Desktop";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip_db.ResumeLayout(false);
			this.contextMenuStrip_redis.ResumeLayout(false);
			this.contextMenuStrip_class.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_db;
		private System.Windows.Forms.ToolStripMenuItem 刷新数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清除所有KeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增KeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过滤KeyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_redis;
        private System.Windows.Forms.ToolStripMenuItem 服务器状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制台操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新所有数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改连接配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前链接ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_class;
		private System.Windows.Forms.ToolStripMenuItem 展开所有ToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 断开当前连接ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
	}
}

