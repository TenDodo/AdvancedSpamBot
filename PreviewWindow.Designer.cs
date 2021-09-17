
namespace AdvancedSpamBot
{
    partial class PreviewWindow
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
            this.stopButton = new System.Windows.Forms.Button();
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.stopButton.FlatAppearance.BorderSize = 5;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.Location = new System.Drawing.Point(0, 0);
            this.stopButton.Margin = new System.Windows.Forms.Padding(0);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(79, 111);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // historyTextBox
            // 
            this.historyTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.historyTextBox.BackColor = System.Drawing.Color.Black;
            this.historyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyTextBox.CausesValidation = false;
            this.historyTextBox.DetectUrls = false;
            this.historyTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyTextBox.ForeColor = System.Drawing.Color.White;
            this.historyTextBox.Location = new System.Drawing.Point(79, 0);
            this.historyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(255, 111);
            this.historyTextBox.TabIndex = 9;
            this.historyTextBox.Text = "";
            // 
            // PreviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.ControlBox = false;
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.stopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewWindow";
            this.Text = "PreviewWindow";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button stopButton;
        public System.Windows.Forms.RichTextBox historyTextBox;
    }
}