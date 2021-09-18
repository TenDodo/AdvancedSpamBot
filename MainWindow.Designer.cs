
namespace AdvancedSpamBot
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.previewWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.writeVariableButton = new System.Windows.Forms.Button();
            this.addOperationOnVariableButton = new System.Windows.Forms.Button();
            this.onStartWaitMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.onStartWaitCheckBox = new System.Windows.Forms.CheckBox();
            this.addTextFromFileButton = new System.Windows.Forms.Button();
            this.ctrlAltShiftButton = new System.Windows.Forms.Button();
            this.loopsAmountMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.loopsAmountCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.addKeyPressButton = new System.Windows.Forms.Button();
            this.addTimeBreakRangeButton = new System.Windows.Forms.Button();
            this.addTimeBreakButton = new System.Windows.Forms.Button();
            this.addTextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.errorsPanel = new System.Windows.Forms.Panel();
            this.errorsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorsBotDisplayPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.aP2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.aP1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errorsTopDisplayPanel = new System.Windows.Forms.Panel();
            this.warningsAmountLabel = new System.Windows.Forms.Label();
            this.errorsAmountLabel = new System.Windows.Forms.Label();
            this.botCommandsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.botBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addIntegerVariableButton = new System.Windows.Forms.Button();
            this.importVariablesButton = new System.Windows.Forms.Button();
            this.exportVariablesButton = new System.Windows.Forms.Button();
            this.variablesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.errorsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.errorsSearchTimer = new System.Windows.Forms.Timer(this.components);
            this.addExtraFeaturesButton = new System.Windows.Forms.Button();
            this.controlsPanel.SuspendLayout();
            this.errorsPanel.SuspendLayout();
            this.errorsBotDisplayPanel.SuspendLayout();
            this.errorsTopDisplayPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlsPanel.Controls.Add(this.addExtraFeaturesButton);
            this.controlsPanel.Controls.Add(this.previewWindowCheckBox);
            this.controlsPanel.Controls.Add(this.writeVariableButton);
            this.controlsPanel.Controls.Add(this.addOperationOnVariableButton);
            this.controlsPanel.Controls.Add(this.onStartWaitMaskedTextBox);
            this.controlsPanel.Controls.Add(this.onStartWaitCheckBox);
            this.controlsPanel.Controls.Add(this.addTextFromFileButton);
            this.controlsPanel.Controls.Add(this.ctrlAltShiftButton);
            this.controlsPanel.Controls.Add(this.loopsAmountMaskedTextBox);
            this.controlsPanel.Controls.Add(this.loopsAmountCheckBox);
            this.controlsPanel.Controls.Add(this.startButton);
            this.controlsPanel.Controls.Add(this.addKeyPressButton);
            this.controlsPanel.Controls.Add(this.addTimeBreakRangeButton);
            this.controlsPanel.Controls.Add(this.addTimeBreakButton);
            this.controlsPanel.Controls.Add(this.addTextButton);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.exportButton);
            this.controlsPanel.Controls.Add(this.importButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(200, 514);
            this.controlsPanel.TabIndex = 0;
            // 
            // previewWindowCheckBox
            // 
            this.previewWindowCheckBox.AutoSize = true;
            this.previewWindowCheckBox.Location = new System.Drawing.Point(5, 380);
            this.previewWindowCheckBox.Name = "previewWindowCheckBox";
            this.previewWindowCheckBox.Size = new System.Drawing.Size(175, 19);
            this.previewWindowCheckBox.TabIndex = 16;
            this.previewWindowCheckBox.Text = "Show small preview window";
            this.previewWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // writeVariableButton
            // 
            this.writeVariableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.writeVariableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.writeVariableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeVariableButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeVariableButton.Location = new System.Drawing.Point(5, 270);
            this.writeVariableButton.Name = "writeVariableButton";
            this.writeVariableButton.Size = new System.Drawing.Size(189, 25);
            this.writeVariableButton.TabIndex = 15;
            this.writeVariableButton.Text = "Write variable";
            this.writeVariableButton.UseVisualStyleBackColor = false;
            this.writeVariableButton.Click += new System.EventHandler(this.writeVariableButton_Click);
            // 
            // addOperationOnVariableButton
            // 
            this.addOperationOnVariableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addOperationOnVariableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addOperationOnVariableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOperationOnVariableButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOperationOnVariableButton.Location = new System.Drawing.Point(5, 239);
            this.addOperationOnVariableButton.Name = "addOperationOnVariableButton";
            this.addOperationOnVariableButton.Size = new System.Drawing.Size(189, 25);
            this.addOperationOnVariableButton.TabIndex = 14;
            this.addOperationOnVariableButton.Text = "Add operation on variable";
            this.addOperationOnVariableButton.UseVisualStyleBackColor = false;
            this.addOperationOnVariableButton.Click += new System.EventHandler(this.addOperationOnVariableButton_Click);
            // 
            // onStartWaitMaskedTextBox
            // 
            this.onStartWaitMaskedTextBox.AllowPromptAsInput = false;
            this.onStartWaitMaskedTextBox.Enabled = false;
            this.onStartWaitMaskedTextBox.HidePromptOnLeave = true;
            this.onStartWaitMaskedTextBox.Location = new System.Drawing.Point(106, 405);
            this.onStartWaitMaskedTextBox.Mask = "00000000";
            this.onStartWaitMaskedTextBox.Name = "onStartWaitMaskedTextBox";
            this.onStartWaitMaskedTextBox.PromptChar = ' ';
            this.onStartWaitMaskedTextBox.Size = new System.Drawing.Size(89, 23);
            this.onStartWaitMaskedTextBox.TabIndex = 13;
            // 
            // onStartWaitCheckBox
            // 
            this.onStartWaitCheckBox.AutoSize = true;
            this.onStartWaitCheckBox.Location = new System.Drawing.Point(5, 407);
            this.onStartWaitCheckBox.Name = "onStartWaitCheckBox";
            this.onStartWaitCheckBox.Size = new System.Drawing.Size(93, 19);
            this.onStartWaitCheckBox.TabIndex = 12;
            this.onStartWaitCheckBox.Text = "On start wait";
            this.onStartWaitCheckBox.UseVisualStyleBackColor = true;
            this.onStartWaitCheckBox.CheckedChanged += new System.EventHandler(this.onStartWaitCheckBox_CheckedChanged);
            // 
            // addTextFromFileButton
            // 
            this.addTextFromFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addTextFromFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addTextFromFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTextFromFileButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTextFromFileButton.Location = new System.Drawing.Point(5, 84);
            this.addTextFromFileButton.Name = "addTextFromFileButton";
            this.addTextFromFileButton.Size = new System.Drawing.Size(190, 25);
            this.addTextFromFileButton.TabIndex = 11;
            this.addTextFromFileButton.Text = "Add text from file";
            this.addTextFromFileButton.UseVisualStyleBackColor = false;
            this.addTextFromFileButton.Click += new System.EventHandler(this.addTextFromFileButton_Click);
            // 
            // ctrlAltShiftButton
            // 
            this.ctrlAltShiftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ctrlAltShiftButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.ctrlAltShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlAltShiftButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrlAltShiftButton.Location = new System.Drawing.Point(5, 146);
            this.ctrlAltShiftButton.Name = "ctrlAltShiftButton";
            this.ctrlAltShiftButton.Size = new System.Drawing.Size(190, 25);
            this.ctrlAltShiftButton.TabIndex = 10;
            this.ctrlAltShiftButton.Text = "Hold (Ctrl, Alt, Shift)";
            this.ctrlAltShiftButton.UseVisualStyleBackColor = false;
            this.ctrlAltShiftButton.Click += new System.EventHandler(this.ctrlAltShiftButton_Click);
            // 
            // loopsAmountMaskedTextBox
            // 
            this.loopsAmountMaskedTextBox.AllowPromptAsInput = false;
            this.loopsAmountMaskedTextBox.Enabled = false;
            this.loopsAmountMaskedTextBox.HidePromptOnLeave = true;
            this.loopsAmountMaskedTextBox.Location = new System.Drawing.Point(106, 432);
            this.loopsAmountMaskedTextBox.Mask = "00000000";
            this.loopsAmountMaskedTextBox.Name = "loopsAmountMaskedTextBox";
            this.loopsAmountMaskedTextBox.PromptChar = ' ';
            this.loopsAmountMaskedTextBox.Size = new System.Drawing.Size(89, 23);
            this.loopsAmountMaskedTextBox.TabIndex = 9;
            // 
            // loopsAmountCheckBox
            // 
            this.loopsAmountCheckBox.AutoSize = true;
            this.loopsAmountCheckBox.Location = new System.Drawing.Point(5, 434);
            this.loopsAmountCheckBox.Name = "loopsAmountCheckBox";
            this.loopsAmountCheckBox.Size = new System.Drawing.Size(103, 19);
            this.loopsAmountCheckBox.TabIndex = 8;
            this.loopsAmountCheckBox.Text = "Loops amount";
            this.loopsAmountCheckBox.UseVisualStyleBackColor = true;
            this.loopsAmountCheckBox.CheckedChanged += new System.EventHandler(this.loopsAmountCheckBox_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.startButton.FlatAppearance.BorderSize = 5;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.Location = new System.Drawing.Point(5, 461);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(190, 50);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addKeyPressButton
            // 
            this.addKeyPressButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addKeyPressButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.addKeyPressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKeyPressButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addKeyPressButton.Location = new System.Drawing.Point(5, 115);
            this.addKeyPressButton.Name = "addKeyPressButton";
            this.addKeyPressButton.Size = new System.Drawing.Size(190, 25);
            this.addKeyPressButton.TabIndex = 6;
            this.addKeyPressButton.Text = "Add Key Press";
            this.addKeyPressButton.UseVisualStyleBackColor = false;
            this.addKeyPressButton.Click += new System.EventHandler(this.addKeyPressButton_Click);
            // 
            // addTimeBreakRangeButton
            // 
            this.addTimeBreakRangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addTimeBreakRangeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addTimeBreakRangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTimeBreakRangeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTimeBreakRangeButton.Location = new System.Drawing.Point(5, 208);
            this.addTimeBreakRangeButton.Name = "addTimeBreakRangeButton";
            this.addTimeBreakRangeButton.Size = new System.Drawing.Size(190, 25);
            this.addTimeBreakRangeButton.TabIndex = 5;
            this.addTimeBreakRangeButton.Text = "Add Time Break (Range)";
            this.addTimeBreakRangeButton.UseVisualStyleBackColor = false;
            this.addTimeBreakRangeButton.Click += new System.EventHandler(this.addTimeBreakRangeButton_Click);
            // 
            // addTimeBreakButton
            // 
            this.addTimeBreakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addTimeBreakButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addTimeBreakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTimeBreakButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTimeBreakButton.Location = new System.Drawing.Point(5, 177);
            this.addTimeBreakButton.Name = "addTimeBreakButton";
            this.addTimeBreakButton.Size = new System.Drawing.Size(190, 25);
            this.addTimeBreakButton.TabIndex = 4;
            this.addTimeBreakButton.Text = "Add Time Break";
            this.addTimeBreakButton.UseVisualStyleBackColor = false;
            this.addTimeBreakButton.Click += new System.EventHandler(this.addTimeBreakButton_Click);
            // 
            // addTextButton
            // 
            this.addTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addTextButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTextButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTextButton.Location = new System.Drawing.Point(5, 53);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(190, 25);
            this.addTextButton.TabIndex = 3;
            this.addTextButton.Text = "Add text";
            this.addTextButton.UseVisualStyleBackColor = false;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add command block:";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.Silver;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportButton.Location = new System.Drawing.Point(105, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(90, 25);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.Silver;
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importButton.Location = new System.Drawing.Point(5, 5);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(90, 25);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // errorsPanel
            // 
            this.errorsPanel.Controls.Add(this.errorsFlowLayoutPanel);
            this.errorsPanel.Controls.Add(this.errorsBotDisplayPanel);
            this.errorsPanel.Controls.Add(this.errorsTopDisplayPanel);
            this.errorsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorsPanel.Location = new System.Drawing.Point(200, 414);
            this.errorsPanel.Name = "errorsPanel";
            this.errorsPanel.Size = new System.Drawing.Size(780, 100);
            this.errorsPanel.TabIndex = 1;
            // 
            // errorsFlowLayoutPanel
            // 
            this.errorsFlowLayoutPanel.AutoScroll = true;
            this.errorsFlowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.errorsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsFlowLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.errorsFlowLayoutPanel.Name = "errorsFlowLayoutPanel";
            this.errorsFlowLayoutPanel.Size = new System.Drawing.Size(780, 55);
            this.errorsFlowLayoutPanel.TabIndex = 2;
            // 
            // errorsBotDisplayPanel
            // 
            this.errorsBotDisplayPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorsBotDisplayPanel.Controls.Add(this.label4);
            this.errorsBotDisplayPanel.Controls.Add(this.aP2);
            this.errorsBotDisplayPanel.Controls.Add(this.label3);
            this.errorsBotDisplayPanel.Controls.Add(this.aP1);
            this.errorsBotDisplayPanel.Controls.Add(this.label2);
            this.errorsBotDisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorsBotDisplayPanel.Location = new System.Drawing.Point(0, 25);
            this.errorsBotDisplayPanel.Name = "errorsBotDisplayPanel";
            this.errorsBotDisplayPanel.Size = new System.Drawing.Size(780, 20);
            this.errorsBotDisplayPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(650, 0);
            this.label4.MinimumSize = new System.Drawing.Size(0, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Block Index";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aP2
            // 
            this.aP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aP2.Dock = System.Windows.Forms.DockStyle.Left;
            this.aP2.Location = new System.Drawing.Point(645, 0);
            this.aP2.Name = "aP2";
            this.aP2.Size = new System.Drawing.Size(5, 20);
            this.aP2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(95, 0);
            this.label3.MinimumSize = new System.Drawing.Size(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aP1
            // 
            this.aP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.aP1.Location = new System.Drawing.Point(90, 0);
            this.aP1.Name = "aP1";
            this.aP1.Size = new System.Drawing.Size(5, 20);
            this.aP1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.MinimumSize = new System.Drawing.Size(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorsTopDisplayPanel
            // 
            this.errorsTopDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorsTopDisplayPanel.Controls.Add(this.warningsAmountLabel);
            this.errorsTopDisplayPanel.Controls.Add(this.errorsAmountLabel);
            this.errorsTopDisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorsTopDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.errorsTopDisplayPanel.Name = "errorsTopDisplayPanel";
            this.errorsTopDisplayPanel.Size = new System.Drawing.Size(780, 25);
            this.errorsTopDisplayPanel.TabIndex = 0;
            // 
            // warningsAmountLabel
            // 
            this.warningsAmountLabel.AutoSize = true;
            this.warningsAmountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.warningsAmountLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningsAmountLabel.ForeColor = System.Drawing.Color.White;
            this.warningsAmountLabel.Image = ((System.Drawing.Image)(resources.GetObject("warningsAmountLabel.Image")));
            this.warningsAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warningsAmountLabel.Location = new System.Drawing.Point(112, 0);
            this.warningsAmountLabel.MinimumSize = new System.Drawing.Size(0, 25);
            this.warningsAmountLabel.Name = "warningsAmountLabel";
            this.warningsAmountLabel.Size = new System.Drawing.Size(97, 25);
            this.warningsAmountLabel.TabIndex = 1;
            this.warningsAmountLabel.Text = "        0 Warnings";
            this.warningsAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorsAmountLabel
            // 
            this.errorsAmountLabel.AutoSize = true;
            this.errorsAmountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.errorsAmountLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorsAmountLabel.ForeColor = System.Drawing.Color.White;
            this.errorsAmountLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorsAmountLabel.Image")));
            this.errorsAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorsAmountLabel.Location = new System.Drawing.Point(0, 0);
            this.errorsAmountLabel.MinimumSize = new System.Drawing.Size(0, 25);
            this.errorsAmountLabel.Name = "errorsAmountLabel";
            this.errorsAmountLabel.Size = new System.Drawing.Size(112, 25);
            this.errorsAmountLabel.TabIndex = 0;
            this.errorsAmountLabel.Text = "        0 Errors Found";
            this.errorsAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botCommandsFlowLayoutPanel
            // 
            this.botCommandsFlowLayoutPanel.AutoScroll = true;
            this.botCommandsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.botCommandsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botCommandsFlowLayoutPanel.Location = new System.Drawing.Point(200, 0);
            this.botCommandsFlowLayoutPanel.Name = "botCommandsFlowLayoutPanel";
            this.botCommandsFlowLayoutPanel.Size = new System.Drawing.Size(600, 414);
            this.botCommandsFlowLayoutPanel.TabIndex = 2;
            // 
            // botBackgroundWorker
            // 
            this.botBackgroundWorker.WorkerReportsProgress = true;
            this.botBackgroundWorker.WorkerSupportsCancellation = true;
            this.botBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.botBackgroundWorker_DoWork);
            this.botBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.botBackgroundWorker_ProgressChanged);
            this.botBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.botBackgroundWorker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addIntegerVariableButton);
            this.panel1.Controls.Add(this.importVariablesButton);
            this.panel1.Controls.Add(this.exportVariablesButton);
            this.panel1.Controls.Add(this.variablesFlowLayoutPanel);
            this.panel1.Controls.Add(this.historyTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 414);
            this.panel1.TabIndex = 0;
            // 
            // addIntegerVariableButton
            // 
            this.addIntegerVariableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addIntegerVariableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addIntegerVariableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIntegerVariableButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIntegerVariableButton.Location = new System.Drawing.Point(0, 25);
            this.addIntegerVariableButton.Name = "addIntegerVariableButton";
            this.addIntegerVariableButton.Size = new System.Drawing.Size(180, 25);
            this.addIntegerVariableButton.TabIndex = 4;
            this.addIntegerVariableButton.Text = "Add integer variable";
            this.addIntegerVariableButton.UseVisualStyleBackColor = false;
            this.addIntegerVariableButton.Click += new System.EventHandler(this.addIntegerVariableButton_Click);
            // 
            // importVariablesButton
            // 
            this.importVariablesButton.BackColor = System.Drawing.Color.Silver;
            this.importVariablesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.importVariablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importVariablesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importVariablesButton.Location = new System.Drawing.Point(0, 0);
            this.importVariablesButton.Margin = new System.Windows.Forms.Padding(0);
            this.importVariablesButton.Name = "importVariablesButton";
            this.importVariablesButton.Size = new System.Drawing.Size(90, 25);
            this.importVariablesButton.TabIndex = 3;
            this.importVariablesButton.Text = "Import";
            this.importVariablesButton.UseVisualStyleBackColor = false;
            this.importVariablesButton.Click += new System.EventHandler(this.importVariablesButton_Click);
            // 
            // exportVariablesButton
            // 
            this.exportVariablesButton.BackColor = System.Drawing.Color.Silver;
            this.exportVariablesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exportVariablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportVariablesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportVariablesButton.Location = new System.Drawing.Point(90, 0);
            this.exportVariablesButton.Margin = new System.Windows.Forms.Padding(0);
            this.exportVariablesButton.Name = "exportVariablesButton";
            this.exportVariablesButton.Size = new System.Drawing.Size(90, 25);
            this.exportVariablesButton.TabIndex = 2;
            this.exportVariablesButton.Text = "Export";
            this.exportVariablesButton.UseVisualStyleBackColor = false;
            this.exportVariablesButton.Click += new System.EventHandler(this.exportVariablesButton_Click);
            // 
            // variablesFlowLayoutPanel
            // 
            this.variablesFlowLayoutPanel.AutoScroll = true;
            this.variablesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.variablesFlowLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.variablesFlowLayoutPanel.Name = "variablesFlowLayoutPanel";
            this.variablesFlowLayoutPanel.Size = new System.Drawing.Size(180, 211);
            this.variablesFlowLayoutPanel.TabIndex = 1;
            // 
            // historyTextBox
            // 
            this.historyTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.historyTextBox.BackColor = System.Drawing.Color.Black;
            this.historyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyTextBox.CausesValidation = false;
            this.historyTextBox.DetectUrls = false;
            this.historyTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historyTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyTextBox.ForeColor = System.Drawing.Color.White;
            this.historyTextBox.Location = new System.Drawing.Point(0, 264);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(180, 150);
            this.historyTextBox.TabIndex = 0;
            this.historyTextBox.Text = "";
            this.historyTextBox.TextChanged += new System.EventHandler(this.historyTextBox_TextChanged);
            this.historyTextBox.Enter += new System.EventHandler(this.historyTextBox_Enter);
            // 
            // errorsBackgroundWorker
            // 
            this.errorsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.errorsBackgroundWorker_DoWork);
            this.errorsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.errorsBackgroundWorker_RunWorkerCompleted);
            // 
            // errorsSearchTimer
            // 
            this.errorsSearchTimer.Enabled = true;
            this.errorsSearchTimer.Interval = 300;
            this.errorsSearchTimer.Tick += new System.EventHandler(this.errorsSearchTimer_Tick);
            // 
            // addExtraFeaturesButton
            // 
            this.addExtraFeaturesButton.BackColor = System.Drawing.Color.Chocolate;
            this.addExtraFeaturesButton.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.addExtraFeaturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExtraFeaturesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addExtraFeaturesButton.Location = new System.Drawing.Point(5, 301);
            this.addExtraFeaturesButton.Name = "addExtraFeaturesButton";
            this.addExtraFeaturesButton.Size = new System.Drawing.Size(189, 25);
            this.addExtraFeaturesButton.TabIndex = 17;
            this.addExtraFeaturesButton.Text = "Add extra feature block";
            this.addExtraFeaturesButton.UseVisualStyleBackColor = false;
            this.addExtraFeaturesButton.Click += new System.EventHandler(this.addExtraFeaturesButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.botCommandsFlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorsPanel);
            this.Controls.Add(this.controlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Advanced Spam Bot";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.errorsPanel.ResumeLayout(false);
            this.errorsBotDisplayPanel.ResumeLayout(false);
            this.errorsTopDisplayPanel.ResumeLayout(false);
            this.errorsTopDisplayPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel errorsPanel;
        private System.Windows.Forms.Button addTimeBreakButton;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button addTimeBreakRangeButton;
        private System.Windows.Forms.Button addKeyPressButton;
        public System.Windows.Forms.FlowLayoutPanel botCommandsFlowLayoutPanel;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker botBackgroundWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox historyTextBox;
        private System.Windows.Forms.MaskedTextBox loopsAmountMaskedTextBox;
        private System.Windows.Forms.CheckBox loopsAmountCheckBox;
        private System.Windows.Forms.Button ctrlAltShiftButton;
        private System.Windows.Forms.Panel errorsTopDisplayPanel;
        private System.Windows.Forms.Panel errorsBotDisplayPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel aP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warningsAmountLabel;
        private System.Windows.Forms.Label errorsAmountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel aP2;
        private System.ComponentModel.BackgroundWorker errorsBackgroundWorker;
        private System.Windows.Forms.FlowLayoutPanel errorsFlowLayoutPanel;
        private System.Windows.Forms.Timer errorsSearchTimer;
        private System.Windows.Forms.Button addTextFromFileButton;
        private System.Windows.Forms.MaskedTextBox onStartWaitMaskedTextBox;
        private System.Windows.Forms.CheckBox onStartWaitCheckBox;
        private System.Windows.Forms.Button addIntegerVariableButton;
        private System.Windows.Forms.Button importVariablesButton;
        private System.Windows.Forms.Button exportVariablesButton;
        public System.Windows.Forms.FlowLayoutPanel variablesFlowLayoutPanel;
        private System.Windows.Forms.Button writeVariableButton;
        private System.Windows.Forms.Button addOperationOnVariableButton;
        private System.Windows.Forms.CheckBox previewWindowCheckBox;
        private System.Windows.Forms.Button addExtraFeaturesButton;
    }
}

