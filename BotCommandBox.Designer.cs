
namespace AdvancedSpamBot
{
    partial class BotCommandBox
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.textPanel = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.writeVariablePanel = new System.Windows.Forms.Panel();
            this.variableWriteSelectComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFromFilePanel = new System.Windows.Forms.Panel();
            this.changeFileButton = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.waitRandomPanel = new System.Windows.Forms.Panel();
            this.maxTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pressKeyPanel = new System.Windows.Forms.Panel();
            this.amountMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectKeyComboBox = new System.Windows.Forms.ComboBox();
            this.waitPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.millisecondsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ctrlAltShiftPanel = new System.Windows.Forms.Panel();
            this.ctrlAltShiftComboBox = new System.Windows.Forms.ComboBox();
            this.downUpComboBox = new System.Windows.Forms.ComboBox();
            this.operationOnVariablePanel = new System.Windows.Forms.Panel();
            this.secondVSelectComboBox = new System.Windows.Forms.ComboBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.firstVSelectComboBox = new System.Windows.Forms.ComboBox();
            this.extraFeaturePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.extraFeatureComboBox = new System.Windows.Forms.ComboBox();
            this.controlsPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.writeVariablePanel.SuspendLayout();
            this.textFromFilePanel.SuspendLayout();
            this.waitRandomPanel.SuspendLayout();
            this.pressKeyPanel.SuspendLayout();
            this.waitPanel.SuspendLayout();
            this.ctrlAltShiftPanel.SuspendLayout();
            this.operationOnVariablePanel.SuspendLayout();
            this.extraFeaturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Silver;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(550, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(30, 50);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.downButton);
            this.controlsPanel.Controls.Add(this.upButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(30, 50);
            this.controlsPanel.TabIndex = 5;
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.Silver;
            this.downButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downButton.Location = new System.Drawing.Point(0, 25);
            this.downButton.Margin = new System.Windows.Forms.Padding(0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(30, 25);
            this.downButton.TabIndex = 6;
            this.downButton.Text = "˅";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.Silver;
            this.upButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upButton.Location = new System.Drawing.Point(0, 0);
            this.upButton.Margin = new System.Windows.Forms.Padding(0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(30, 25);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "˄";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.richTextBox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(30, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(0);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(520, 50);
            this.textPanel.TabIndex = 6;
            this.textPanel.Visible = false;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(520, 50);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // writeVariablePanel
            // 
            this.writeVariablePanel.Controls.Add(this.variableWriteSelectComboBox);
            this.writeVariablePanel.Controls.Add(this.label5);
            this.writeVariablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeVariablePanel.Location = new System.Drawing.Point(30, 0);
            this.writeVariablePanel.Name = "writeVariablePanel";
            this.writeVariablePanel.Size = new System.Drawing.Size(520, 50);
            this.writeVariablePanel.TabIndex = 8;
            this.writeVariablePanel.Visible = false;
            // 
            // variableWriteSelectComboBox
            // 
            this.variableWriteSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variableWriteSelectComboBox.FormattingEnabled = true;
            this.variableWriteSelectComboBox.Location = new System.Drawing.Point(115, 15);
            this.variableWriteSelectComboBox.Name = "variableWriteSelectComboBox";
            this.variableWriteSelectComboBox.Size = new System.Drawing.Size(100, 23);
            this.variableWriteSelectComboBox.TabIndex = 3;
            this.variableWriteSelectComboBox.Enter += new System.EventHandler(this.variableWriteSelectComboBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Write variable";
            // 
            // textFromFilePanel
            // 
            this.textFromFilePanel.Controls.Add(this.changeFileButton);
            this.textFromFilePanel.Controls.Add(this.previewLabel);
            this.textFromFilePanel.Controls.Add(this.pathLabel);
            this.textFromFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFromFilePanel.Location = new System.Drawing.Point(30, 0);
            this.textFromFilePanel.Name = "textFromFilePanel";
            this.textFromFilePanel.Size = new System.Drawing.Size(520, 50);
            this.textFromFilePanel.TabIndex = 1;
            this.textFromFilePanel.Visible = false;
            // 
            // changeFileButton
            // 
            this.changeFileButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeFileButton.Location = new System.Drawing.Point(3, 0);
            this.changeFileButton.Name = "changeFileButton";
            this.changeFileButton.Size = new System.Drawing.Size(92, 25);
            this.changeFileButton.TabIndex = 4;
            this.changeFileButton.Text = "Change file";
            this.changeFileButton.UseVisualStyleBackColor = true;
            this.changeFileButton.Click += new System.EventHandler(this.changeFileButton_Click);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previewLabel.Location = new System.Drawing.Point(3, 28);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(59, 17);
            this.previewLabel.TabIndex = 3;
            this.previewLabel.Text = "Preview:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(100, 4);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(115, 17);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "File path: No Data";
            // 
            // waitRandomPanel
            // 
            this.waitRandomPanel.Controls.Add(this.maxTimeMaskedTextBox);
            this.waitRandomPanel.Controls.Add(this.minTimeMaskedTextBox);
            this.waitRandomPanel.Controls.Add(this.label3);
            this.waitRandomPanel.Controls.Add(this.label2);
            this.waitRandomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitRandomPanel.Location = new System.Drawing.Point(30, 0);
            this.waitRandomPanel.Name = "waitRandomPanel";
            this.waitRandomPanel.Size = new System.Drawing.Size(520, 50);
            this.waitRandomPanel.TabIndex = 1;
            this.waitRandomPanel.Visible = false;
            // 
            // maxTimeMaskedTextBox
            // 
            this.maxTimeMaskedTextBox.HidePromptOnLeave = true;
            this.maxTimeMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maxTimeMaskedTextBox.Location = new System.Drawing.Point(400, 15);
            this.maxTimeMaskedTextBox.Mask = "00000000";
            this.maxTimeMaskedTextBox.Name = "maxTimeMaskedTextBox";
            this.maxTimeMaskedTextBox.PromptChar = ' ';
            this.maxTimeMaskedTextBox.Size = new System.Drawing.Size(80, 23);
            this.maxTimeMaskedTextBox.TabIndex = 3;
            this.maxTimeMaskedTextBox.Text = "10000";
            // 
            // minTimeMaskedTextBox
            // 
            this.minTimeMaskedTextBox.HidePromptOnLeave = true;
            this.minTimeMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.minTimeMaskedTextBox.Location = new System.Drawing.Point(160, 15);
            this.minTimeMaskedTextBox.Mask = "00000000";
            this.minTimeMaskedTextBox.Name = "minTimeMaskedTextBox";
            this.minTimeMaskedTextBox.PromptChar = ' ';
            this.minTimeMaskedTextBox.Size = new System.Drawing.Size(80, 23);
            this.minTimeMaskedTextBox.TabIndex = 2;
            this.minTimeMaskedTextBox.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max time in miliseconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Min time in milisecond";
            // 
            // pressKeyPanel
            // 
            this.pressKeyPanel.Controls.Add(this.amountMaskedTextBox);
            this.pressKeyPanel.Controls.Add(this.label4);
            this.pressKeyPanel.Controls.Add(this.selectKeyComboBox);
            this.pressKeyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressKeyPanel.Location = new System.Drawing.Point(30, 0);
            this.pressKeyPanel.Name = "pressKeyPanel";
            this.pressKeyPanel.Size = new System.Drawing.Size(520, 50);
            this.pressKeyPanel.TabIndex = 1;
            this.pressKeyPanel.Visible = false;
            // 
            // amountMaskedTextBox
            // 
            this.amountMaskedTextBox.AllowPromptAsInput = false;
            this.amountMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.amountMaskedTextBox.HidePromptOnLeave = true;
            this.amountMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.amountMaskedTextBox.Location = new System.Drawing.Point(76, 15);
            this.amountMaskedTextBox.Mask = "000";
            this.amountMaskedTextBox.Name = "amountMaskedTextBox";
            this.amountMaskedTextBox.PromptChar = ' ';
            this.amountMaskedTextBox.ShortcutsEnabled = false;
            this.amountMaskedTextBox.Size = new System.Drawing.Size(84, 23);
            this.amountMaskedTextBox.TabIndex = 2;
            this.amountMaskedTextBox.Text = "1";
            this.amountMaskedTextBox.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount";
            // 
            // selectKeyComboBox
            // 
            this.selectKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectKeyComboBox.FormattingEnabled = true;
            this.selectKeyComboBox.Items.AddRange(new object[] {
            "Enter",
            "Arrow up",
            "Arrow down",
            "Arrow Right",
            "Arrow Left",
            "Backspace",
            "Break",
            "Delete (Del)",
            "End",
            "Esc",
            "Help",
            "Home",
            "Insert (Ins)",
            "Page down",
            "Page up",
            "Print screen (PRTSC)",
            "TAB",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16"});
            this.selectKeyComboBox.Location = new System.Drawing.Point(166, 15);
            this.selectKeyComboBox.Name = "selectKeyComboBox";
            this.selectKeyComboBox.Size = new System.Drawing.Size(339, 23);
            this.selectKeyComboBox.TabIndex = 0;
            // 
            // waitPanel
            // 
            this.waitPanel.Controls.Add(this.label1);
            this.waitPanel.Controls.Add(this.millisecondsMaskedTextBox);
            this.waitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitPanel.Location = new System.Drawing.Point(30, 0);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(520, 50);
            this.waitPanel.TabIndex = 7;
            this.waitPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time in milliseconds";
            // 
            // millisecondsMaskedTextBox
            // 
            this.millisecondsMaskedTextBox.AllowPromptAsInput = false;
            this.millisecondsMaskedTextBox.HidePromptOnLeave = true;
            this.millisecondsMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.millisecondsMaskedTextBox.Location = new System.Drawing.Point(141, 15);
            this.millisecondsMaskedTextBox.Mask = "00000000";
            this.millisecondsMaskedTextBox.Name = "millisecondsMaskedTextBox";
            this.millisecondsMaskedTextBox.PromptChar = ' ';
            this.millisecondsMaskedTextBox.ShortcutsEnabled = false;
            this.millisecondsMaskedTextBox.Size = new System.Drawing.Size(80, 23);
            this.millisecondsMaskedTextBox.TabIndex = 0;
            this.millisecondsMaskedTextBox.Text = "5000";
            this.millisecondsMaskedTextBox.ValidatingType = typeof(int);
            // 
            // ctrlAltShiftPanel
            // 
            this.ctrlAltShiftPanel.Controls.Add(this.ctrlAltShiftComboBox);
            this.ctrlAltShiftPanel.Controls.Add(this.downUpComboBox);
            this.ctrlAltShiftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAltShiftPanel.Location = new System.Drawing.Point(30, 0);
            this.ctrlAltShiftPanel.Name = "ctrlAltShiftPanel";
            this.ctrlAltShiftPanel.Size = new System.Drawing.Size(520, 50);
            this.ctrlAltShiftPanel.TabIndex = 4;
            this.ctrlAltShiftPanel.Visible = false;
            // 
            // ctrlAltShiftComboBox
            // 
            this.ctrlAltShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlAltShiftComboBox.FormattingEnabled = true;
            this.ctrlAltShiftComboBox.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.ctrlAltShiftComboBox.Location = new System.Drawing.Point(160, 15);
            this.ctrlAltShiftComboBox.Name = "ctrlAltShiftComboBox";
            this.ctrlAltShiftComboBox.Size = new System.Drawing.Size(121, 23);
            this.ctrlAltShiftComboBox.TabIndex = 1;
            // 
            // downUpComboBox
            // 
            this.downUpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downUpComboBox.FormattingEnabled = true;
            this.downUpComboBox.Items.AddRange(new object[] {
            "Key down",
            "Key up"});
            this.downUpComboBox.Location = new System.Drawing.Point(15, 15);
            this.downUpComboBox.Name = "downUpComboBox";
            this.downUpComboBox.Size = new System.Drawing.Size(121, 23);
            this.downUpComboBox.TabIndex = 0;
            // 
            // operationOnVariablePanel
            // 
            this.operationOnVariablePanel.Controls.Add(this.secondVSelectComboBox);
            this.operationOnVariablePanel.Controls.Add(this.operatorComboBox);
            this.operationOnVariablePanel.Controls.Add(this.firstVSelectComboBox);
            this.operationOnVariablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationOnVariablePanel.Location = new System.Drawing.Point(30, 0);
            this.operationOnVariablePanel.Name = "operationOnVariablePanel";
            this.operationOnVariablePanel.Size = new System.Drawing.Size(520, 50);
            this.operationOnVariablePanel.TabIndex = 9;
            this.operationOnVariablePanel.Visible = false;
            // 
            // secondVSelectComboBox
            // 
            this.secondVSelectComboBox.FormattingEnabled = true;
            this.secondVSelectComboBox.Location = new System.Drawing.Point(326, 15);
            this.secondVSelectComboBox.Name = "secondVSelectComboBox";
            this.secondVSelectComboBox.Size = new System.Drawing.Size(100, 23);
            this.secondVSelectComboBox.TabIndex = 6;
            this.secondVSelectComboBox.Enter += new System.EventHandler(this.secondVSelectComboBox_Enter);
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "=",
            "+=",
            "-=",
            "/=",
            "*=",
            "%="});
            this.operatorComboBox.Location = new System.Drawing.Point(121, 15);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(199, 23);
            this.operatorComboBox.TabIndex = 5;
            // 
            // firstVSelectComboBox
            // 
            this.firstVSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstVSelectComboBox.FormattingEnabled = true;
            this.firstVSelectComboBox.Location = new System.Drawing.Point(15, 15);
            this.firstVSelectComboBox.Name = "firstVSelectComboBox";
            this.firstVSelectComboBox.Size = new System.Drawing.Size(100, 23);
            this.firstVSelectComboBox.TabIndex = 4;
            this.firstVSelectComboBox.Enter += new System.EventHandler(this.firstVSelectComboBox_Enter);
            // 
            // extraFeaturePanel
            // 
            this.extraFeaturePanel.Controls.Add(this.extraFeatureComboBox);
            this.extraFeaturePanel.Controls.Add(this.label6);
            this.extraFeaturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extraFeaturePanel.Location = new System.Drawing.Point(0, 0);
            this.extraFeaturePanel.Name = "extraFeaturePanel";
            this.extraFeaturePanel.Size = new System.Drawing.Size(520, 50);
            this.extraFeaturePanel.TabIndex = 10;
            this.extraFeaturePanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Write";
            // 
            // extraFeatureComboBox
            // 
            this.extraFeatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extraFeatureComboBox.FormattingEnabled = true;
            this.extraFeatureComboBox.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Current user name",
            "Computer uptime"});
            this.extraFeatureComboBox.Location = new System.Drawing.Point(62, 15);
            this.extraFeatureComboBox.Name = "extraFeatureComboBox";
            this.extraFeatureComboBox.Size = new System.Drawing.Size(339, 23);
            this.extraFeatureComboBox.TabIndex = 4;
            this.extraFeatureComboBox.Enter += new System.EventHandler(this.extraFeatureComboBox_Enter);
            // 
            // BotCommandBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.waitPanel);
            this.Controls.Add(this.waitRandomPanel);
            this.Controls.Add(this.ctrlAltShiftPanel);
            this.Controls.Add(this.textFromFilePanel);
            this.Controls.Add(this.pressKeyPanel);
            this.Controls.Add(this.writeVariablePanel);
            this.Controls.Add(this.extraFeaturePanel);
            this.Controls.Add(this.operationOnVariablePanel);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.removeButton);
            this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Name = "BotCommandBox";
            this.Size = new System.Drawing.Size(580, 50);
            this.controlsPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.writeVariablePanel.ResumeLayout(false);
            this.writeVariablePanel.PerformLayout();
            this.textFromFilePanel.ResumeLayout(false);
            this.textFromFilePanel.PerformLayout();
            this.waitRandomPanel.ResumeLayout(false);
            this.waitRandomPanel.PerformLayout();
            this.pressKeyPanel.ResumeLayout(false);
            this.pressKeyPanel.PerformLayout();
            this.waitPanel.ResumeLayout(false);
            this.waitPanel.PerformLayout();
            this.ctrlAltShiftPanel.ResumeLayout(false);
            this.operationOnVariablePanel.ResumeLayout(false);
            this.extraFeaturePanel.ResumeLayout(false);
            this.extraFeaturePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel pressKeyPanel;
        private System.Windows.Forms.ComboBox selectKeyComboBox;
        private System.Windows.Forms.Panel waitPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox millisecondsMaskedTextBox;
        private System.Windows.Forms.Panel waitRandomPanel;
        private System.Windows.Forms.MaskedTextBox maxTimeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox minTimeMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ctrlAltShiftPanel;
        private System.Windows.Forms.ComboBox ctrlAltShiftComboBox;
        private System.Windows.Forms.ComboBox downUpComboBox;
        private System.Windows.Forms.MaskedTextBox amountMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel textFromFilePanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.Button changeFileButton;
        private System.Windows.Forms.Panel writeVariablePanel;
        private System.Windows.Forms.ComboBox variableWriteSelectComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel operationOnVariablePanel;
        private System.Windows.Forms.ComboBox firstVSelectComboBox;
        private System.Windows.Forms.ComboBox secondVSelectComboBox;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.Panel extraFeaturePanel;
        private System.Windows.Forms.ComboBox extraFeatureComboBox;
        private System.Windows.Forms.Label label6;
    }
}
