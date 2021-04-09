
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.adLabel = new System.Windows.Forms.Label();
            this.addonsMenu = new System.Windows.Forms.MenuStrip();
            this.ForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditAd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addonsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contolPanelLabel
            // 
            this.contolPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contolPanelLabel.AutoSize = true;
            this.contolPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contolPanelLabel.Location = new System.Drawing.Point(285, 24);
            this.contolPanelLabel.Name = "contolPanelLabel";
            this.contolPanelLabel.Size = new System.Drawing.Size(223, 44);
            this.contolPanelLabel.TabIndex = 0;
            this.contolPanelLabel.Text = "Metro Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 334);
            this.dataGridView1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adLabel.Location = new System.Drawing.Point(739, 19);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(0, 25);
            this.adLabel.TabIndex = 12;
            // 
            // addonsMenu
            // 
            this.addonsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addonsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForecastToolStripMenuItem});
            this.addonsMenu.Location = new System.Drawing.Point(0, 0);
            this.addonsMenu.Name = "addonsMenu";
            this.addonsMenu.Size = new System.Drawing.Size(800, 28);
            this.addonsMenu.TabIndex = 13;
            this.addonsMenu.Text = "menuStrip1";
            this.addonsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.addonsMenu_ItemClicked);
            // 
            // ForecastToolStripMenuItem
            // 
            this.ForecastToolStripMenuItem.Name = "ForecastToolStripMenuItem";
            this.ForecastToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.ForecastToolStripMenuItem.Text = "Forecast";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.adLabel);
            this.panel1.Location = new System.Drawing.Point(12, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 14;
            // 
            // EditAd
            // 
            this.EditAd.Location = new System.Drawing.Point(12, 499);
            this.EditAd.Name = "EditAd";
            this.EditAd.Size = new System.Drawing.Size(75, 23);
            this.EditAd.TabIndex = 16;
            this.EditAd.Text = "Edit ad";
            this.EditAd.UseVisualStyleBackColor = true;
            this.EditAd.Click += new System.EventHandler(this.EditAd_Click);
            // 
            // MetroStationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.EditAd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.contolPanelLabel);
            this.Controls.Add(this.addonsMenu);
            this.MainMenuStrip = this.addonsMenu;
            this.Name = "MetroStationBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addonsMenu.ResumeLayout(false);
            this.addonsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.MenuStrip addonsMenu;
        private System.Windows.Forms.ToolStripMenuItem ForecastToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditAd;
    }
}

