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
    public partial class Add_Student : MaterialSkin.Controls.MaterialForm
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void MarksInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marksInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataDataSet);

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataDataSet.marksInfo' table. You can move, or remove it, as needed.
            this.marksInfoTableAdapter.Fill(this.studentDataDataSet.marksInfo);

        }

        private void MarksInfoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
