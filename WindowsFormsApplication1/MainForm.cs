using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 6/11/16: One DataSet multipe Tables(Book & Author). Need 1 adapter(qry) per tbl, 1 BindingSrc from DataSet.Member to GridView
 *          remv: DataSet1, AuthorTableAdapter, renamme AuthorTableAdapter1 (no 1),
 *                  remv TableAdapterManager
 * 
 */

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet1.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter1.Fill(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Author);
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
            int n = _aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book.Count();
            MessageBox.Show(n.ToString());
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.authorTableAdapter1.FillBy(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Author);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
