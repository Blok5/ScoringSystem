using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.InformationAboutClients {
    public partial class InfoAboutMan :Form {
        public InfoAboutMan() {
            InitializeComponent();
        }

        private void InfoAboutMan_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Mans". При необходимости она может быть перемещена или удалена.
            this.mansTableAdapter.Fill(this.bankDataSet.Mans);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }
    }
}
