using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PluginBuilder
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Call SetError or Clear on the ErrorProvider.
            if (((TextBox)sender).Text.Trim().Equals(String.Empty))
            {
                MainErrorProvider.SetError((TextBox)sender, "Needs to contain text.");
            }
            else
            {
                MainErrorProvider.Clear();
            }
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
             GUIDValueLabel.Text = Guid.NewGuid().ToString();
        }
    }
}
