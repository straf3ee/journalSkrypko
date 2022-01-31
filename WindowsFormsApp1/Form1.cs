using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.бДДДDataSet.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.бДДДDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДДDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.бДДДDataSet.Студенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Update(this.бДДДDataSet.Студенты);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.предметыTableAdapter.Update(this.бДДДDataSet.Предметы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.оценкиTableAdapter.Update(this.бДДДDataSet.Оценки);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            Form3 form3 = new Form3();
            //Form4 form4 = new Form4();

            //form1.Close();
            //form3.Show();
            //form4.Show();
        }
    }
}
