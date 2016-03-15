using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class addRelationsForm :Form {

        public int x = 12;
        public int y = 41;
        public addRelationsForm() {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {

            GroupBox gb = new GroupBox();
            gb.Location = new Point(x, y);
            gb.Size = new Size(250, 100);

            this.mansTableAdapter.Fill(this.bankDataSet.Mans);
            BindingSource bs = new BindingSource();
            bs.DataSource = bankDataSet.Mans;

            ComboBox cb = new ComboBox();
            cb.Location = new Point(10, 10);
            cb.Size = new Size(200, 10);
            cb.DataSource = bs;
            cb.DisplayMember = "surname";
            cb.ValueMember = "id";

            ComboBox cb1 = new ComboBox();
            cb1.Location = new Point(10, 40);
            cb1.Size = new Size(200, 10);
            cb1.DataSource = bs;
            cb1.DisplayMember = "name";
            cb1.ValueMember = "id";

            this.relationsTableAdapter.Fill(this.bankDataSet._Relations);
            BindingSource bsRelation = new BindingSource();
            bsRelation.DataSource = bankDataSet._Relations;

            ComboBox cbRelation = new ComboBox();
            cbRelation.Location = new Point(10, 70);
            cbRelation.Size = new Size(200, 10);
            cbRelation.DataSource = bsRelation;
            cbRelation.DisplayMember = "relation";
            cbRelation.ValueMember = "id";
            cbRelation.DropDownStyle = ComboBoxStyle.DropDownList;

            gb.Controls.AddRange(new Control[] { cb, cb1, cbRelation });

            Controls.Add(gb);
            y += 100;
        }

        private void addRelationsForm_Load(object sender, EventArgs e) {
        

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            addWorkForm awf = new addWorkForm();
            awf.Show();
        }
    }
}
