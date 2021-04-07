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
    public partial class ChangeAd : Form
    {
        private AdRepository adRepository = new AdRepository(new Context.MetroStationBoardContext());
        private int currentId;
        public ChangeAd(int id)
        {
            InitializeComponent();
            currentId = id;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            adRepository.changeRecord(currentId, ChangeAdText.Text);
            EditAd editAd = new EditAd();
            editAd.Show();
            this.Close();
        }
    }
}
