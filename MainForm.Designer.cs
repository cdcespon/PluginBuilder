namespace PluginBuilder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ClearSourceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteSourceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ClearDestinyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConvertLinesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConvertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearSourceToolStripButton,
            this.PasteSourceToolStripButton,
            this.MainToolStripSeparator,
            this.ClearDestinyToolStripButton,
            this.CopyToolStripButton,
            this.ConvertLinesToolStripButton,
            this.ConvertToolStripButton,
            this.SaveFileToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(838, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ClearSourceToolStripButton
            // 
            this.ClearSourceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearSourceToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearSourceToolStripButton.Image")));
            this.ClearSourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSourceToolStripButton.Name = "ClearSourceToolStripButton";
            this.ClearSourceToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ClearSourceToolStripButton.Text = "Clear Source";
            this.ClearSourceToolStripButton.Click += new System.EventHandler(this.ClearSourceToolStripButton_Click);
            // 
            // PasteSourceToolStripButton
            // 
            this.PasteSourceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteSourceToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteSourceToolStripButton.Image")));
            this.PasteSourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteSourceToolStripButton.Name = "PasteSourceToolStripButton";
            this.PasteSourceToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PasteSourceToolStripButton.Text = "Paste Source";
            this.PasteSourceToolStripButton.Click += new System.EventHandler(this.PasteSourceToolStripButton_Click);
            // 
            // MainToolStripSeparator
            // 
            this.MainToolStripSeparator.Name = "MainToolStripSeparator";
            this.MainToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearDestinyToolStripButton
            // 
            this.ClearDestinyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearDestinyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearDestinyToolStripButton.Image")));
            this.ClearDestinyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearDestinyToolStripButton.Name = "ClearDestinyToolStripButton";
            this.ClearDestinyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ClearDestinyToolStripButton.Text = "Clear Destiny";
            this.ClearDestinyToolStripButton.Click += new System.EventHandler(this.ClearDestinyToolStripButton_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripButton.Image")));
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "Copy";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // ConvertLinesToolStripButton
            // 
            this.ConvertLinesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConvertLinesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertLinesToolStripButton.Image")));
            this.ConvertLinesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConvertLinesToolStripButton.Name = "ConvertLinesToolStripButton";
            this.ConvertLinesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ConvertLinesToolStripButton.Text = "Convert Lines";
            this.ConvertLinesToolStripButton.Click += new System.EventHandler(this.ConvertLinesToolStripButton_Click);
            // 
            // ConvertToolStripButton
            // 
            this.ConvertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConvertToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertToolStripButton.Image")));
            this.ConvertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConvertToolStripButton.Name = "ConvertToolStripButton";
            this.ConvertToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ConvertToolStripButton.Text = "Convert";
            this.ConvertToolStripButton.Click += new System.EventHandler(this.ConvertToolStripButton_Click);
            // 
            // SaveFileToolStripButton
            // 
            this.SaveFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileToolStripButton.Image")));
            this.SaveFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileToolStripButton.Name = "SaveFileToolStripButton";
            this.SaveFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveFileToolStripButton.Text = "Save File";
            this.SaveFileToolStripButton.Click += new System.EventHandler(this.SaveFileToolStripButton_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.sourceTextBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ResultTextBox);
            this.SplitContainer.Size = new System.Drawing.Size(838, 436);
            this.SplitContainer.SplitterDistance = 410;
            this.SplitContainer.TabIndex = 15;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Location = new System.Drawing.Point(0, 0);
            this.sourceTextBox.MaxLength = 0;
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceTextBox.Size = new System.Drawing.Size(410, 436);
            this.sourceTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.ResultTextBox.MaxLength = 0;
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(424, 436);
            this.ResultTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 461);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "MainForm";
            this.Text = "Plugin Builder";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ClearSourceToolStripButton;
        private System.Windows.Forms.ToolStripButton PasteSourceToolStripButton;
        private System.Windows.Forms.ToolStripSeparator MainToolStripSeparator;
        private System.Windows.Forms.ToolStripButton ClearDestinyToolStripButton;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripButton ConvertToolStripButton;
        internal System.Windows.Forms.SplitContainer SplitContainer;
        internal System.Windows.Forms.TextBox sourceTextBox;
        internal System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ToolStripButton SaveFileToolStripButton;
        private System.Windows.Forms.ToolStripButton ConvertLinesToolStripButton;
    }
}

