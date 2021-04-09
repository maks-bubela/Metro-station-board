
namespace Metro_station_board
{
    partial class ChangeAd
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeAdText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(224, 57);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeAdText
            // 
            this.ChangeAdText.Location = new System.Drawing.Point(12, 58);
            this.ChangeAdText.Name = "ChangeAdText";
            this.ChangeAdText.Size = new System.Drawing.Size(155, 22);
            this.ChangeAdText.TabIndex = 1;
            // 
            // ChangeAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 138);
            this.Controls.Add(this.ChangeAdText);
            this.Controls.Add(this.ChangeButton);
            this.Name = "ChangeAd";
            this.Text = "ChangeAd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox ChangeAdText;
    }
}