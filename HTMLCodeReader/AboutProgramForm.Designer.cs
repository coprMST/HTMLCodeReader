namespace VolgaIT_Kochetkov
{
    partial class AboutProgramForm
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
            this.mainText = new System.Windows.Forms.Label();
            this.myGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.BackColor = System.Drawing.Color.Transparent;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainText.Location = new System.Drawing.Point(12, 25);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(489, 100);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "Разработчик:\r\n\r\nПрограмма сделана для цифровой олимпиады «Волга-IT’XXI»\r\n\r\n2021 г" +
    ".";
            // 
            // myGitHub
            // 
            this.myGitHub.AutoSize = true;
            this.myGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myGitHub.Location = new System.Drawing.Point(119, 25);
            this.myGitHub.Name = "myGitHub";
            this.myGitHub.Size = new System.Drawing.Size(117, 20);
            this.myGitHub.TabIndex = 5;
            this.myGitHub.TabStop = true;
            this.myGitHub.Text = "Кочетков Е.М.";
            this.myGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myVK_LinkClicked);
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 135);
            this.Controls.Add(this.myGitHub);
            this.Controls.Add(this.mainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgramForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.LinkLabel myGitHub;
    }
}