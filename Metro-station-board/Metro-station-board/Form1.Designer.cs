
namespace Metro_station_board
{
    partial class Form1
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
            this.contolPanelLabel = new System.Windows.Forms.Label();
            this.adSourseLabel = new System.Windows.Forms.Label();
            this.adButton = new System.Windows.Forms.Button();
            this.dataOfScheduleLabel = new System.Windows.Forms.Label();
            this.getDataButton = new System.Windows.Forms.Button();
            this.violationsBox = new System.Windows.Forms.TextBox();
            this.tableButton = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contolPanelLabel
            // 
            this.contolPanelLabel.AutoSize = true;
            this.contolPanelLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contolPanelLabel.Location = new System.Drawing.Point(268, 18);
            this.contolPanelLabel.Name = "contolPanelLabel";
            this.contolPanelLabel.Size = new System.Drawing.Size(243, 50);
            this.contolPanelLabel.TabIndex = 0;
            this.contolPanelLabel.Text = "Control Panel";
            // 
            // adSourseLabel
            // 
            this.adSourseLabel.AutoSize = true;
            this.adSourseLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adSourseLabel.Location = new System.Drawing.Point(49, 103);
            this.adSourseLabel.Name = "adSourseLabel";
            this.adSourseLabel.Size = new System.Drawing.Size(253, 38);
            this.adSourseLabel.TabIndex = 1;
            this.adSourseLabel.Text = "Set up ad sourse  : ";
            // 
            // adButton
            // 
            this.adButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adButton.Location = new System.Drawing.Point(81, 144);
            this.adButton.Name = "adButton";
            this.adButton.Size = new System.Drawing.Size(170, 63);
            this.adButton.TabIndex = 2;
            this.adButton.Text = "Set up sourse";
            this.adButton.UseVisualStyleBackColor = true;
            this.adButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // dataOfScheduleLabel
            // 
            this.dataOfScheduleLabel.AutoSize = true;
            this.dataOfScheduleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataOfScheduleLabel.Location = new System.Drawing.Point(431, 103);
            this.dataOfScheduleLabel.Name = "dataOfScheduleLabel";
            this.dataOfScheduleLabel.Size = new System.Drawing.Size(379, 38);
            this.dataOfScheduleLabel.TabIndex = 3;
            this.dataOfScheduleLabel.Text = "Data on schedule violations : ";
            // 
            // getDataButton
            // 
            this.getDataButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getDataButton.Location = new System.Drawing.Point(538, 144);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(170, 63);
            this.getDataButton.TabIndex = 4;
            this.getDataButton.Text = "Get data";
            this.getDataButton.UseVisualStyleBackColor = true;
            // 
            // violationsBox
            // 
            this.violationsBox.Location = new System.Drawing.Point(272, 144);
            this.violationsBox.Multiline = true;
            this.violationsBox.Name = "violationsBox";
            this.violationsBox.Size = new System.Drawing.Size(243, 138);
            this.violationsBox.TabIndex = 5;
            // 
            // tableButton
            // 
            this.tableButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableButton.Location = new System.Drawing.Point(300, 353);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(170, 63);
            this.tableButton.TabIndex = 7;
            this.tableButton.Text = "Table Forms";
            this.tableButton.UseVisualStyleBackColor = true;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLabel.Location = new System.Drawing.Point(268, 312);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(247, 38);
            this.tableLabel.TabIndex = 6;
            this.tableLabel.Text = "Go to table forms :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.violationsBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.dataOfScheduleLabel);
            this.Controls.Add(this.adButton);
            this.Controls.Add(this.adSourseLabel);
            this.Controls.Add(this.contolPanelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.Label adSourseLabel;
        private System.Windows.Forms.Button adButton;
        private System.Windows.Forms.Label dataOfScheduleLabel;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox violationsBox;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Label tableLabel;
    }
}

