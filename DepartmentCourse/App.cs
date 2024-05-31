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
                dataGridViewDpt.DataSource = db.SelectScript("SELECT id_department as Ключ, name as Название, shortname as 'Короткое название', rod as 'Родительный падеж', dat as 'Дательный падеж', (SELECT name FROM department b WHERE b.id_department = a.id_head_department) as 'Головное подразделение' FROM department a;");
        }

        void FillDocGrid() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewDocs.DataSource = db.SelectScript("SELECT id as Ключ, name as Название, Date_zakrepleniya as 'Дата закрепления', Data_peredachi as 'Дата передачи' FROM document;");
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
                dataGridViewRooms.DataSource = db.SelectScript("SELECT a.idroom as Ключ, a.name as Имя, Square as Площадь, c.name as Корпус, b.name as 'Тип помещения' FROM room a JOIN room_type b ON a.idroom = b.idroom_type JOIN campus c ON a.idcampus = c.idcampus;");
        }

        void FillDirGrid()
        {
            string[] scripts = new string[2]
            {
                "SELECT idroom_type as Ключ, Name as Название FROM room_type;",
                "SELECT idroom as Ключ, Name as Название FROM action;"
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

        void FillDocumentCombos() 
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTemp.DataSource = db.SelectScript("SELECT * FROM room;");

            comboBoxDocRoom.Items.Clear();

            for (int i = 0; i < dataGridViewTemp.Rows.Count - 1; i++)
                comboBoxDocRoom.Items.Add($"{dataGridViewTemp.Rows[i].Cells[0].Value} {dataGridViewTemp.Rows[i].Cells[1].Value}");

            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTemp.DataSource = db.SelectScript("SELECT * FROM department;");

            comboBoxDocDpt.Items.Clear();

            for (int i = 0; i < dataGridViewTemp.Rows.Count - 1; i++)
                comboBoxDocDpt.Items.Add($"{dataGridViewTemp.Rows[i].Cells[0].Value} {dataGridViewTemp.Rows[i].Cells[1].Value}");
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
                case 3:
                    FillDocGrid();
                    FillDocumentCombos();
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

        private void buttonAddDoc_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
                db.AddDocument(textBoxDocName.Text, dateTimeClaim.Value.ToString(), dateTimeGive.Value.ToString(), Convert.ToInt32(comboBoxDocRoom.Text.Split(' ')[0]), Convert.ToInt32(comboBoxDocDpt.Text.Split(' ')[0]));

            FillDocGrid();
        }

        private void task1_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTask1.DataSource = db.SelectScript($"SELECT a.name as Подразделение, c.name as Помещение, d.name as 'Тип помещения' FROM department a JOIN document b ON b.DepartamentID = a.id_department JOIN room c ON b.RoomID = c.idroom JOIN room_type d ON c.idroomtype = d.idroom_type WHERE b.Date_zakrepleniya >= '{dateTimePickerTask1From.Value.ToString("yyyy-MM-dd")}' AND b.Date_zakrepleniya <= '{dateTimePickerTask1To.Value.ToString("yyyy-MM-dd")}' ORDER BY a.name;");
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1) 
            {
                using (DatabaseWorks db = new DatabaseWorks())
                    dataGridViewTask2.DataSource = db.SelectScript($"WITH RECURSIVE DepartmentHierarchy AS (   SELECT       id_department,        name,       id_head_department,      0 AS level    FROM        Department   WHERE       id_head_department = 0   UNION ALL   SELECT      d.id_department,       d.name,      d.id_head_department,     dh.level + 1 AS level   FROM       Department d    INNER JOIN       DepartmentHierarchy dh ON d.id_head_department = dh.id_department)SELECT    id_department,   name,    (select s.name from department s where s.id_department = id_head_department) as 'Головное подразделение',   level as 'Глубина' FROM    DepartmentHierarchy ORDER BY    level, id_department;");
            }

            if (tabControl2.SelectedIndex == 2) 
            {
                using (DatabaseWorks db = new DatabaseWorks())
                    dataGridViewTemp.DataSource = db.SelectScript("SELECT * FROM department;");

                comboBoxTask3Dpt.Items.Clear();

                for (int i = 0; i < dataGridViewTemp.Rows.Count - 1; i++)
                    comboBoxTask3Dpt.Items.Add($"{dataGridViewTemp.Rows[i].Cells[0].Value} {dataGridViewTemp.Rows[i].Cells[1].Value}");
            }
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            using (DatabaseWorks db = new DatabaseWorks())
                dataGridViewTask3.DataSource = db.SelectScript($"SELECT a.name as Подразделение, c.name as Помещение, d.name as 'Тип помещения', (SELECT SUM(aa.square) FROM room aa, document bb WHERE bb.id = b.id AND bb.RoomID = aa.idroom) as 'Добавочная площадь', b.Date_zakrepleniya as 'Дата закрепления' FROM department a JOIN document b ON b.DepartamentID = a.id_department JOIN room c ON b.RoomID = c.idroom JOIN room_type d ON c.idroomtype = d.idroom_type WHERE b.Date_zakrepleniya >= '{dateTimePickerTask3From.Value.ToString("yyyy-MM-dd")}' AND b.Date_zakrepleniya <= '{dateTimePickerTask3To.Value.ToString("yyyy-MM-dd")}' AND a.id_department = '{comboBoxTask3Dpt.Text.Split(' ')[0]}' ORDER BY a.name;");
        }
    }
}
