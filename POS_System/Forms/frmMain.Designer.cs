namespace POS_System.Forms
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            roleToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            permissionToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem2 = new ToolStripMenuItem();
            createToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, userToolStripMenuItem, roleToolStripMenuItem, permissionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listsToolStripMenuItem, createToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(58, 24);
            userToolStripMenuItem.Text = "Users";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // listsToolStripMenuItem
            // 
            listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            listsToolStripMenuItem.Size = new Size(224, 26);
            listsToolStripMenuItem.Text = "Lists";
            listsToolStripMenuItem.Click += listsToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(224, 26);
            createToolStripMenuItem.Text = "Create";
            // 
            // roleToolStripMenuItem
            // 
            roleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listsToolStripMenuItem1, createToolStripMenuItem1 });
            roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            roleToolStripMenuItem.Size = new Size(53, 24);
            roleToolStripMenuItem.Text = "Role";
            // 
            // listsToolStripMenuItem1
            // 
            listsToolStripMenuItem1.Name = "listsToolStripMenuItem1";
            listsToolStripMenuItem1.Size = new Size(224, 26);
            listsToolStripMenuItem1.Text = "Lists";
            listsToolStripMenuItem1.Click += listsToolStripMenuItem1_Click;
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(224, 26);
            createToolStripMenuItem1.Text = "Create";
            // 
            // permissionToolStripMenuItem
            // 
            permissionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listsToolStripMenuItem2, createToolStripMenuItem2 });
            permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            permissionToolStripMenuItem.Size = new Size(93, 24);
            permissionToolStripMenuItem.Text = "Permission";
            // 
            // listsToolStripMenuItem2
            // 
            listsToolStripMenuItem2.Name = "listsToolStripMenuItem2";
            listsToolStripMenuItem2.Size = new Size(224, 26);
            listsToolStripMenuItem2.Text = "Lists";
            listsToolStripMenuItem2.Click += listsToolStripMenuItem2_Click;
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(224, 26);
            createToolStripMenuItem2.Text = "Create";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 981);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1918, 1028);
            Name = "frmMain";
            Text = "Form Main";
            Load += frm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem roleToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem permissionToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem2;
        private ToolStripMenuItem createToolStripMenuItem2;
    }
}