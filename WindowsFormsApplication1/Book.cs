using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Book : Form
    {
        int bookPK;

        public Book(int pkParam)
        {
            bookPK = pkParam;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookPK > 0)
            {
                UpdateRow();
            }
            else
            {
                InsertRow();
            }
        }

        private void InsertRow()
        {
            throw new NotImplementedException();
        }

        private int UpdateRow()
        {
            SqlParameter[] parameters = {
                new SqlParameter("@title", txtTitle.Text),
                new SqlParameter("@bookPK", bookPK)
            };
            try
            {
                using (DbConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eConnectionString"].ConnectionString;
                    using (DbCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update Book set title = @title where BookID = @bookPK ";

                        foreach (var parameter in parameters)
                        {
                            if (parameter != null)
                                command.Parameters.Add(parameter);
                        }

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.FillBy(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.Book, bookPK);
        }
    }
}

