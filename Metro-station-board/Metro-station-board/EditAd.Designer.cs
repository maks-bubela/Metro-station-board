
namespace Metro_station_board
{
    partial class EditAd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddAdText = new System.Windows.Forms.TextBox();
            this.AddAdLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddAdText
            // 
            this.AddAdText.Location = new System.Drawing.Point(667, 53);
            this.AddAdText.Name = "AddAdText";
            this.AddAdText.Size = new System.Drawing.Size(149, 22);
            this.AddAdText.TabIndex = 1;
            // 
            // AddAdLabel
            // 
            this.AddAdLabel.AutoSize = true;
            this.AddAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdLabel.Location = new System.Drawing.Point(663, 12);
            this.AddAdLabel.Name = "AddAdLabel";
            this.AddAdLabel.Size = new System.Drawing.Size(61, 20);
            this.AddAdLabel.TabIndex = 2;
            this.AddAdLabel.Text = "Add ad";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(837, 52);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 401);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddAdLabel);
            this.Controls.Add(this.AddAdText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditAd";
            this.Text = "EditAd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AddAdText;
        private System.Windows.Forms.Label AddAdLabel;
        private System.Windows.Forms.Button AddButton;
    }
}