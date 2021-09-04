namespace KeyboardOfLegends
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.LabelRunning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(12, 42);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(281, 32);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start ArrowKeys Hook";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Crimson;
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(12, 80);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(281, 32);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop ArrowKeys Hook";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.LightBlue;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHelp.Location = new System.Drawing.Point(108, 156);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(75, 23);
            this.ButtonHelp.TabIndex = 2;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // LabelRunning
            // 
            this.LabelRunning.AutoSize = true;
            this.LabelRunning.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRunning.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelRunning.Location = new System.Drawing.Point(75, 122);
            this.LabelRunning.Name = "LabelRunning";
            this.LabelRunning.Size = new System.Drawing.Size(138, 23);
            this.LabelRunning.TabIndex = 3;
            this.LabelRunning.Text = "Hook Running ...";
            this.LabelRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 185);
            this.Controls.Add(this.LabelRunning);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Keyboard of Legends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Label LabelRunning;
    }
}

