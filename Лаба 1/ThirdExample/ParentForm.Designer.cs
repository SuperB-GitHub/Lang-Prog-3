namespace ThirdExample
{
    partial class ParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MDIMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            WindowCascadeMenuItem = new ToolStripMenuItem();
            WindowTileMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            MDIMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MDIMenu
            // 
            MDIMenu.ImageScalingSize = new Size(20, 20);
            MDIMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, NewMenuItem, ExitMenuItem });
            MDIMenu.Location = new Point(0, 0);
            MDIMenu.MdiWindowListItem = FileMenuItem;
            MDIMenu.Name = "MDIMenu";
            MDIMenu.Padding = new Padding(5, 2, 0, 2);
            MDIMenu.Size = new Size(352, 24);
            MDIMenu.TabIndex = 1;
            MDIMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WindowCascadeMenuItem, WindowTileMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "&File";
            // 
            // WindowCascadeMenuItem
            // 
            WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            WindowCascadeMenuItem.Size = new Size(180, 22);
            WindowCascadeMenuItem.Text = "&Cascade";
            WindowCascadeMenuItem.Click += WindowCascadeMenuItem_Click;
            // 
            // WindowTileMenuItem
            // 
            WindowTileMenuItem.Name = "WindowTileMenuItem";
            WindowTileMenuItem.Size = new Size(180, 22);
            WindowTileMenuItem.Text = "&Tile";
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            // 
            // NewMenuItem
            // 
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(43, 20);
            NewMenuItem.Text = "&New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(38, 20);
            ExitMenuItem.Text = "&Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 205);
            Controls.Add(MDIMenu);
            IsMdiContainer = true;
            MainMenuStrip = MDIMenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ParentForm";
            Text = "Parent";
            Load += ParentForm_Load;
            MDIMenu.ResumeLayout(false);
            MDIMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MDIMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem WindowCascadeMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
    }
}
