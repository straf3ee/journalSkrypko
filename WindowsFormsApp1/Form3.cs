﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.бДДДDataSet.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.бДДДDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.бДДДDataSet.Студенты);

        }
    }
}
