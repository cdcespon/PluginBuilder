namespace PluginBuilder
{
    partial class DialogForm
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
            this.components = new System.ComponentModel.Container();
            this.PluginClassNameTextBox = new System.Windows.Forms.TextBox();
            this.PluginClassNameLabel = new System.Windows.Forms.Label();
            this.PluginDescriptionLabel = new System.Windows.Forms.Label();
            this.PluginNameTextBox = new System.Windows.Forms.TextBox();
            this.TemplateNameLabel = new System.Windows.Forms.Label();
            this.TemplateNameTextBox = new System.Windows.Forms.TextBox();
            this.PluginNameLabel = new System.Windows.Forms.Label();
            this.PluginDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.GuidLabel = new System.Windows.Forms.Label();
            this.TemplateDescriptionLabel = new System.Windows.Forms.Label();
            this.TemplateDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.GUIDValueLabel = new System.Windows.Forms.Label();
            this.TemplateOutputLangLabel1 = new System.Windows.Forms.Label();
            this.TemplateOutputLangTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PluginFilenameTextBox = new System.Windows.Forms.TextBox();
            this.MainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PluginClassNameTextBox
            // 
            this.PluginClassNameTextBox.Location = new System.Drawing.Point(127, 29);
            this.PluginClassNameTextBox.Name = "PluginClassNameTextBox";
            this.PluginClassNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.PluginClassNameTextBox.TabIndex = 2;
            this.PluginClassNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PluginClassNameLabel
            // 
            this.PluginClassNameLabel.AutoSize = true;
            this.PluginClassNameLabel.Location = new System.Drawing.Point(5, 32);
            this.PluginClassNameLabel.Name = "PluginClassNameLabel";
            this.PluginClassNameLabel.Size = new System.Drawing.Size(95, 13);
            this.PluginClassNameLabel.TabIndex = 1;
            this.PluginClassNameLabel.Text = "Plugin Class Name";
            // 
            // PluginDescriptionLabel
            // 
            this.PluginDescriptionLabel.AutoSize = true;
            this.PluginDescriptionLabel.Location = new System.Drawing.Point(5, 80);
            this.PluginDescriptionLabel.Name = "PluginDescriptionLabel";
            this.PluginDescriptionLabel.Size = new System.Drawing.Size(92, 13);
            this.PluginDescriptionLabel.TabIndex = 3;
            this.PluginDescriptionLabel.Text = "Plugin Description";
            // 
            // PluginNameTextBox
            // 
            this.PluginNameTextBox.Location = new System.Drawing.Point(127, 53);
            this.PluginNameTextBox.Name = "PluginNameTextBox";
            this.PluginNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.PluginNameTextBox.TabIndex = 3;
            this.PluginNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TemplateNameLabel
            // 
            this.TemplateNameLabel.AutoSize = true;
            this.TemplateNameLabel.Location = new System.Drawing.Point(5, 104);
            this.TemplateNameLabel.Name = "TemplateNameLabel";
            this.TemplateNameLabel.Size = new System.Drawing.Size(82, 13);
            this.TemplateNameLabel.TabIndex = 7;
            this.TemplateNameLabel.Text = "Template Name";
            // 
            // TemplateNameTextBox
            // 
            this.TemplateNameTextBox.Location = new System.Drawing.Point(127, 101);
            this.TemplateNameTextBox.Name = "TemplateNameTextBox";
            this.TemplateNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.TemplateNameTextBox.TabIndex = 5;
            this.TemplateNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PluginNameLabel
            // 
            this.PluginNameLabel.AutoSize = true;
            this.PluginNameLabel.Location = new System.Drawing.Point(5, 56);
            this.PluginNameLabel.Name = "PluginNameLabel";
            this.PluginNameLabel.Size = new System.Drawing.Size(67, 13);
            this.PluginNameLabel.TabIndex = 5;
            this.PluginNameLabel.Text = "Plugin Name";
            // 
            // PluginDescriptionTextBox
            // 
            this.PluginDescriptionTextBox.Location = new System.Drawing.Point(127, 77);
            this.PluginDescriptionTextBox.Name = "PluginDescriptionTextBox";
            this.PluginDescriptionTextBox.Size = new System.Drawing.Size(282, 20);
            this.PluginDescriptionTextBox.TabIndex = 4;
            this.PluginDescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // GuidLabel
            // 
            this.GuidLabel.AutoSize = true;
            this.GuidLabel.Location = new System.Drawing.Point(5, 176);
            this.GuidLabel.Name = "GuidLabel";
            this.GuidLabel.Size = new System.Drawing.Size(37, 13);
            this.GuidLabel.TabIndex = 11;
            this.GuidLabel.Text = "GUID:";
            // 
            // TemplateDescriptionLabel
            // 
            this.TemplateDescriptionLabel.AutoSize = true;
            this.TemplateDescriptionLabel.Location = new System.Drawing.Point(5, 128);
            this.TemplateDescriptionLabel.Name = "TemplateDescriptionLabel";
            this.TemplateDescriptionLabel.Size = new System.Drawing.Size(107, 13);
            this.TemplateDescriptionLabel.TabIndex = 9;
            this.TemplateDescriptionLabel.Text = "Template Description";
            // 
            // TemplateDescriptionTextBox
            // 
            this.TemplateDescriptionTextBox.Location = new System.Drawing.Point(127, 125);
            this.TemplateDescriptionTextBox.Name = "TemplateDescriptionTextBox";
            this.TemplateDescriptionTextBox.Size = new System.Drawing.Size(282, 20);
            this.TemplateDescriptionTextBox.TabIndex = 6;
            this.TemplateDescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // GUIDValueLabel
            // 
            this.GUIDValueLabel.AutoSize = true;
            this.GUIDValueLabel.Location = new System.Drawing.Point(130, 176);
            this.GUIDValueLabel.Name = "GUIDValueLabel";
            this.GUIDValueLabel.Size = new System.Drawing.Size(0, 13);
            this.GUIDValueLabel.TabIndex = 12;
            // 
            // TemplateOutputLangLabel1
            // 
            this.TemplateOutputLangLabel1.AutoSize = true;
            this.TemplateOutputLangLabel1.Location = new System.Drawing.Point(5, 152);
            this.TemplateOutputLangLabel1.Name = "TemplateOutputLangLabel1";
            this.TemplateOutputLangLabel1.Size = new System.Drawing.Size(116, 13);
            this.TemplateOutputLangLabel1.TabIndex = 14;
            this.TemplateOutputLangLabel1.Text = "Template Output Lang.";
            // 
            // TemplateOutputLangTextBox
            // 
            this.TemplateOutputLangTextBox.Location = new System.Drawing.Point(127, 149);
            this.TemplateOutputLangTextBox.Name = "TemplateOutputLangTextBox";
            this.TemplateOutputLangTextBox.Size = new System.Drawing.Size(282, 20);
            this.TemplateOutputLangTextBox.TabIndex = 7;
            this.TemplateOutputLangTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(249, 201);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(334, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plugin Filename";
            // 
            // PluginFilenameTextBox
            // 
            this.PluginFilenameTextBox.Location = new System.Drawing.Point(127, 5);
            this.PluginFilenameTextBox.Name = "PluginFilenameTextBox";
            this.PluginFilenameTextBox.Size = new System.Drawing.Size(282, 20);
            this.PluginFilenameTextBox.TabIndex = 1;
            this.PluginFilenameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainErrorProvider
            // 
            this.MainErrorProvider.ContainerControl = this;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PluginFilenameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TemplateOutputLangLabel1);
            this.Controls.Add(this.TemplateOutputLangTextBox);
            this.Controls.Add(this.GUIDValueLabel);
            this.Controls.Add(this.GuidLabel);
            this.Controls.Add(this.TemplateDescriptionLabel);
            this.Controls.Add(this.TemplateDescriptionTextBox);
            this.Controls.Add(this.TemplateNameLabel);
            this.Controls.Add(this.TemplateNameTextBox);
            this.Controls.Add(this.PluginNameLabel);
            this.Controls.Add(this.PluginDescriptionTextBox);
            this.Controls.Add(this.PluginDescriptionLabel);
            this.Controls.Add(this.PluginNameTextBox);
            this.Controls.Add(this.PluginClassNameLabel);
            this.Controls.Add(this.PluginClassNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogForm";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PluginClassNameLabel;
        private System.Windows.Forms.Label PluginDescriptionLabel;
        private System.Windows.Forms.Label TemplateNameLabel;
        private System.Windows.Forms.Label PluginNameLabel;
        private System.Windows.Forms.Label GuidLabel;
        private System.Windows.Forms.Label TemplateDescriptionLabel;
        private System.Windows.Forms.Label TemplateOutputLangLabel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MainErrorProvider;
        public System.Windows.Forms.TextBox PluginClassNameTextBox;
        public System.Windows.Forms.TextBox PluginNameTextBox;
        public System.Windows.Forms.TextBox TemplateNameTextBox;
        public System.Windows.Forms.TextBox PluginDescriptionTextBox;
        public System.Windows.Forms.TextBox TemplateDescriptionTextBox;
        public System.Windows.Forms.TextBox TemplateOutputLangTextBox;
        public System.Windows.Forms.TextBox PluginFilenameTextBox;
        public System.Windows.Forms.Label GUIDValueLabel;
    }
}