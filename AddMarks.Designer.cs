namespace MwalimuApp
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.studentDataDataSet = new MwalimuApp.StudentDataDataSet();
            this.marksInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksInfoTableAdapter = new MwalimuApp.StudentDataDataSetTableAdapters.marksInfoTableAdapter();
            this.tableAdapterManager = new MwalimuApp.StudentDataDataSetTableAdapters.TableAdapterManager();
            this.marksInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.marksInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.textBoxLabelHrzs1 = new WPFWaterMarkTextBox.TextBoxLabelHrzs();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingNavigator)).BeginInit();
            this.marksInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataDataSet
            // 
            this.studentDataDataSet.DataSetName = "StudentDataDataSet";
            this.studentDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marksInfoBindingSource
            // 
            this.marksInfoBindingSource.DataMember = "marksInfo";
            this.marksInfoBindingSource.DataSource = this.studentDataDataSet;
            // 
            // marksInfoTableAdapter
            // 
            this.marksInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.marksInfoTableAdapter = this.marksInfoTableAdapter;
            this.tableAdapterManager.StudentDetailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MwalimuApp.StudentDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marksInfoBindingNavigator
            // 
            this.marksInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.marksInfoBindingNavigator.BindingSource = this.marksInfoBindingSource;
            this.marksInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.marksInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.marksInfoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marksInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.marksInfoBindingNavigatorSaveItem});
            this.marksInfoBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.marksInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.marksInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.marksInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.marksInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.marksInfoBindingNavigator.Name = "marksInfoBindingNavigator";
            this.marksInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.marksInfoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.marksInfoBindingNavigator.TabIndex = 0;
            this.marksInfoBindingNavigator.Text = "bindingNavigator1";
            this.marksInfoBindingNavigator.RefreshItems += new System.EventHandler(this.MarksInfoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // marksInfoBindingNavigatorSaveItem
            // 
            this.marksInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marksInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marksInfoBindingNavigatorSaveItem.Image")));
            this.marksInfoBindingNavigatorSaveItem.Name = "marksInfoBindingNavigatorSaveItem";
            this.marksInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.marksInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.marksInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.MarksInfoBindingNavigatorSaveItem_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(203, 172);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(177, 23);
            this.materialSingleLineTextField1.TabIndex = 13;
            this.materialSingleLineTextField1.Text = "Maths";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(57, 107);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(249, 23);
            this.materialSingleLineTextField2.TabIndex = 14;
            this.materialSingleLineTextField2.Text = "Admission Number";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(203, 349);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(177, 23);
            this.materialSingleLineTextField3.TabIndex = 15;
            this.materialSingleLineTextField3.Text = "Socialstudies/RE";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(203, 305);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(177, 23);
            this.materialSingleLineTextField4.TabIndex = 16;
            this.materialSingleLineTextField4.Text = "Science";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(203, 260);
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(177, 23);
            this.materialSingleLineTextField5.TabIndex = 17;
            this.materialSingleLineTextField5.Text = "Kiswahili";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(203, 214);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(177, 23);
            this.materialSingleLineTextField6.TabIndex = 18;
            this.materialSingleLineTextField6.Text = "English Marks";
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(341, 107);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 45);
            this.elementHost1.TabIndex = 19;
            this.elementHost1.Text = "Admission Number";
            this.elementHost1.Child = this.textBoxLabelHrzs1;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.materialSingleLineTextField6);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.marksInfoBindingNavigator);
            this.Name = "Add_Student";
            this.Text = "Add_Student";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingNavigator)).EndInit();
            this.marksInfoBindingNavigator.ResumeLayout(false);
            this.marksInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataDataSet studentDataDataSet;
        private System.Windows.Forms.BindingSource marksInfoBindingSource;
        private StudentDataDataSetTableAdapters.marksInfoTableAdapter marksInfoTableAdapter;
        private StudentDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator marksInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton marksInfoBindingNavigatorSaveItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WPFWaterMarkTextBox.TextBoxLabelHrzs textBoxLabelHrzs1;
    }
}