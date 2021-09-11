using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSpamBot
{
    public partial class ErrorBox : UserControl
    {
        public ErrorBox(ErrorData ed)
        {
            InitializeComponent();
            if (ed.Type == 0)
            {
                typeLabel.Text = "        Error";
                typeLabel.Image = Properties.Resources.ErrorIcon;
            }
            else
            {
                typeLabel.Text = "        Warning";
                typeLabel.Image = Properties.Resources.WarningIcon;
            }
            descriptionLabel.Text = ed.Description;
            blockIndexLabel.Text = ed.Index >= 0 ? ed.Index.ToString() : "---";
        }
    }
}
