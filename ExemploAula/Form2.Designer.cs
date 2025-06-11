namespace ExemploAula
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            robloxiaToolStripMenuItem = new ToolStripMenuItem();
            bloxFruitsToolStripMenuItem = new ToolStripMenuItem();
            kingLegacyToolStripMenuItem = new ToolStripMenuItem();
            adoptMeToolStripMenuItem = new ToolStripMenuItem();
            brookhavenToolStripMenuItem = new ToolStripMenuItem();
            tsmiLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 359);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 0;
            label1.Text = "BUILDERMAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { robloxiaToolStripMenuItem, tsmiLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // robloxiaToolStripMenuItem
            // 
            robloxiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bloxFruitsToolStripMenuItem, kingLegacyToolStripMenuItem, adoptMeToolStripMenuItem, brookhavenToolStripMenuItem });
            robloxiaToolStripMenuItem.Name = "robloxiaToolStripMenuItem";
            robloxiaToolStripMenuItem.Size = new Size(65, 20);
            robloxiaToolStripMenuItem.Text = "Robloxia";
            // 
            // bloxFruitsToolStripMenuItem
            // 
            bloxFruitsToolStripMenuItem.Name = "bloxFruitsToolStripMenuItem";
            bloxFruitsToolStripMenuItem.Size = new Size(138, 22);
            bloxFruitsToolStripMenuItem.Text = "Blox Fruits";
            // 
            // kingLegacyToolStripMenuItem
            // 
            kingLegacyToolStripMenuItem.Name = "kingLegacyToolStripMenuItem";
            kingLegacyToolStripMenuItem.Size = new Size(138, 22);
            kingLegacyToolStripMenuItem.Text = "King Legacy";
            // 
            // adoptMeToolStripMenuItem
            // 
            adoptMeToolStripMenuItem.Name = "adoptMeToolStripMenuItem";
            adoptMeToolStripMenuItem.Size = new Size(138, 22);
            adoptMeToolStripMenuItem.Text = "Adopt Me";
            // 
            // brookhavenToolStripMenuItem
            // 
            brookhavenToolStripMenuItem.Name = "brookhavenToolStripMenuItem";
            brookhavenToolStripMenuItem.Size = new Size(138, 22);
            brookhavenToolStripMenuItem.Text = "Brookhaven";
            // 
            // tsmiLogout
            // 
            tsmiLogout.Name = "tsmiLogout";
            tsmiLogout.Size = new Size(62, 20);
            tsmiLogout.Text = "Log-out";
            tsmiLogout.Click += tsmiLogout_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem robloxiaToolStripMenuItem;
        private ToolStripMenuItem bloxFruitsToolStripMenuItem;
        private ToolStripMenuItem kingLegacyToolStripMenuItem;
        private ToolStripMenuItem adoptMeToolStripMenuItem;
        private ToolStripMenuItem brookhavenToolStripMenuItem;
        private ToolStripMenuItem tsmiLogout;
    }
}