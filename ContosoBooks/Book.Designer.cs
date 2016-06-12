namespace ContosoBooks
{
    partial class Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet = new ContosoBooks._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet();
            this.bookTableAdapter = new ContosoBooks._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSetTableAdapters.BookTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(37, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(75, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet;
            // 
            // _aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet
            // 
            this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.DataSetName = "_aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet";
            this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(308, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTitle;
        private _aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet _aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private _aspnet5_ContosoBooks_c51843ad_4ae8_461d_9be5_ba1f8442964eDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}