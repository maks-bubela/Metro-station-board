﻿
namespace Metro_station_board
{
    partial class MetroStationBoard
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
            this.components = new System.ComponentModel.Container();
            this.contolPanelLabel = new System.Windows.Forms.Label();
            this.dataButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.adButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.goTrainButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dispatchLabel = new System.Windows.Forms.Label();
            this.arriveLabel = new System.Windows.Forms.Label();
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
            // dataButton
            // 
            this.dataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.Location = new System.Drawing.Point(12, 66);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(192, 71);
            this.dataButton.TabIndex = 7;
            this.dataButton.Text = "Get violoations data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableButton.Location = new System.Drawing.Point(606, 66);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(185, 71);
            this.tableButton.TabIndex = 8;
            this.tableButton.Text = "Get Tables";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleButton.Location = new System.Drawing.Point(210, 66);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(192, 71);
            this.scheduleButton.TabIndex = 9;
            this.scheduleButton.Text = "Get schedule data";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // adButton
            // 
            this.adButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adButton.Location = new System.Drawing.Point(408, 66);
            this.adButton.Name = "adButton";
            this.adButton.Size = new System.Drawing.Size(192, 71);
            this.adButton.TabIndex = 10;
            this.adButton.Text = "Get ad data";
            this.adButton.UseVisualStyleBackColor = true;
            this.adButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 293);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(606, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(185, 71);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(606, 222);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(185, 71);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // goTrainButton
            // 
            this.goTrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goTrainButton.Location = new System.Drawing.Point(606, 299);
            this.goTrainButton.Name = "goTrainButton";
            this.goTrainButton.Size = new System.Drawing.Size(185, 71);
            this.goTrainButton.TabIndex = 14;
            this.goTrainButton.Text = "Go a train";
            this.goTrainButton.UseVisualStyleBackColor = true;
            this.goTrainButton.Click += new System.EventHandler(this.goTrainButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(606, 373);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(64, 25);
            this.timerLabel.TabIndex = 15;
            this.timerLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // dispatchLabel
            // 
            this.dispatchLabel.AutoSize = true;
            this.dispatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispatchLabel.Location = new System.Drawing.Point(606, 411);
            this.dispatchLabel.Name = "dispatchLabel";
            this.dispatchLabel.Size = new System.Drawing.Size(53, 20);
            this.dispatchLabel.TabIndex = 16;
            this.dispatchLabel.Text = "label2";
            // 
            // arriveLabel
            // 
            this.arriveLabel.AutoSize = true;
            this.arriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arriveLabel.Location = new System.Drawing.Point(710, 411);
            this.arriveLabel.Name = "arriveLabel";
            this.arriveLabel.Size = new System.Drawing.Size(53, 20);
            this.arriveLabel.TabIndex = 17;
            this.arriveLabel.Text = "label3";
            // 
            // MetroStationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arriveLabel);
            this.Controls.Add(this.dispatchLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.goTrainButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.contolPanelLabel);
            this.Name = "MetroStationBoard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button adButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button goTrainButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dispatchLabel;
        private System.Windows.Forms.Label arriveLabel;
    }
}
