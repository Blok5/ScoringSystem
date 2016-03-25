using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
//TODO: Добавить транзакцию добавления всего класса в базу данных

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Класс AddRelationsForm открывает форму для добавления родственных 
    /// связей клиента
    /// </summary>
    public partial class AddRelationsForm :Form {

        public int x = 12;
        public int y = 41;

        public AddRelationsForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Метод addButton_Click добавляет очередной GroupBox 
        /// с элементами на форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e) {

            GroupBox gb = new GroupBox();
            gb.Location = new Point(x, y);
            gb.Size = new Size(250, 100);

            this.mansTableAdapter.Fill(this.bankDataSet.Mans);
            BindingSource bs = new BindingSource();
            bs.DataSource = bankDataSet.Mans;

            ComboBox surnameComboBox = new ComboBox();
            surnameComboBox.Location = new Point(10, 10);
            surnameComboBox.Size = new Size(200, 10);
            surnameComboBox.DataSource = bs;
            surnameComboBox.DisplayMember = "surname";
            surnameComboBox.ValueMember = "id";
            surnameComboBox.Name = "surnameComboBox";

            ComboBox nameComboBox = new ComboBox();
            nameComboBox.Location = new Point(10, 40);
            nameComboBox.Size = new Size(200, 10);
            nameComboBox.DataSource = bs;
            nameComboBox.DisplayMember = "name";
            nameComboBox.ValueMember = "id";
            nameComboBox.Name = "nameComboBox";

            this.relationsTableAdapter.Fill(this.bankDataSet._Relations);
            BindingSource bsRelation = new BindingSource();
            bsRelation.DataSource = bankDataSet._Relations;

            ComboBox cbRelation = new ComboBox();
            cbRelation.Location = new Point(10, 70);
            cbRelation.Size = new Size(200, 10);
            cbRelation.DataSource = bsRelation;
            cbRelation.DisplayMember = "relation";
            cbRelation.ValueMember = "id";
            cbRelation.Name = "relationComboBox";
            cbRelation.DropDownStyle = ComboBoxStyle.DropDownList;

            gb.Controls.AddRange(new Control[] { surnameComboBox, nameComboBox, cbRelation });

            Controls.Add(gb);
            y += 100;
        }

        private void addRelationsForm_Load(object sender, EventArgs e) {
        

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            AddWorkForm awf = new AddWorkForm();
            awf.Show();
        }
        /// <summary>
        /// При нажатии событие nextButton_Click пытается добавить
        /// связи к клиенту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e) {
            try {
                int count = 0;
                foreach (var gb in this.Controls.OfType<GroupBox>()) {
                    count++;
                }

                RelationsData[] relations = new RelationsData[count];

                int j = 0;
                foreach (var gb in this.Controls.OfType<GroupBox>()) {
                    relations[j] = new RelationsData();
                    foreach (var cb in gb.Controls.OfType<ComboBox>()) {
                        if (cb.Name == "nameComboBox") {
                            relations[j].id_man = cb.SelectedIndex;
                        } else if (cb.Name == "relationComboBox") {
                            relations[j].id_relation = cb.SelectedIndex;
                        }
                       
                    }
                ++j;
                                 
                }

                CurrentData.addRelation(relations);
                CurrentData.showValues();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.Source);
                
            }
        }
    }
}
