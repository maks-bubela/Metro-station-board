
namespace Metro_station_board
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.contolPanelLabel = new System.Windows.Forms.Label();
            this.dataOfScheduleLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.adSourseLabel = new System.Windows.Forms.Label();
            this.adButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contolPanelLabel
            // 
            this.contolPanelLabel.AutoSize = true;
            this.contolPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contolPanelLabel.Location = new System.Drawing.Point(258, 19);
            this.contolPanelLabel.Name = "contolPanelLabel";
            this.contolPanelLabel.Size = new System.Drawing.Size(250, 44);
            this.contolPanelLabel.TabIndex = 0;
            this.contolPanelLabel.Text = "Control Panel";
            this.contolPanelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataOfScheduleLabel
            // 
            this.dataOfScheduleLabel.AutoSize = true;
            this.dataOfScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOfScheduleLabel.Location = new System.Drawing.Point(411, 97);
            this.dataOfScheduleLabel.Name = "dataOfScheduleLabel";
            this.dataOfScheduleLabel.Size = new System.Drawing.Size(386, 32);
            this.dataOfScheduleLabel.TabIndex = 1;
            this.dataOfScheduleLabel.Text = "Data on schedule violations : ";
            this.dataOfScheduleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLabel.Location = new System.Drawing.Point(260, 297);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(246, 32);
            this.tableLabel.TabIndex = 4;
            this.tableLabel.Text = "Go to table forms :";
            // 
            // adSourseLabel
            // 
            this.adSourseLabel.AutoSize = true;
            this.adSourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adSourseLabel.Location = new System.Drawing.Point(24, 97);
            this.adSourseLabel.Name = "adSourseLabel";
            this.adSourseLabel.Size = new System.Drawing.Size(257, 32);
            this.adSourseLabel.TabIndex = 5;
            this.adSourseLabel.Text = "Set up ad sourse  : ";
            this.adSourseLabel.Click += new System.EventHandler(this.adSourseLabel_Click);
            // 
            // adButton
            // 
            this.adButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adButton.Location = new System.Drawing.Point(67, 132);
            this.adButton.Name = "adButton";
            this.adButton.Size = new System.Drawing.Size(159, 71);
            this.adButton.TabIndex = 6;
            this.adButton.Text = "Set up sourse";
            this.adButton.UseVisualStyleBackColor = true;
            // 
            // dataButton
            // 
            this.dataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.Location = new System.Drawing.Point(527, 132);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(159, 71);
            this.dataButton.TabIndex = 7;
            this.dataButton.Text = "Get Data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableButton.Location = new System.Drawing.Point(297, 332);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(159, 71);
            this.tableButton.TabIndex = 8;
            this.tableButton.Text = "Get Table";
            this.tableButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 150);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.adButton);
            this.Controls.Add(this.adSourseLabel);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.dataOfScheduleLabel);
            this.Controls.Add(this.contolPanelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.Label dataOfScheduleLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label adSourseLabel;
        private System.Windows.Forms.Button adButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

