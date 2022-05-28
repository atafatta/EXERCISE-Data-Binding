using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCISE3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Purple;

            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkBlue;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Maroon;
            }

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;

            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Blue;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Maroon;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.NIM.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm4.NamaMhs.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm4.AlamatMhs.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm4.JenKel.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm4.NoTel.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            frm4.Show();
        }
    }
}
