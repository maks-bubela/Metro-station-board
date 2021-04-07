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
    public partial class AddAdWindow : Form
    {
        private AdRepository adRepository = new AdRepository(new Context.MetroStationBoardContext());

        public AddAdWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            adRepository.addToDB(AddAdText.Text);
            this.Close();
        }
    }
}
