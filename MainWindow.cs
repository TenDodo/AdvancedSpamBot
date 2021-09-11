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

namespace AdvancedSpamBot
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.Text);
            box.mainWindow = this;
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addKeyPressButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.PressKey);
            box.mainWindow = this;
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addTimeBreakButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.Wait);
            box.mainWindow = this;
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void addTimeBreakRangeButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.WaitRandom);
            box.mainWindow = this;
            botCommandsFlowLayoutPanel.Controls.Add(box);
        }

        private void ctrlAltShiftButton_Click(object sender, EventArgs e)
        {
            BotCommandBox box = new BotCommandBox(CommandBoxType.CtrlAltShift);
            box.mainWindow = this;
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
                        box.mainWindow = this;
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

        private bool _isRunning = false;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        private bool loopsAmount;
        private int loops;

        List<KeyValuePair<CommandBoxType, string>> commands = new List<KeyValuePair<CommandBoxType, string>>();
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                if (areErrors)
                {
                    MessageBox.Show("Bot cannot start due to errors, fix the errors and try again");
                    return;
                }
                botCommandsFlowLayoutPanel.Enabled = false;
                importButton.Enabled = false;
                exportButton.Enabled = false;
                addTextButton.Enabled = false;
                addKeyPressButton.Enabled = false;
                addTimeBreakButton.Enabled = false;
                addTimeBreakRangeButton.Enabled = false;
                ctrlAltShiftButton.Enabled = false;
                if (loopsAmountCheckBox.Checked)
                {
                    loops = int.Parse(loopsAmountMaskedTextBox.Text.Replace(" ", ""));
                    loopsAmount = true;
                }
                else
                {
                    loopsAmount = false;
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
                        default:
                            break;
                    }
                }
                ReportState = commands.Count.ToString() + " command blocks";
                startButton.Text = "Stop";
                botBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                StopWorker();
                startButton.Text = "Start";
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
            IsRunning = false;
            lock (padlock)
            {
                Monitor.Pulse(padlock);
            }
        }

        bool ctrl = false;
        bool alt = false;
        bool shift = false;

        private void botBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
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
                        //Thread.Sleep(wt);
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
                        //Thread.Sleep(wt);
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
                    else
                    {
                        ReportState = "Waiting skipped";
                        IsRunning = false;
                        break;
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
            ReportState = "Operations finished";
            ctrl = false;
            alt = false;
            shift = false;
            botCommandsFlowLayoutPanel.Enabled = true;
            importButton.Enabled = true;
            exportButton.Enabled = true;
            addTextButton.Enabled = true;
            addKeyPressButton.Enabled = true;
            addTimeBreakButton.Enabled = true;
            addTimeBreakRangeButton.Enabled = true;
            ctrlAltShiftButton.Enabled = true;
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
        }

        private void loopsAmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loopsAmountMaskedTextBox.Enabled = loopsAmountCheckBox.Checked;
        }

        List<KeyValuePair<CommandBoxType, string>> errorsSearchingList = new List<KeyValuePair<CommandBoxType, string>>();

        List<ErrorData> errorsList = new List<ErrorData>();
        public void checkingErrors()
        {
            if (botCommandsFlowLayoutPanel.Controls.Count != 0)
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
                        default:
                            break;
                    }
                }
                errorsBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                errorsFlowLayoutPanel.Controls.Clear();
                errorsCount = 0;
                warningsCount = 0;
                errorsAmountLabel.Text = "        " + errorsCount + " Errors Found";
                warningsAmountLabel.Text = "        " + warningsCount + " Warnings";
                errorsList.Clear();
                areErrors = false;
            }

        }
        private bool elChanged = false;
        int errorsCount = 0;
        int warningsCount = 0;
        private void errorsBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            errorsCount = 0;
            warningsCount = 0;
            elChanged = false;
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
                        string v1 = item.Value.Replace(" ", "");
                        if (v1.Length == 0)
                        {
                            newErrorsList.Add(new ErrorData(0, "Milliseconds field is empty", i));
                            errorsCount++;
                        }
                        break;
                    case CommandBoxType.WaitRandom:
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
                    default:
                        break;
                }
                i++;

            }
            if (errorsList.Count != newErrorsList.Count)
            {
                elChanged = true;
            }
            errorsSearchingList.Clear();
            errorsList = newErrorsList;
        }
        bool areErrors = false;
        private void errorsBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            errorsAmountLabel.Text = "        " + errorsCount + " Errors Found";
            warningsAmountLabel.Text = "        " + warningsCount + " Warnings";
            areErrors = errorsCount > 0;
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
                        commandsList[i].mainWindow = this;
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
                            default:
                                break;
                        }
                        botCommandsFlowLayoutPanel.Controls.Add(commandsList[i]);
                        i++;
                    }
                }
            }
        }
    }
}
