using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSpamBot
{
    public partial class BotCommandBox : UserControl
    {
        public BotCommandBox(CommandBoxType type)
        {
            InitializeComponent();
            ThisType = type;
        }

        private CommandBoxType thisType;


        public string OperationOnVariableData
        {
            get
            {
                return firstVSelectComboBox.Text + "|" + operatorComboBox.Text + "|" + secondVSelectComboBox.Text;
            }
            set
            {
                string[] s = value.Split('|');
                firstVSelectComboBox.Text = s[0];
                operatorComboBox.Text = s[1];
                secondVSelectComboBox.Text = s[2];
            }
        }

        public string TextToWrite
        {
            get { return richTextBox.Text; }
            set
            {
                richTextBox.Text = value;
            }
        }
        public string WaitValue
        {
            get
            {
                if (thisType == CommandBoxType.Wait)
                {
                    return millisecondsMaskedTextBox.Text.Replace(" ", "");
                }
                else
                {

                    return minTimeMaskedTextBox.Text.Replace(" ", "") + "|" + maxTimeMaskedTextBox.Text.Replace(" ", "");
                }
            }
            set
            {
                if (value.Contains('|'))
                {
                    string[] s = value.Split('|');
                    minTimeMaskedTextBox.Text = s[0];
                    maxTimeMaskedTextBox.Text = s[1];
                }
                else
                {

                    millisecondsMaskedTextBox.Text = value;
                }
            }
        }


        public string FilePath
        {
            set
            {
                pathLabel.Text = "File path: " + value;
                int i = 0;
                while (pathLabel.Width > 420)
                {
                    pathLabel.Text = "File path: (...)" + value.Substring(i++);
                }
            }
        }

        private string _fileContent;

        public string FileContent
        {
            get { return _fileContent; }
            set
            {
                _fileContent = value;
                previewLabel.Text = "Preview: " + value;
                if (previewLabel.Width > 517 || previewLabel.Height > 17)
                {
                    string displayText = value;
                    if (displayText.Length > 200)
                    {
                        displayText = value.Substring(0, 200);
                    }
                    int i = displayText.Length;
                    while (previewLabel.Width > 517 || previewLabel.Height > 17)
                    {
                        previewLabel.Text = "Preview: " + displayText.Substring(0, i--) + "(...)";
                    }
                }
            }
        }



        public string VariableName
        {
            get { return variableWriteSelectComboBox.Text; }
            set
            {
                //if (variableWriteSelectComboBox.Items.Contains(value))
                //{
                //    variableWriteSelectComboBox.SelectedIndex = variableWriteSelectComboBox.Items.IndexOf(value);
                //}
                variableWriteSelectComboBox.Text = value;
            }
        }

        public string ExtraFeatureData
        {
            get
            {
                return extraFeatureComboBox.Text;
            }
            set
            {
                extraFeatureComboBox.Text = value;
                if (extraFeatureComboBox.Text == "")
                {
                    extraFeatureComboBox.SelectedIndex = 0;
                }
            }
        }


        public string CtrlAltShift
        {
            get
            {
                return downUpComboBox.Text + "|" + ctrlAltShiftComboBox.Text;
            }
            set
            {
                string[] s = value.Split('|');
                downUpComboBox.Text = s[0];
                ctrlAltShiftComboBox.Text = s[1];
            }
        }

        public string PressKey
        {
            get
            {
                switch (selectKeyComboBox.Text)
                {
                    case "Enter":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{ENTER}";
                    case "Arrow up":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{UP}";
                    case "Arrow down":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{DOWN}";
                    case "Arrow Right":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{RIGHT}";
                    case "Arrow Left":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{LEFT}";
                    case "Backspace":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{BACKSPACE}";
                    case "Break":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{BREAK}";
                    case "Delete (Del)":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{DELETE}";
                    case "End":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{END}";
                    case "Esc":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{ESC}";
                    case "Help":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{HELP}";
                    case "Home":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{HOME}";
                    case "Insert (Ins)":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{INSERT}";
                    case "Page down":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{PGDN}";
                    case "Page up":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{PGUP}";
                    case "Print screen (PRTSC)":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{PRTSC}";
                    case "TAB":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{TAB}";
                    case "F1":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F1}";
                    case "F2":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F2}";
                    case "F3":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F3}";
                    case "F4":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F4}";
                    case "F5":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F5}";
                    case "F6":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F6}";
                    case "F7":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F7}";
                    case "F8":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F8}";
                    case "F9":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F9}";
                    case "F10":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F10}";
                    case "F11":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F11}";
                    case "F12":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F12}";
                    case "F13":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F13}";
                    case "F14":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F14}";
                    case "F15":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F15}";
                    case "F16":
                        return amountMaskedTextBox.Text.Replace(" ", "") + "|" + "{F16}";
                    default:
                        return "";
                }
            }
            set
            {
                string[] input = value.Split('|');
                amountMaskedTextBox.Text = input[0];
                switch (input[1])
                {
                    case "{ENTER}":
                        selectKeyComboBox.Text = "Enter";
                        break;
                    case "{UP}":
                        selectKeyComboBox.Text = "Arrow up";
                        break;
                    case "{DOWN}":
                        selectKeyComboBox.Text = "Arrow down";
                        break;
                    case "{RIGHT}":
                        selectKeyComboBox.Text = "Arrow Right";
                        break;
                    case "{LEFT}":
                        selectKeyComboBox.Text = "Arrow Left";
                        break;
                    case "{BACKSPACE}":
                        selectKeyComboBox.Text = "Backspace";
                        break;
                    case "{BREAK}":
                        selectKeyComboBox.Text = "Break";
                        break;
                    case "{DELETE}":
                        selectKeyComboBox.Text = "Delete (Del)";
                        break;
                    case "{END}":
                        selectKeyComboBox.Text = "End";
                        break;
                    case "{ESC}":
                        selectKeyComboBox.Text = "Esc";
                        break;
                    case "{HELP}":
                        selectKeyComboBox.Text = "Help";
                        break;
                    case "{HOME}":
                        selectKeyComboBox.Text = "Home";
                        break;
                    case "{INSERT}":
                        selectKeyComboBox.Text = "Insert (Ins)";
                        break;
                    case "{PGDN}":
                        selectKeyComboBox.Text = "Page down";
                        break;
                    case "{PGUP}":
                        selectKeyComboBox.Text = "Page up";
                        break;
                    case "{PRTSC}":
                        selectKeyComboBox.Text = "Print screen (PRTSC)";
                        break;
                    case "{TAB}":
                        selectKeyComboBox.Text = "TAB";
                        break;
                    case "{F1}":
                        selectKeyComboBox.Text = "F1";
                        break;
                    case "{F2}":
                        selectKeyComboBox.Text = "F2";
                        break;
                    case "{F3}":
                        selectKeyComboBox.Text = "F3";
                        break;
                    case "{F4}":
                        selectKeyComboBox.Text = "F4";
                        break;
                    case "{F5}":
                        selectKeyComboBox.Text = "F5";
                        break;
                    case "{F6}":
                        selectKeyComboBox.Text = "F6";
                        break;
                    case "{F7}":
                        selectKeyComboBox.Text = "F7";
                        break;
                    case "{F8}":
                        selectKeyComboBox.Text = "F8";
                        break;
                    case "{F9}":
                        selectKeyComboBox.Text = "F9";
                        break;
                    case "{F10}":
                        selectKeyComboBox.Text = "F10";
                        break;
                    case "{F11}":
                        selectKeyComboBox.Text = "F11";
                        break;
                    case "{F12}":
                        selectKeyComboBox.Text = "F12";
                        break;
                    case "{F13}":
                        selectKeyComboBox.Text = "F13";
                        break;
                    case "{F14}":
                        selectKeyComboBox.Text = "F14";
                        break;
                    case "{F15}":
                        selectKeyComboBox.Text = "F15";
                        break;
                    case "{F16}":
                        selectKeyComboBox.Text = "F16";
                        break;
                    default:
                        selectKeyComboBox.SelectedIndex = 0;
                        break;
                }
            }
        }

        public CommandBoxType ThisType
        {
            get { return thisType; }
            set
            {
                thisType = value;
                switch (thisType)
                {
                    case CommandBoxType.Text:
                        //this.Size = new Size(580, 100);
                        textPanel.Visible = true;
                        //upButton.Size = new Size(30, 50);
                        //downButton.Size = new Size(30, 50);
                        break;
                    case CommandBoxType.PressKey:
                        selectKeyComboBox.SelectedIndex = 0;
                        pressKeyPanel.Visible = true;
                        break;
                    case CommandBoxType.Wait:
                        waitPanel.Visible = true;
                        break;
                    case CommandBoxType.WaitRandom:
                        waitRandomPanel.Visible = true;
                        break;
                    case CommandBoxType.CtrlAltShift:
                        ctrlAltShiftPanel.Visible = true;
                        ctrlAltShiftComboBox.SelectedIndex = 0;
                        downUpComboBox.SelectedIndex = 0;
                        break;
                    case CommandBoxType.TextFromFile:
                        textFromFilePanel.Visible = true;
                        break;
                    case CommandBoxType.WriteVariable:
                        writeVariablePanel.Visible = true;
                        variableWriteSelectComboBox.Items.Clear();
                        variableWriteSelectComboBox.Items.AddRange(VariableBox.VariablesDictionary.Select(x => x.Key).ToArray());
                        break;
                    case CommandBoxType.OperationOnVariable:
                        operationOnVariablePanel.Visible = true;
                        firstVSelectComboBox.Items.Clear();
                        firstVSelectComboBox.Items.AddRange(VariableBox.VariablesDictionary.Select(x => x.Key).ToArray());
                        operatorComboBox.SelectedIndex = 0;
                        break;
                    case CommandBoxType.ExtraFeature:
                        extraFeaturePanel.Visible = true;
                        
                        extraFeatureComboBox.Items.Clear();
                        extraFeatureComboBox.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Current user name",
            "Computer uptime"});
                        String strHostName = string.Empty;
                        strHostName = Dns.GetHostName();
                        if (strHostName != "")
                        {
                            extraFeatureComboBox.Items.Add("Local machine's host name");
                            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                            int i = 0;
                            foreach (var item in ipEntry.AddressList)
                            {
                                if (item.ToString().Contains(':'))
                                {
                                    extraFeatureComboBox.Items.Add("Local IP address (" + i + ") (IPv6)");
                                }
                                else
                                {
                                    extraFeatureComboBox.Items.Add("Local IP address (" + i + ") (IPv4)");
                                }
                                
                                i++;
                            }
                        }
                        extraFeatureComboBox.SelectedIndex = 0;
                        break;
                    default:
                        break;
                }
                SetColors(thisType);
            }
        }

        private void SetColors(CommandBoxType type)
        {
            switch (type)
            {
                case CommandBoxType.Text:
                    upButton.BackColor = Color.FromArgb(192, 255, 192);
                    downButton.BackColor = Color.FromArgb(192, 255, 192);
                    removeButton.BackColor = Color.FromArgb(192, 255, 192);
                    upButton.FlatAppearance.BorderColor = Color.Green;
                    downButton.FlatAppearance.BorderColor = Color.Green;
                    removeButton.FlatAppearance.BorderColor = Color.Green;
                    break;
                case CommandBoxType.PressKey:
                    upButton.BackColor = Color.FromArgb(255, 255, 192);
                    downButton.BackColor = Color.FromArgb(255, 255, 192);
                    removeButton.BackColor = Color.FromArgb(255, 255, 192);
                    pressKeyPanel.BackColor = Color.FromArgb(255, 255, 192);
                    upButton.FlatAppearance.BorderColor = Color.Olive;
                    downButton.FlatAppearance.BorderColor = Color.Olive;
                    removeButton.FlatAppearance.BorderColor = Color.Olive;
                    break;
                case CommandBoxType.Wait:
                    upButton.BackColor = Color.FromArgb(192, 192, 255);
                    downButton.BackColor = Color.FromArgb(192, 192, 255);
                    removeButton.BackColor = Color.FromArgb(192, 192, 255);
                    waitPanel.BackColor = Color.FromArgb(192, 192, 255);
                    upButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    downButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    removeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    break;
                case CommandBoxType.WaitRandom:
                    upButton.BackColor = Color.FromArgb(192, 192, 255);
                    downButton.BackColor = Color.FromArgb(192, 192, 255);
                    removeButton.BackColor = Color.FromArgb(192, 192, 255);
                    waitRandomPanel.BackColor = Color.FromArgb(192, 192, 255);
                    upButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    downButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    removeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    break;
                case CommandBoxType.CtrlAltShift:
                    upButton.BackColor = Color.FromArgb(255, 255, 192);
                    downButton.BackColor = Color.FromArgb(255, 255, 192);
                    removeButton.BackColor = Color.FromArgb(255, 255, 192);
                    ctrlAltShiftPanel.BackColor = Color.FromArgb(255, 255, 192);
                    upButton.FlatAppearance.BorderColor = Color.Olive;
                    downButton.FlatAppearance.BorderColor = Color.Olive;
                    removeButton.FlatAppearance.BorderColor = Color.Olive;
                    break;
                case CommandBoxType.TextFromFile:
                    upButton.BackColor = Color.FromArgb(192, 255, 192);
                    downButton.BackColor = Color.FromArgb(192, 255, 192);
                    removeButton.BackColor = Color.FromArgb(192, 255, 192);
                    textFromFilePanel.BackColor = Color.FromArgb(192, 255, 192);
                    upButton.FlatAppearance.BorderColor = Color.Green;
                    downButton.FlatAppearance.BorderColor = Color.Green;
                    removeButton.FlatAppearance.BorderColor = Color.Green;
                    break;
                case CommandBoxType.WriteVariable:
                    upButton.BackColor = Color.FromArgb(255, 128, 255);
                    downButton.BackColor = Color.FromArgb(255, 128, 255);
                    removeButton.BackColor = Color.FromArgb(255, 128, 255);
                    writeVariablePanel.BackColor = Color.FromArgb(255, 128, 255);
                    upButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    downButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    removeButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    break;
                case CommandBoxType.OperationOnVariable:
                    upButton.BackColor = Color.FromArgb(255, 128, 255);
                    downButton.BackColor = Color.FromArgb(255, 128, 255);
                    removeButton.BackColor = Color.FromArgb(255, 128, 255);
                    operationOnVariablePanel.BackColor = Color.FromArgb(255, 128, 255);
                    upButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    downButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    removeButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
                    break;
                case CommandBoxType.ExtraFeature:
                    upButton.BackColor = Color.Chocolate;
                    downButton.BackColor = Color.Chocolate;
                    removeButton.BackColor = Color.Chocolate;
                    extraFeaturePanel.BackColor = Color.Chocolate;
                    upButton.FlatAppearance.BorderColor = Color.SaddleBrown;
                    downButton.FlatAppearance.BorderColor = Color.SaddleBrown;
                    removeButton.FlatAppearance.BorderColor = Color.SaddleBrown;
                    break;
                default:
                    break;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MainWindow.main.botCommandsFlowLayoutPanel.Controls.Remove(this);
            Dispose();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int index = MainWindow.main.botCommandsFlowLayoutPanel.Controls.IndexOf(this);
            if (index - 1 >= 0)
            {
                List<BotCommandBox> list = new List<BotCommandBox>();
                foreach (var item in MainWindow.main.botCommandsFlowLayoutPanel.Controls)
                {
                    list.Add((BotCommandBox)item);
                }
                BotCommandBox saved = (BotCommandBox)list[index - 1];
                list[index - 1] = this;
                list[index] = saved;
                MainWindow.main.botCommandsFlowLayoutPanel.Controls.Clear();
                foreach (var item in list)
                {
                    MainWindow.main.botCommandsFlowLayoutPanel.Controls.Add(item);
                }
            }

        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int index = MainWindow.main.botCommandsFlowLayoutPanel.Controls.IndexOf(this);
            if (index + 1 <= MainWindow.main.botCommandsFlowLayoutPanel.Controls.Count - 1)
            {
                List<BotCommandBox> list = new List<BotCommandBox>();
                foreach (var item in MainWindow.main.botCommandsFlowLayoutPanel.Controls)
                {
                    list.Add((BotCommandBox)item);
                }
                BotCommandBox saved = (BotCommandBox)list[index + 1];
                list[index + 1] = this;
                list[index] = saved;
                MainWindow.main.botCommandsFlowLayoutPanel.Controls.Clear();
                foreach (var item in list)
                {
                    MainWindow.main.botCommandsFlowLayoutPanel.Controls.Add(item);
                }
            }
        }

        private void changeFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select file:";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        FilePath = openFileDialog.FileName;
                        FileContent = streamReader.ReadToEnd();
                        streamReader.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to open file\n" + exc.ToString());
            }
        }

        private void variableWriteSelectComboBox_Enter(object sender, EventArgs e)
        {
            variableWriteSelectComboBox.Items.Clear();
            variableWriteSelectComboBox.Items.AddRange(VariableBox.VariablesDictionary.Select(x => x.Key).ToArray());
        }

        private void firstVSelectComboBox_Enter(object sender, EventArgs e)
        {
            firstVSelectComboBox.Items.Clear();
            firstVSelectComboBox.Items.AddRange(VariableBox.VariablesDictionary.Select(x => x.Key).ToArray());
        }

        private void secondVSelectComboBox_Enter(object sender, EventArgs e)
        {
            secondVSelectComboBox.Items.Clear();
            secondVSelectComboBox.Items.AddRange(VariableBox.VariablesDictionary.Select(x => x.Key).ToArray());
        }

        private void extraFeatureComboBox_Enter(object sender, EventArgs e)
        {
            extraFeatureComboBox.Items.Clear();
            extraFeatureComboBox.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Current user name",
            "Computer uptime"});
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            if (strHostName != "")
            {
                extraFeatureComboBox.Items.Add("Local machine's host name");
                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                int i = 0;
                foreach (var item in ipEntry.AddressList)
                {
                    if (item.ToString().Contains(':'))
                    {
                        extraFeatureComboBox.Items.Add("Local IP address (" + i + ") (IPv6)");
                    }
                    else
                    {
                        extraFeatureComboBox.Items.Add("Local IP address (" + i + ") (IPv4)");
                    }

                    i++;
                }
            }
        }
    }

    public enum CommandBoxType
    {
        Text,
        PressKey,
        Wait,
        WaitRandom,
        CtrlAltShift,
        TextFromFile,
        OperationOnVariable,
        WriteVariable,
        ExtraFeature
    }
}
