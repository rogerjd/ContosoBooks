using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet1.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet1.Author);
            // TODO: This line of code loads data into the '_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.SelectedRows[0].Cells[0];

            Book book = new Book((int)cell.Value);
            DialogResult dr = book.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                bookTableAdapter.Fill(_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog(this);
        }
    }
}
