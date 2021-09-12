
namespace AdvancedSpamBot
{
    partial class VariableBox
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
            this.variableNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.variableValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variableNameLabel
            // 
            this.variableNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.variableNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.variableNameLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.variableNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.variableNameLabel.Location = new System.Drawing.Point(21, 0);
            this.variableNameLabel.MinimumSize = new System.Drawing.Size(0, 20);
            this.variableNameLabel.Name = "variableNameLabel";
            this.variableNameLabel.Size = new System.Drawing.Size(59, 25);
            this.variableNameLabel.TabIndex = 2;
            this.variableNameLabel.Text = "vName";
            this.variableNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(80, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // variableValueMaskedTextBox
            // 
            this.variableValueMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.variableValueMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.variableValueMaskedTextBox.HidePromptOnLeave = true;
            this.variableValueMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.variableValueMaskedTextBox.Location = new System.Drawing.Point(103, 0);
            this.variableValueMaskedTextBox.Mask = "000000";
            this.variableValueMaskedTextBox.Name = "variableValueMaskedTextBox";
            this.variableValueMaskedTextBox.PromptChar = ' ';
            this.variableValueMaskedTextBox.Size = new System.Drawing.Size(57, 25);
            this.variableValueMaskedTextBox.TabIndex = 4;
            this.variableValueMaskedTextBox.Text = "0";
            this.variableValueMaskedTextBox.TextChanged += new System.EventHandler(this.variableValueMaskedTextBox_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(0, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(25, 25);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // VariableBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.variableNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variableValueMaskedTextBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VariableBox";
            this.Size = new System.Drawing.Size(160, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label variableNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox variableValueMaskedTextBox;
        private System.Windows.Forms.Button removeButton;
    }
}
