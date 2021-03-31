
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
            this.sourseButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.adButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // sourseButton
            // 
            this.sourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourseButton.Location = new System.Drawing.Point(12, 68);
            this.sourseButton.Name = "sourseButton";
            this.sourseButton.Size = new System.Drawing.Size(151, 71);
            this.sourseButton.TabIndex = 6;
            this.sourseButton.Text = "Set up sourse";
            this.sourseButton.UseVisualStyleBackColor = true;
            this.sourseButton.Click += new System.EventHandler(this.sourseButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.Location = new System.Drawing.Point(169, 68);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(151, 71);
            this.dataButton.TabIndex = 7;
            this.dataButton.Text = "Get violoations data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableButton.Location = new System.Drawing.Point(640, 68);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(151, 71);
            this.tableButton.TabIndex = 8;
            this.tableButton.Text = "Get Tables";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleButton.Location = new System.Drawing.Point(326, 68);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(151, 71);
            this.scheduleButton.TabIndex = 9;
            this.scheduleButton.Text = "Get schedule data";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // adButton
            // 
            this.adButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adButton.Location = new System.Drawing.Point(483, 68);
            this.adButton.Name = "adButton";
            this.adButton.Size = new System.Drawing.Size(151, 71);
            this.adButton.TabIndex = 10;
            this.adButton.Text = "Get ad data";
            this.adButton.UseVisualStyleBackColor = true;
            this.adButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 293);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.sourseButton);
            this.Controls.Add(this.contolPanelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.Button sourseButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button adButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

