
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.timer1.Interval = 1000;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adLabel.Location = new System.Drawing.Point(12, 416);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(34, 25);
            this.adLabel.TabIndex = 12;
            this.adLabel.Text = "ad";
            // 
            // addonsMenu
            // 
            this.addonsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addonsMenu.Location = new System.Drawing.Point(0, 0);
            this.addonsMenu.Name = "addonsMenu";
            this.addonsMenu.Size = new System.Drawing.Size(800, 30);
            this.addonsMenu.TabIndex = 13;
            this.addonsMenu.Text = "menuStrip1";
            // 
            // MetroStationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.contolPanelLabel);
            this.Controls.Add(this.addonsMenu);
            this.MainMenuStrip = this.addonsMenu;
            this.Name = "MetroStationBoard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contolPanelLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.MenuStrip addonsMenu;
    }
}

