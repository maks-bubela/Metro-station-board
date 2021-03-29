using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class Form1 : Form
    {
        ArrayList fileText = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            violationsBox.Hide();
        }

        private void adButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            StreamReader file = new StreamReader(filename);
            for (int i = 0; i < 10; i++)
                fileText.Add(file.ReadLine());
            MessageBox.Show("Файл открыт");
        }
    }
}
