namespace _2020Tools
{
    partial class GitHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitHub));
            this.btnRF = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRF
            // 
            this.btnRF.Location = new System.Drawing.Point(290, 32);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(111, 23);
            this.btnRF.TabIndex = 0;
            this.btnRF.Text = "Refresh command";
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(26, 32);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(238, 20);
            this.txtCommand.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(26, 127);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(375, 50);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Commit To Server";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(26, 87);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(375, 20);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path Project";
            // 
            // txtRS
            // 
            this.txtRS.Location = new System.Drawing.Point(29, 197);
            this.txtRS.Name = "txtRS";
            this.txtRS.Size = new System.Drawing.Size(372, 212);
            this.txtRS.TabIndex = 3;
            this.txtRS.Text = "";
            // 
            // GitHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 433);
            this.Controls.Add(this.txtRS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnRF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GitHub";
            this.Text = "GitHub";
            this.Load += new System.EventHandler(this.GitHub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtRS;
    }
}

