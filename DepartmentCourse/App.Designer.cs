namespace DepartmentCourse
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewDirs = new System.Windows.Forms.DataGridView();
            this.tabControlActionName = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomTypeName = new System.Windows.Forms.TextBox();
            this.textBoxActionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomSquare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.dataGridViewTemp = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewDpt = new System.Windows.Forms.DataGridView();
            this.buttonAddDpt = new System.Windows.Forms.Button();
            this.textBoxDptShName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDptName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDptRod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDptDat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDptHeadOffice = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            this.buttonAddDoc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirs)).BeginInit();
            this.tabControlActionName.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDpt)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 449);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddDir);
            this.tabPage1.Controls.Add(this.tabControlActionName);
            this.tabPage1.Controls.Add(this.dataGridViewDirs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Справочники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddRoom);
            this.tabPage2.Controls.Add(this.comboBoxRoomType);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxRoomSquare);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxRoomNumber);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridViewRooms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Помещения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDirs
            // 
            this.dataGridViewDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirs.Location = new System.Drawing.Point(252, 6);
            this.dataGridViewDirs.Name = "dataGridViewDirs";
            this.dataGridViewDirs.Size = new System.Drawing.Size(531, 408);
            this.dataGridViewDirs.TabIndex = 0;
            // 
            // tabControlActionName
            // 
            this.tabControlActionName.Controls.Add(this.tabPage3);
            this.tabControlActionName.Controls.Add(this.tabPage4);
            this.tabControlActionName.Location = new System.Drawing.Point(7, 6);
            this.tabControlActionName.Name = "tabControlActionName";
            this.tabControlActionName.SelectedIndex = 0;
            this.tabControlActionName.Size = new System.Drawing.Size(239, 379);
            this.tabControlActionName.TabIndex = 1;
            this.tabControlActionName.SelectedIndexChanged += new System.EventHandler(this.tabControlActionName_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxRoomTypeName);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(231, 353);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Тип помещения";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxActionName);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(231, 353);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Действие";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(11, 391);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(235, 23);
            this.buttonAddDir.TabIndex = 2;
            this.buttonAddDir.Text = "Добавить";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxRoomTypeName
            // 
            this.textBoxRoomTypeName.Location = new System.Drawing.Point(9, 19);
            this.textBoxRoomTypeName.Name = "textBoxRoomTypeName";
            this.textBoxRoomTypeName.Size = new System.Drawing.Size(216, 20);
            this.textBoxRoomTypeName.TabIndex = 1;
            // 
            // textBoxActionName
            // 
            this.textBoxActionName.Location = new System.Drawing.Point(9, 19);
            this.textBoxActionName.Name = "textBoxActionName";
            this.textBoxActionName.Size = new System.Drawing.Size(216, 20);
            this.textBoxActionName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(252, 6);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(531, 408);
            this.dataGridViewRooms.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(10, 22);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(236, 20);
            this.textBoxRoomNumber.TabIndex = 3;
            // 
            // textBoxRoomSquare
            // 
            this.textBoxRoomSquare.Location = new System.Drawing.Point(10, 59);
            this.textBoxRoomSquare.Name = "textBoxRoomSquare";
            this.textBoxRoomSquare.Size = new System.Drawing.Size(236, 20);
            this.textBoxRoomSquare.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип помещения";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(10, 98);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(236, 21);
            this.comboBoxRoomType.TabIndex = 7;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(11, 391);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(235, 23);
            this.buttonAddRoom.TabIndex = 8;
            this.buttonAddRoom.Text = "Добавить";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // dataGridViewTemp
            // 
            this.dataGridViewTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemp.Location = new System.Drawing.Point(806, 24);
            this.dataGridViewTemp.Name = "dataGridViewTemp";
            this.dataGridViewTemp.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTemp.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxDptHeadOffice);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.textBoxDptDat);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.textBoxDptRod);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.textBoxDptShName);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.textBoxDptName);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.buttonAddDpt);
            this.tabPage5.Controls.Add(this.dataGridViewDpt);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(791, 423);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Подразделение";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDpt
            // 
            this.dataGridViewDpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDpt.Location = new System.Drawing.Point(252, 6);
            this.dataGridViewDpt.Name = "dataGridViewDpt";
            this.dataGridViewDpt.Size = new System.Drawing.Size(531, 408);
            this.dataGridViewDpt.TabIndex = 2;
            // 
            // buttonAddDpt
            // 
            this.buttonAddDpt.Location = new System.Drawing.Point(11, 391);
            this.buttonAddDpt.Name = "buttonAddDpt";
            this.buttonAddDpt.Size = new System.Drawing.Size(235, 23);
            this.buttonAddDpt.TabIndex = 9;
            this.buttonAddDpt.Text = "Добавить";
            this.buttonAddDpt.UseVisualStyleBackColor = true;
            this.buttonAddDpt.Click += new System.EventHandler(this.buttonAddDpt_Click);
            // 
            // textBoxDptShName
            // 
            this.textBoxDptShName.Location = new System.Drawing.Point(10, 59);
            this.textBoxDptShName.Name = "textBoxDptShName";
            this.textBoxDptShName.Size = new System.Drawing.Size(236, 20);
            this.textBoxDptShName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Короткое название";
            // 
            // textBoxDptName
            // 
            this.textBoxDptName.Location = new System.Drawing.Point(10, 22);
            this.textBoxDptName.Name = "textBoxDptName";
            this.textBoxDptName.Size = new System.Drawing.Size(236, 20);
            this.textBoxDptName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Название";
            // 
            // textBoxDptRod
            // 
            this.textBoxDptRod.Location = new System.Drawing.Point(10, 98);
            this.textBoxDptRod.Name = "textBoxDptRod";
            this.textBoxDptRod.Size = new System.Drawing.Size(236, 20);
            this.textBoxDptRod.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Родительный падеж";
            // 
            // textBoxDptDat
            // 
            this.textBoxDptDat.Location = new System.Drawing.Point(11, 137);
            this.textBoxDptDat.Name = "textBoxDptDat";
            this.textBoxDptDat.Size = new System.Drawing.Size(236, 20);
            this.textBoxDptDat.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дательный падеж";
            // 
            // comboBoxDptHeadOffice
            // 
            this.comboBoxDptHeadOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDptHeadOffice.FormattingEnabled = true;
            this.comboBoxDptHeadOffice.Location = new System.Drawing.Point(11, 176);
            this.comboBoxDptHeadOffice.Name = "comboBoxDptHeadOffice";
            this.comboBoxDptHeadOffice.Size = new System.Drawing.Size(236, 21);
            this.comboBoxDptHeadOffice.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Головное подразделение";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonAddDoc);
            this.tabPage6.Controls.Add(this.dataGridViewDocs);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(791, 423);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Документы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Location = new System.Drawing.Point(252, 6);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.Size = new System.Drawing.Size(531, 408);
            this.dataGridViewDocs.TabIndex = 3;
            // 
            // buttonAddDoc
            // 
            this.buttonAddDoc.Location = new System.Drawing.Point(11, 391);
            this.buttonAddDoc.Name = "buttonAddDoc";
            this.buttonAddDoc.Size = new System.Drawing.Size(235, 23);
            this.buttonAddDoc.TabIndex = 10;
            this.buttonAddDoc.Text = "Добавить";
            this.buttonAddDoc.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.dataGridViewTemp);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "App";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirs)).EndInit();
            this.tabControlActionName.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDpt)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlActionName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewDirs;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomTypeName;
        private System.Windows.Forms.TextBox textBoxActionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoomSquare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.DataGridView dataGridViewTemp;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxDptShName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDptName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddDpt;
        private System.Windows.Forms.DataGridView dataGridViewDpt;
        private System.Windows.Forms.TextBox textBoxDptDat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDptRod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDptHeadOffice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewDocs;
        private System.Windows.Forms.Button buttonAddDoc;
    }
}

