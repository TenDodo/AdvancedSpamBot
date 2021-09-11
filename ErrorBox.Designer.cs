
namespace AdvancedSpamBot
{
    partial class ErrorBox
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.aP1 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.aP2 = new System.Windows.Forms.Panel();
            this.blockIndexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeLabel.Location = new System.Drawing.Point(0, 0);
            this.typeLabel.MinimumSize = new System.Drawing.Size(0, 20);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(90, 25);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aP1
            // 
            this.aP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.aP1.Location = new System.Drawing.Point(90, 0);
            this.aP1.Name = "aP1";
            this.aP1.Size = new System.Drawing.Size(5, 25);
            this.aP1.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(95, 0);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(0, 20);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(550, 25);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aP2
            // 
            this.aP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aP2.Dock = System.Windows.Forms.DockStyle.Left;
            this.aP2.Location = new System.Drawing.Point(645, 0);
            this.aP2.Name = "aP2";
            this.aP2.Size = new System.Drawing.Size(5, 25);
            this.aP2.TabIndex = 4;
            // 
            // blockIndexLabel
            // 
            this.blockIndexLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.blockIndexLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blockIndexLabel.Location = new System.Drawing.Point(650, 0);
            this.blockIndexLabel.MinimumSize = new System.Drawing.Size(0, 20);
            this.blockIndexLabel.Name = "blockIndexLabel";
            this.blockIndexLabel.Size = new System.Drawing.Size(80, 25);
            this.blockIndexLabel.TabIndex = 5;
            this.blockIndexLabel.Text = "Block Index";
            this.blockIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.blockIndexLabel);
            this.Controls.Add(this.aP2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.aP1);
            this.Controls.Add(this.typeLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ErrorBox";
            this.Size = new System.Drawing.Size(730, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel aP1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel aP2;
        private System.Windows.Forms.Label blockIndexLabel;
    }
}
