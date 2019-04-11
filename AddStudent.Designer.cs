namespace MwalimuApp
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.studentDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataDataSet = new MwalimuApp.StudentDataDataSet();
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
            this.studentDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marksInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailsTableAdapter = new MwalimuApp.StudentDataDataSetTableAdapters.StudentDetailsTableAdapter();
            this.tableAdapterManager = new MwalimuApp.StudentDataDataSetTableAdapters.TableAdapterManager();
            this.marksInfoTableAdapter = new MwalimuApp.StudentDataDataSetTableAdapters.marksInfoTableAdapter();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingNavigator)).BeginInit();
            this.studentDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDetailsBindingNavigator
            // 
            this.studentDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentDetailsBindingNavigator.BindingSource = this.studentDetailsBindingSource;
            this.studentDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentDetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentDetailsBindingNavigatorSaveItem});
            this.studentDetailsBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.studentDetailsBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.studentDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentDetailsBindingNavigator.Name = "studentDetailsBindingNavigator";
            this.studentDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentDetailsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.studentDetailsBindingNavigator.TabIndex = 0;
            this.studentDetailsBindingNavigator.Text = "bindingNavigator1";
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
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "StudentDetails";
            this.studentDetailsBindingSource.DataSource = this.studentDataDataSet;
            // 
            // studentDataDataSet
            // 
            this.studentDataDataSet.DataSetName = "StudentDataDataSet";
            this.studentDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // studentDetailsBindingNavigatorSaveItem
            // 
            this.studentDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentDetailsBindingNavigatorSaveItem.Image")));
            this.studentDetailsBindingNavigatorSaveItem.Name = "studentDetailsBindingNavigatorSaveItem";
            this.studentDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.StudentDetailsBindingNavigatorSaveItem_Click);
            // 
            // marksInfoBindingSource
            // 
            this.marksInfoBindingSource.DataMember = "marksInfo";
            this.marksInfoBindingSource.DataSource = this.studentDataDataSet;
            // 
            // studentDetailsTableAdapter
            // 
            this.studentDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.marksInfoTableAdapter = this.marksInfoTableAdapter;
            this.tableAdapterManager.StudentDetailsTableAdapter = this.studentDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MwalimuApp.StudentDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marksInfoTableAdapter
            // 
            this.marksInfoTableAdapter.ClearBeforeFill = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Admission Number";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(255, 149);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField1.TabIndex = 29;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(255, 184);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField2.TabIndex = 30;
            this.materialSingleLineTextField2.Text = "Student Name";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(255, 267);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField4.TabIndex = 32;
            this.materialSingleLineTextField4.Text = "Dorm";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(255, 223);
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField5.TabIndex = 33;
            this.materialSingleLineTextField5.Text = "Age";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.studentDetailsBindingNavigator);
            this.Name = "EditData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingNavigator)).EndInit();
            this.studentDetailsBindingNavigator.ResumeLayout(false);
            this.studentDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataDataSet studentDataDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private StudentDataDataSetTableAdapters.StudentDetailsTableAdapter studentDetailsTableAdapter;
        private StudentDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentDetailsBindingNavigatorSaveItem;
        private StudentDataDataSetTableAdapters.marksInfoTableAdapter marksInfoTableAdapter;
        private System.Windows.Forms.BindingSource marksInfoBindingSource;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
    }
}