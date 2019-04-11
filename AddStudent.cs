using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MwalimuApp
{
    public partial class AddStudent : MaterialSkin.Controls.MaterialForm
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void StudentDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataDataSet);

        }

        private void EditData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataDataSet.marksInfo' table. You can move, or remove it, as needed.
            this.marksInfoTableAdapter.Fill(this.studentDataDataSet.marksInfo);
            // TODO: This line of code loads data into the 'studentDataDataSet.StudentDetails' table. You can move, or remove it, as needed.
            this.studentDetailsTableAdapter.Fill(this.studentDataDataSet.StudentDetails);

        }
    }
}
