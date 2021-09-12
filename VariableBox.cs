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
    public partial class VariableBox : UserControl
    {
        public VariableBox(string vName)
        {
            InitializeComponent();
            VariableName = vName;
            VariablesDictionary.Add(vName, VariableValue);
        }

        private string _variableName;

        public string VariableName
        {
            get { return _variableName; }
            set { 
                _variableName = value;
                variableNameLabel.Text = value;
            }
        }

        public int VariableValue
        {
            get
            {
                return int.Parse(variableValueMaskedTextBox.Text.Replace(" ", ""));
            }
            set
            {
                variableValueMaskedTextBox.Text = value.ToString();
                VariablesDictionary[_variableName] = value;
            }
        }

        public static Dictionary<string, int> VariablesDictionary = new Dictionary<string, int>();

        private void removeButton_Click(object sender, EventArgs e)
        {
            VariablesDictionary.Remove(VariableName);
            MainWindow.main.variablesFlowLayoutPanel.Controls.Remove(this);
            this.Dispose();
        }

        private void variableValueMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VariablesDictionary[VariableName] = int.Parse(variableValueMaskedTextBox.Text.Replace(" ", ""));
            }
            catch
            {
                VariablesDictionary[VariableName] = int.MinValue;
            }
        }

       
    }
}
