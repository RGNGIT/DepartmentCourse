using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentCourse
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            FillDirGrid();
        }

        void FillDptGrid() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewDpt.DataSource = db.SelectScript("SELECT Id as Ключ, Name as Название, ShortName as 'Короткое название', Rod as 'Родительный падеж', Dat as 'Дательный падеж', (SELECT Name FROM department b WHERE b.Id = a.HeadDepartmentId) as 'Головное подразделение' FROM department a;");
        }

        void FillDptHeadOfficeCombo() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTemp.DataSource = db.SelectScript("SELECT * FROM department;");

            comboBoxDptHeadOffice.Items.Clear();

            for (int i = 0; i < dataGridViewTemp.Rows.Count - 1; i++)
                comboBoxDptHeadOffice.Items.Add($"{dataGridViewTemp.Rows[i].Cells[0].Value} {dataGridViewTemp.Rows[i].Cells[1].Value}");
        }

        void FillRoomTypeCombo() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTemp.DataSource = db.SelectScript("SELECT * FROM room_type;");
            
            comboBoxRoomType.Items.Clear();

            for (int i = 0; i < dataGridViewTemp.Rows.Count - 1; i++)
                comboBoxRoomType.Items.Add($"{dataGridViewTemp.Rows[i].Cells[0].Value} {dataGridViewTemp.Rows[i].Cells[1].Value}"); 
        }

        void FillRoomsGrid() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewRooms.DataSource = db.SelectScript("SELECT room.Id as Ключ, Number as Номер, Square as Площадь, Name as 'Тип помещения' FROM room JOIN room_type ON room.Id = room_type.Id;");
        }

        void FillDirGrid() 
        {
            string[] scripts = new string[2]
            {
                "SELECT Id as Ключ, Name as Название FROM room_type;",
                "SELECT Id as Ключ, Name as Название FROM action;"
            };

            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewDirs.DataSource = db.SelectScript(scripts[tabControlActionName.SelectedIndex]);
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
            {
                switch (tabControlActionName.SelectedIndex)
                {
                    case 0:
                        db.AddRoomType(textBoxRoomTypeName.Text);
                        break;
                    case 1:
                        db.AddAction(textBoxActionName.Text);
                        break;
                }
            }

            FillDirGrid();
        }

        private void tabControlActionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDirGrid();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    FillRoomsGrid();
                    FillRoomTypeCombo();
                    break;
                case 2:
                    FillDptGrid();
                    FillDptHeadOfficeCombo();
                    break;
            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
                db.AddRoom(textBoxRoomNumber.Text, Convert.ToSingle(textBoxRoomSquare.Text), Convert.ToInt32(comboBoxRoomType.Text.Split(' ')[0]));

            FillRoomsGrid();
        }

        private void buttonAddDpt_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
                db.AddDepartment(textBoxDptName.Text, textBoxDptShName.Text, textBoxDptRod.Text, textBoxDptDat.Text, comboBoxDptHeadOffice.Text);

            FillDptGrid();
            FillDptHeadOfficeCombo();
        }
    }
}
