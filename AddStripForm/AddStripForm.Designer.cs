namespace AddStripForm
{
    partial class AddStripForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStripForm));
            this.lstbx = new System.Windows.Forms.ListBox();
            this.grpbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbxUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateInstruction = new System.Windows.Forms.Label();
            this.lblEnterInstruction = new System.Windows.Forms.Label();
            this.txtbxEnter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grpbxUpdate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.Location = new System.Drawing.Point(13, 35);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(120, 290);
            this.lstbx.TabIndex = 0;
            this.lstbx.SelectedIndexChanged += new System.EventHandler(this.lstbx_SelectedIndexChanged);
            // 
            // grpbxUpdate
            // 
            this.grpbxUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpbxUpdate.Controls.Add(this.btnInsert);
            this.grpbxUpdate.Controls.Add(this.btnDelete);
            this.grpbxUpdate.Controls.Add(this.btnUpdate);
            this.grpbxUpdate.Controls.Add(this.txtbxUpdate);
            this.grpbxUpdate.Location = new System.Drawing.Point(161, 188);
            this.grpbxUpdate.Name = "grpbxUpdate";
            this.grpbxUpdate.Size = new System.Drawing.Size(298, 137);
            this.grpbxUpdate.TabIndex = 1;
            this.grpbxUpdate.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(205, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbxUpdate
            // 
            this.txtbxUpdate.Location = new System.Drawing.Point(39, 20);
            this.txtbxUpdate.Name = "txtbxUpdate";
            this.txtbxUpdate.Size = new System.Drawing.Size(206, 20);
            this.txtbxUpdate.TabIndex = 0;
            // 
            // lblUpdateInstruction
            // 
            this.lblUpdateInstruction.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblUpdateInstruction.AutoSize = true;
            this.lblUpdateInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInstruction.Location = new System.Drawing.Point(158, 147);
            this.lblUpdateInstruction.Name = "lblUpdateInstruction";
            this.lblUpdateInstruction.Size = new System.Drawing.Size(318, 20);
            this.lblUpdateInstruction.TabIndex = 2;
            this.lblUpdateInstruction.Text = "To make changes select a line in the list first";
            // 
            // lblEnterInstruction
            // 
            this.lblEnterInstruction.AutoSize = true;
            this.lblEnterInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInstruction.Location = new System.Drawing.Point(158, 35);
            this.lblEnterInstruction.Name = "lblEnterInstruction";
            this.lblEnterInstruction.Size = new System.Drawing.Size(316, 20);
            this.lblEnterInstruction.TabIndex = 3;
            this.lblEnterInstruction.Text = "Enter your calculations in the text box below";
            // 
            // txtbxEnter
            // 
            this.txtbxEnter.Location = new System.Drawing.Point(161, 76);
            this.txtbxEnter.Name = "txtbxEnter";
            this.txtbxEnter.Size = new System.Drawing.Size(206, 20);
            this.txtbxEnter.TabIndex = 4;
            this.txtbxEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxEnter_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator1,
            this.menuPrint,
            this.toolStripSeparator2,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(123, 22);
            this.menuNew.Text = "New.";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(123, 22);
            this.menuOpen.Text = "Open...";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(123, 22);
            this.menuSave.Text = "Save...";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(123, 22);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(123, 22);
            this.menuPrint.Text = "Print";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(123, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Calculation files (*.cal)|*.cal";
            this.openFileDialog1.InitialDirectory = "C:\\temp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Calculation files (*.cal)|*.cal";
            this.saveFileDialog1.InitialDirectory = "C:\\temp";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AddStripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 343);
            this.Controls.Add(this.txtbxEnter);
            this.Controls.Add(this.lblEnterInstruction);
            this.Controls.Add(this.lblUpdateInstruction);
            this.Controls.Add(this.grpbxUpdate);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddStripForm";
            this.Text = "AddStripForm";
            this.grpbxUpdate.ResumeLayout(false);
            this.grpbxUpdate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.GroupBox grpbxUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbxUpdate;
        private System.Windows.Forms.Label lblUpdateInstruction;
        private System.Windows.Forms.Label lblEnterInstruction;
        private System.Windows.Forms.TextBox txtbxEnter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

