using Metro_station_board.Context;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class EditAd : Form
    {
        private MetroStationBoardContext adContext = new MetroStationBoardContext();
        private AdRepository adRepository = new AdRepository(new MetroStationBoardContext());
        public EditAd()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.DataSource = adContext.adModels.ToList();
            addButtonToDataGrid(3, "Change", Color.Green);
            addButtonToDataGrid(4, "Delete", Color.Red);
        }

        private void addButtonToDataGrid(int dataSize, string text, Color color)
        {
            if (dataGridView1.Columns.Count < dataSize)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = text;
                btn.UseColumnTextForButtonValue = true;
                btn.FlatStyle = FlatStyle.Flat;
                btn.CellTemplate.Style.BackColor = color;
                btn.CellTemplate.Style.ForeColor = Color.White;
                dataGridView1.Columns.Add(btn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "Change")
            {
                ChangeAd changeAd = new ChangeAd(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()));
                changeAd.ShowDialog();
                this.Close();
            }
            if (e.ColumnIndex == 1 && dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Delete")
            {
                if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    adRepository.deleteFromDB(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()));
                }
            }
            UpdateTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            adRepository.addToDB(AddAdText.Text);
            UpdateTable();
        }
    }
}
