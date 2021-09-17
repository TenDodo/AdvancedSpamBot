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
    public partial class PreviewWindow : Form
    {
        public PreviewWindow()
        {
            InitializeComponent();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow.main.Show();
            historyTextBox.Text = "";
            MainWindow.main.StopWorker();
        }
    }
}
