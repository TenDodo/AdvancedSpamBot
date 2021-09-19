using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;

namespace AdvancedSpamBot
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            preview = new PreviewWindow();
            preview.TopMost = true;
        }

        public static MainWindow main;

        public static PreviewWindow preview;
        private void addTextButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.Text);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addKeyPressButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.PressKey);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addTimeBreakButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.Wait);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addTimeBreakRangeButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.WaitRandom);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void ctrlAltShiftButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.CtrlAltShift);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addExtraFeaturesButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.ExtraFeature);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addTextFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select file:";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        BotCommandBox box = new BotCommandBox(CommandBoxType.TextFromFile);
                        box.FilePath = openFileDialog.FileName;
                        box.FileContent = streamReader.ReadToEnd();
                        botCommandsFlowLayoutPanel.Controls.Add(box);
                        streamReader.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to open file\n" + exc.ToString());
            }
        }

        private void addOperationOnVariableButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.OperationOnVariable);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void writeVariableButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.WriteVariable);
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private bool _isRunning = false;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        private bool loopsAmount;
        private int loops;

        private bool osWait;
        private int osWaitV;

        List<KeyValuePair<CommandBoxType, string>> commands = new List<KeyValuePair<CommandBoxType, string>>();
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!IsRunning && !botBackgroundWorker.IsBusy)
            {
                do
                {
                    errorsSearchTimer.Enabled = false;
                } while (errorsBackgroundWorker.IsBusy);
                if (errorsList.Count > 0)
                {
                    int a = errorsList.Where(x => x.Type == 1).ToArray().Length;
                    if (errorsList.Where(x => x.Type == 0).ToArray().Length > 0)
                    {
                        MessageBox.Show("Bot cannot start due to errors, fix the errors and try again");
                        errorsSearchTimer.Enabled = true;
                        return;
                    }
                    else if (a > 0)
                    {
                        string b = a == 1 ? " warning" : " warnings were";
                        if (MessageBox.Show(a.ToString() + b + " found in your script, do you want to start anyway?", "Warnings", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            errorsSearchTimer.Enabled = true;
                            return;
                        }
                    }


                }

                botCommandsFlowLayoutPanel.Enabled = false;
                importButton.Enabled = false;
                exportButton.Enabled = false;
                addTextButton.Enabled = false;
                addKeyPressButton.Enabled = false;
                addTimeBreakButton.Enabled = false;
                addTimeBreakRangeButton.Enabled = false;
                ctrlAltShiftButton.Enabled = false;
                loopsAmountCheckBox.Enabled = false;
                loopsAmountMaskedTextBox.Enabled = false;
                onStartWaitCheckBox.Enabled = false;
                onStartWaitMaskedTextBox.Enabled = false;
                previewWindowCheckBox.Enabled = false;
                foreach (VariableBox item in variablesFlowLayoutPanel.Controls)
                {
                    item.Enabled = false;
                }
                if (loopsAmountCheckBox.Checked)
                {
                    loops = int.Parse(loopsAmountMaskedTextBox.Text.Replace(" ", ""));
                    loopsAmount = true;
                }
                else
                {
                    loopsAmount = false;
                }
                if (onStartWaitCheckBox.Checked)
                {
                    osWaitV = int.Parse(onStartWaitMaskedTextBox.Text.Replace(" ", ""));
                    osWait = true;
                }
                else
                {
                    osWait = false;
                }
                IsRunning = true;
                commands.Clear();
                historyTextBox.Clear();
                ReportState = "Starting bot...";
                foreach (var item in botCommandsFlowLayoutPanel.Controls)
                {
                    BotCommandBox a = (BotCommandBox)item;
                    switch (a.ThisType)
                    {
                        case CommandBoxType.Text:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Text, fixText(a.TextToWrite)));
                            break;
                        case CommandBoxType.PressKey:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.PressKey, a.PressKey));
                            break;
                        case CommandBoxType.Wait:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Wait, a.WaitValue));
                            break;
                        case CommandBoxType.WaitRandom:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WaitRandom, a.WaitValue));
                            break;
                        case CommandBoxType.CtrlAltShift:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.CtrlAltShift, a.CtrlAltShift));
                            break;
                        case CommandBoxType.TextFromFile:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Text, a.FileContent));
                            break;
                        case CommandBoxType.WriteVariable:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WriteVariable, a.VariableName));
                            break;
                        case CommandBoxType.OperationOnVariable:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.OperationOnVariable, a.OperationOnVariableData));
                            break;
                        case CommandBoxType.ExtraFeature:
                            commands.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.ExtraFeature, a.ExtraFeatureData));
                            break;
                        default:
                            break;
                    }
                }
                ReportState = commands.Count.ToString() + " command blocks";
                startButton.Text = "Stop";
                preview.stopButton.Text = "Stop";
                vd = new Dictionary<string, int>(VariableBox.VariablesDictionary);
                if (previewWindowCheckBox.Checked)
                {
                    this.Hide();
                    preview.Show();
                }
                botBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                if (!IsRunning && botBackgroundWorker.IsBusy)
                {
                    startButton.Text = "Finishing...";
                    preview.stopButton.Text = "Finishing...";
                }
                StopWorker();
            }
        }

        private string fixText(string txt)
        {
            var sb = new StringBuilder(txt.Length);
            for (var i = 0; i < txt.Length; i++)
            {
                var c = txt[i];
                switch (c)
                {
                    case '+':
                    case '^':
                    case '%':
                    case '~':
                    case '(':
                    case ')':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                        sb.Append('{');
                        sb.Append(c);
                        sb.Append('}');
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }
        Random rnd = new Random();
        public string ReportState
        {
            set
            {
                historyTextBox.Invoke(new MethodInvoker(
                delegate ()
                {

                    historyTextBox.Text += value + "\n";
                }));
            }
        }

        private readonly object padlock = new object();

        public void StopWorker()
        {
            botBackgroundWorker.CancelAsync();
            IsRunning = false;

            lock (padlock)
            {
                Monitor.Pulse(padlock);
            }
        }

        bool ctrl = false;
        bool alt = false;
        bool shift = false;

        Dictionary<string, int> vd;

        [DllImport("kernel32")]
        extern static UInt64 GetTickCount64();

        private void botBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            if (osWait)
            {
                ReportState = "Waiting (" + osWaitV + " ms)";
                lock (padlock)
                {
                    Monitor.Wait(padlock, TimeSpan.FromMilliseconds(osWaitV));
                }

            }
            while (IsRunning)
            {
                i++;
                ReportState = "Loop number " + i;
                foreach (var item in commands)
                {
                    if (item.Key == CommandBoxType.Text && IsRunning)
                    {
                        string cas = "";
                        string final = "";
                        if (ctrl || alt || shift)
                        {
                            cas += shift ? "+" : "";
                            cas += ctrl ? "^" : "";
                            cas += alt ? "%" : "";
                            cas += "(";
                            final = cas + item.Value + ")";
                        }
                        else
                        {
                            final = item.Value;
                        }
                        ReportState = "Writing text...";
                        SendKeys.SendWait(final);

                    }
                    else if (item.Key == CommandBoxType.PressKey && IsRunning)
                    {
                        string[] v = item.Value.Split("|");
                        string cas = "";
                        string final = "";
                        if (ctrl || alt || shift)
                        {
                            cas += shift ? "+" : "";
                            cas += ctrl ? "^" : "";
                            cas += alt ? "%" : "";
                            cas += "(";
                            final = cas + v[1] + ")";
                        }
                        else
                        {
                            final = v[1];
                        }
                        ReportState = "Pressed key " + v[1];
                        int num = int.Parse(v[0]);
                        for (int j = 0; j < num; j++)
                        {
                            SendKeys.SendWait(final);
                        }
                    }
                    else if (item.Key == CommandBoxType.Wait && IsRunning)
                    {
                        ReportState = "Waiting (" + item.Value + " ms)";
                        int wt = int.Parse(item.Value);
                        lock (padlock)
                        {
                            Monitor.Wait(padlock, TimeSpan.FromMilliseconds(wt));
                        }
                    }
                    else if (item.Key == CommandBoxType.WaitRandom && IsRunning)
                    {
                        string[] v = item.Value.Split('|');

                        int wt = rnd.Next(int.Parse(v[0]), int.Parse(v[1]));
                        ReportState = "Waiting (" + wt + " ms)";
                        lock (padlock)
                        {
                            Monitor.Wait(padlock, TimeSpan.FromMilliseconds(wt));
                        }
                    }
                    else if (item.Key == CommandBoxType.CtrlAltShift && IsRunning)
                    {
                        string[] sa = item.Value.Split('|');
                        if (sa[0] == "Key down")
                        {
                            switch (sa[1])
                            {
                                case "Ctrl":
                                    ctrl = true;
                                    break;
                                case "Alt":
                                    alt = true;
                                    break;
                                case "Shift":
                                    shift = true;
                                    break;
                                default:
                                    break;
                            }
                            ReportState = sa[1] + " key down";
                        }
                        else if (sa[0] == "Key up")
                        {
                            switch (sa[1])
                            {
                                case "Ctrl":
                                    ctrl = false;
                                    break;
                                case "Alt":
                                    alt = false;
                                    break;
                                case "Shift":
                                    shift = false;
                                    break;
                                default:
                                    break;
                            }
                            ReportState = sa[1] + " key up";
                        }
                    }
                    else if (item.Key == CommandBoxType.WriteVariable && IsRunning)
                    {
                        int vvalue = vd[item.Value];
                        ReportState = "Writing variable value (" + vvalue.ToString() + ")";
                        SendKeys.SendWait(vvalue.ToString());
                    }
                    else if (item.Key == CommandBoxType.OperationOnVariable && IsRunning)
                    {
                        string[] operations = item.Value.Split('|');
                        ReportState = operations[0] + " " + operations[1] + " " + operations[2];
                        switch (operations[1])
                        {
                            case "=":
                                vd[operations[0]] = vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            case "+=":
                                vd[operations[0]] += vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            case "-=":
                                vd[operations[0]] -= vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            case "/=":
                                vd[operations[0]] /= vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            case "%=":
                                vd[operations[0]] %= vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            case "*=":
                                vd[operations[0]] *= vd.ContainsKey(operations[2]) ? vd[operations[2]] : int.Parse(operations[2]);
                                break;
                            default:
                                break;
                        }

                    }
                    else if (item.Key == CommandBoxType.ExtraFeature && IsRunning)
                    {
                        switch (item.Value)
                        {
                            case "Date":
                                ReportState = "Writing date";
                                SendKeys.SendWait(fixText(DateTime.Now.Date.ToShortDateString()));
                                break;
                            case "Time":
                                ReportState = "Writing time";
                                SendKeys.SendWait(fixText(DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0')));
                                break;
                            case "Current user name":
                                ReportState = "Writing urrent user name";
                                SendKeys.SendWait(fixText(Environment.UserName));
                                break;
                            case "Computer uptime":
                                ReportState = "Writing computer uptime";
                                var timespan = TimeSpan.FromMilliseconds(GetTickCount64());
                                SendKeys.SendWait(fixText(timespan.ToString()));
                                break;
                            case "Local machine's host name":
                                ReportState = "Writing local machine's host name";
                                SendKeys.SendWait(fixText(Dns.GetHostName()));
                                break;
                            default:
                                ReportState = "Writing IP address";
                                int a = int.Parse(new string(item.Value.Replace("IPv6", "").Replace("IPv4", "").Where(char.IsDigit).ToArray()));
                                String strHostName = Dns.GetHostName();
                                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                                Debug.WriteLine("Length " + ipEntry.AddressList.Length);
                                SendKeys.SendWait(fixText(ipEntry.AddressList[a].ToString()));
                                break;
                        }

                    }
                    else
                    {
                        ReportState = "Waiting skipped";
                        IsRunning = false;
                        break;
                    }
                    lock (padlock)
                    {
                        Monitor.Wait(padlock, TimeSpan.FromMilliseconds(1));
                    }
                }
                if (loopsAmount && i >= loops)
                {
                    IsRunning = false;
                }
            }
        }





        private void botBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void botBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsRunning = false;

            startButton.Text = "Start";
            System.Media.SystemSounds.Hand.Play();
            ReportState = "Operations finished";
            ctrl = false;
            alt = false;
            shift = false;
            vd.Clear();
            errorsSearchTimer.Enabled = true;
            foreach (VariableBox item in variablesFlowLayoutPanel.Controls)
            {
                item.Enabled = true;
            }
            botCommandsFlowLayoutPanel.Enabled = true;
            importButton.Enabled = true;
            exportButton.Enabled = true;
            addTextButton.Enabled = true;
            addKeyPressButton.Enabled = true;
            addTimeBreakButton.Enabled = true;
            addTimeBreakRangeButton.Enabled = true;
            ctrlAltShiftButton.Enabled = true;
            loopsAmountCheckBox.Enabled = true;
            loopsAmountMaskedTextBox.Enabled = loopsAmountCheckBox.Checked;
            onStartWaitCheckBox.Enabled = true;
            previewWindowCheckBox.Enabled = true;
            this.Show();
            preview.Hide();
            onStartWaitMaskedTextBox.Enabled = onStartWaitCheckBox.Checked;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void historyTextBox_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void historyTextBox_TextChanged(object sender, EventArgs e)
        {
            historyTextBox.SelectionStart = historyTextBox.Text.Length;
            historyTextBox.ScrollToCaret();
            preview.historyTextBox.Text = historyTextBox.Text;
            preview.historyTextBox.SelectionStart = preview.historyTextBox.Text.Length;
            preview.historyTextBox.ScrollToCaret();
        }

        private void loopsAmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loopsAmountMaskedTextBox.Enabled = loopsAmountCheckBox.Checked;
        }

        List<KeyValuePair<CommandBoxType, string>> errorsSearchingList = new List<KeyValuePair<CommandBoxType, string>>();
        Dictionary<string, int> variablesErrorsSearchingList = new Dictionary<string, int>();

        List<ErrorData> errorsList = new List<ErrorData>();

        bool loopAmountEnabled = false;
        bool onStartWaitEnabled = false;
        string loopsAmountValue;
        string onStartWaitValue;
        public void checkingErrors()
        {
            foreach (var item in botCommandsFlowLayoutPanel.Controls)
            {
                BotCommandBox a = (BotCommandBox)item;
                switch (a.ThisType)
                {
                    case CommandBoxType.Text:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Text, fixText(a.TextToWrite)));
                        break;
                    case CommandBoxType.PressKey:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.PressKey, a.PressKey));
                        break;
                    case CommandBoxType.Wait:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Wait, a.WaitValue));
                        break;
                    case CommandBoxType.WaitRandom:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WaitRandom, a.WaitValue));
                        break;
                    case CommandBoxType.CtrlAltShift:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.CtrlAltShift, a.CtrlAltShift));
                        break;
                    case CommandBoxType.WriteVariable:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WriteVariable, a.VariableName));
                        break;
                    case CommandBoxType.OperationOnVariable:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.OperationOnVariable, a.OperationOnVariableData));
                        break;
                    case CommandBoxType.ExtraFeature:
                        errorsSearchingList.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.ExtraFeature, a.ExtraFeatureData));
                        break;
                    default:
                        break;
                }
            }
            variablesErrorsSearchingList = VariableBox.VariablesDictionary;
            loopAmountEnabled = loopsAmountCheckBox.Checked;
            onStartWaitEnabled = onStartWaitCheckBox.Checked;
            loopsAmountValue = loopsAmountMaskedTextBox.Text;
            onStartWaitValue = onStartWaitMaskedTextBox.Text;
            errorsBackgroundWorker.RunWorkerAsync();

        }
        private bool elChanged = false;
        int errorsCount = 0;
        int warningsCount = 0;
        private void errorsBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            errorsCount = 0;
            warningsCount = 0;
            elChanged = false;
            bool containsTimeBreak = false;
            List<ErrorData> newErrorsList = new List<ErrorData>();
            int i = 0;
            foreach (var item in errorsSearchingList)
            {
                switch (item.Key)
                {
                    case CommandBoxType.Text:
                        if (item.Value == "")
                        {
                            newErrorsList.Add(new ErrorData(1, "Text field is empty", i));
                            warningsCount++;
                        }
                        break;
                    case CommandBoxType.PressKey:
                        string[] v = item.Value.Split("|");
                        string n = v[0].Replace(" ", "");
                        if (n.Length == 0)
                        {
                            newErrorsList.Add(new ErrorData(0, "Amount field is empty", i));
                            errorsCount++;
                        }
                        break;
                    case CommandBoxType.Wait:
                        containsTimeBreak = true;
                        string v1 = item.Value.Replace(" ", "");
                        if (v1.Length == 0)
                        {
                            newErrorsList.Add(new ErrorData(0, "Milliseconds field is empty", i));
                            errorsCount++;
                        }
                        break;
                    case CommandBoxType.WaitRandom:
                        containsTimeBreak = true;
                        string[] v2 = item.Value.Split("|");
                        v2[0] = v2[0].Replace(" ", "");
                        v2[1] = v2[1].Replace(" ", "");
                        if (v2[0].Length == 0)
                        {
                            newErrorsList.Add(new ErrorData(0, "Min milliseconds field is empty", i));
                            errorsCount++;
                        }
                        if (v2[1].Length == 0)
                        {
                            newErrorsList.Add(new ErrorData(0, "Max milliseconds field is empty", i));
                            errorsCount++;
                        }
                        if (v2[0].Length != 0 && v2[1].Length != 0)
                        {
                            if (int.Parse(v2[0]) >= int.Parse(v2[1]))
                            {
                                newErrorsList.Add(new ErrorData(0, "Max milliseconds value must be greater than min milliseconds value", i));
                                errorsCount++;
                            }
                        }
                        break;
                    case CommandBoxType.CtrlAltShift:
                        break;
                    case CommandBoxType.TextFromFile:
                        if (item.Value == "")
                        {
                            newErrorsList.Add(new ErrorData(1, "File is empty", i));
                            warningsCount++;
                        }
                        break;
                    case CommandBoxType.WriteVariable:
                        if (!VariableBox.VariablesDictionary.ContainsKey(item.Value))
                        {
                            newErrorsList.Add(new ErrorData(0, "Variable " + item.Value + " does not exist", i));
                            errorsCount++;
                        }
                        break;
                    case CommandBoxType.ExtraFeature:
                        if (item.Value == "")
                        {
                            newErrorsList.Add(new ErrorData(0, "Extra feature combo box cannot be empty", i));
                            errorsCount++;
                        }
                        break;
                    case CommandBoxType.OperationOnVariable:
                        string[] operations = item.Value.Split('|');
                        if (!VariableBox.VariablesDictionary.ContainsKey(operations[0]))
                        {
                            newErrorsList.Add(new ErrorData(0, "First variable does not exist", i));
                            errorsCount++;
                        }
                        if (operations.Length != 3)
                        {
                            newErrorsList.Add(new ErrorData(0, "Second variable does not exist", i));
                            errorsCount++;
                        }
                        else if ((!operations[2].All(Char.IsDigit) || operations[2] == "") && !VariableBox.VariablesDictionary.ContainsKey(operations[2]))
                        {
                            newErrorsList.Add(new ErrorData(0, "Second variable does not exist", i));
                            errorsCount++;
                        }
                        break;
                    default:
                        break;
                }
                i++;

            }
            foreach (var item in variablesErrorsSearchingList)
            {
                if (item.Value == int.MinValue)
                {
                    newErrorsList.Add(new ErrorData(0, "Variable " + item.Key + " has an invalid value", -1));
                    errorsCount++;
                }
            }
            if (errorsSearchingList.Count == 0)
            {
                newErrorsList.Add(new ErrorData(1, "There are no command blocks", -1));
                warningsCount++;
            }
            else if (!containsTimeBreak)
            {
                newErrorsList.Add(new ErrorData(1, "No time break detected, stopping bot via button click may not be possible", -1));
                warningsCount++;
            }
            if (loopAmountEnabled)
            {
                if (loopsAmountValue.Replace(" ", "") == "")
                {
                    newErrorsList.Add(new ErrorData(0, "Loops amount text box is empty", -1));
                    errorsCount++;
                }
            }
            if (onStartWaitEnabled)
            {
                if (onStartWaitValue.Replace(" ", "") == "")
                {
                    newErrorsList.Add(new ErrorData(0, "On start wait text box is empty", -1));
                    errorsCount++;
                }
            }
            if (!newErrorsList.Select(x => x.Description + x.Index.ToString()).SequenceEqual(errorsList.Select(x => x.Description + x.Index.ToString())))
            {
                elChanged = true;
            }



            errorsSearchingList.Clear();
            errorsList = newErrorsList;
        }
        private void errorsBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            errorsAmountLabel.Text = "        " + errorsCount + " Errors Found";
            warningsAmountLabel.Text = "        " + warningsCount + " Warnings";
            errorsCount = 0;
            warningsCount = 0;
            if (elChanged)
            {
                elChanged = false;
                errorsFlowLayoutPanel.Controls.Clear();
                ErrorBox[] errorboxes = new ErrorBox[errorsList.Count];
                int i = 0;
                foreach (ErrorData item in errorsList)
                {
                    errorboxes[i] = new ErrorBox(item);
                    errorsFlowLayoutPanel.Controls.Add(errorboxes[i]);
                    i++;
                }
            }

        }

        private void errorsSearchTimer_Tick(object sender, EventArgs e)
        {
            if (!errorsBackgroundWorker.IsBusy)
            {
                checkingErrors();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<CommandBoxType, string>> _data = new List<KeyValuePair<CommandBoxType, string>>();
            foreach (var item in botCommandsFlowLayoutPanel.Controls)
            {
                BotCommandBox a = (BotCommandBox)item;
                switch (a.ThisType)
                {
                    case CommandBoxType.Text:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Text, fixText(a.TextToWrite)));
                        break;
                    case CommandBoxType.PressKey:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.PressKey, a.PressKey));
                        break;
                    case CommandBoxType.Wait:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.Wait, a.WaitValue));
                        break;
                    case CommandBoxType.WaitRandom:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WaitRandom, a.WaitValue));
                        break;
                    case CommandBoxType.CtrlAltShift:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.CtrlAltShift, a.CtrlAltShift));
                        break;
                    case CommandBoxType.TextFromFile:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.TextFromFile, a.FileContent));
                        break;
                    case CommandBoxType.WriteVariable:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.WriteVariable, a.VariableName));
                        break;
                    case CommandBoxType.OperationOnVariable:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.OperationOnVariable, a.OperationOnVariableData));
                        break;
                    case CommandBoxType.ExtraFeature:
                        _data.Add(new KeyValuePair<CommandBoxType, string>(CommandBoxType.ExtraFeature, a.ExtraFeatureData));
                        break;
                    default:
                        break;
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file:";
            saveFileDialog.Filter = "Json (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                byte[] jsonBytes = JsonSerializer.SerializeToUtf8Bytes(_data);
                streamWriter.Write(string.Join(' ', jsonBytes));
                streamWriter.Close();
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<KeyValuePair<CommandBoxType, string>> importedData;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select file:";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        string bytesString = streamReader.ReadToEnd();
                        string[] bytesStringArray = bytesString.Split(' ');
                        byte[] bytes = bytesStringArray.Select(byte.Parse).ToArray();
                        var readOnlySpan = new ReadOnlySpan<byte>(bytes);
                        importedData = JsonSerializer.Deserialize<List<KeyValuePair<CommandBoxType, string>>>(readOnlySpan);
                        streamReader.Close();
                        BotCommandBox[] commandsList = new BotCommandBox[importedData.Count];
                        int i = 0;
                        botCommandsFlowLayoutPanel.Controls.Clear();
                        foreach (var item in importedData)
                        {
                            commandsList[i] = new BotCommandBox(item.Key);
                            botCommandsFlowLayoutPanel.Controls.Add(commandsList[i]);
                            switch (item.Key)
                            {
                                case CommandBoxType.Text:
                                    commandsList[i].TextToWrite = item.Value;
                                    break;
                                case CommandBoxType.PressKey:
                                    commandsList[i].PressKey = item.Value;
                                    break;
                                case CommandBoxType.Wait:
                                    commandsList[i].WaitValue = item.Value;
                                    break;
                                case CommandBoxType.WaitRandom:
                                    commandsList[i].WaitValue = item.Value;
                                    break;
                                case CommandBoxType.CtrlAltShift:
                                    commandsList[i].CtrlAltShift = item.Value;
                                    break;
                                case CommandBoxType.TextFromFile:
                                    commandsList[i].FileContent = item.Value;
                                    break;
                                case CommandBoxType.WriteVariable:
                                    commandsList[i].VariableName = item.Value;
                                    break;
                                case CommandBoxType.OperationOnVariable:
                                    commandsList[i].OperationOnVariableData = item.Value;
                                    break;
                                case CommandBoxType.ExtraFeature:
                                    commandsList[i].ExtraFeatureData = item.Value;
                                    break;
                                default:
                                    break;
                            }

                            i++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid file");
            }

        }

        private void onStartWaitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            onStartWaitMaskedTextBox.Enabled = onStartWaitCheckBox.Checked;
        }

        private void addIntegerVariableButton_Click(object sender, EventArgs e)
        {
            string vName = "";
            if (InputBox("Enter variable name", ref vName) == DialogResult.OK)
            {
                if (vName.Length > 6)
                {
                    MessageBox.Show("Variable name is too long");
                    return;
                }
                if (vName.Length == 0)
                {
                    MessageBox.Show("Variable name cannot be empty");
                    return;
                }
                if (!vName.All(Char.IsLetterOrDigit))
                {
                    MessageBox.Show("Variable name contains illegal characters");
                    return;
                }
                if (vName.All(Char.IsDigit))
                {
                    MessageBox.Show("Variable name cannot be a number");
                    return;
                }
                if (VariableBox.VariablesDictionary.ContainsKey(vName))
                {
                    MessageBox.Show("Variable " + vName + " already exist");
                    return;
                }
                VariableBox vb = new VariableBox(vName);
                variablesFlowLayoutPanel.Controls.Add(vb);
            }

        }

        public static DialogResult InputBox(string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Input";
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            textBox.AcceptsTab = true;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void exportVariablesButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> d = new Dictionary<string, int>(VariableBox.VariablesDictionary);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file:";
            saveFileDialog.Filter = "Json (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                byte[] jsonBytes = JsonSerializer.SerializeToUtf8Bytes(d);
                streamWriter.Write(string.Join(' ', jsonBytes));
                streamWriter.Close();
            }
        }

        private void importVariablesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, int> importedData;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select file:";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        string bytesString = streamReader.ReadToEnd();
                        string[] bytesStringArray = bytesString.Split(' ');
                        byte[] bytes = bytesStringArray.Select(byte.Parse).ToArray();
                        var readOnlySpan = new ReadOnlySpan<byte>(bytes);
                        importedData = JsonSerializer.Deserialize<Dictionary<string, int>>(readOnlySpan);
                        streamReader.Close();
                        VariableBox[] commandsList = new VariableBox[importedData.Count];
                        int i = 0;
                        variablesFlowLayoutPanel.Controls.Clear();
                        VariableBox.VariablesDictionary.Clear();
                        foreach (var item in importedData)
                        {
                            commandsList[i] = new VariableBox(item.Key);
                            commandsList[i].VariableValue = item.Value;
                            variablesFlowLayoutPanel.Controls.Add(commandsList[i]);
                            i++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid file");
            }
        }


    }
}
