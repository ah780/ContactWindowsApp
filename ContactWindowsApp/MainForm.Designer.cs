namespace ContactWindowsApp
{
    partial class MainForm
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
            this.AddNewContactButton = new System.Windows.Forms.Button();
            this.ContactGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewContactButton
            // 
            this.AddNewContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewContactButton.Location = new System.Drawing.Point(571, 12);
            this.AddNewContactButton.Name = "AddNewContactButton";
            this.AddNewContactButton.Size = new System.Drawing.Size(207, 63);
            this.AddNewContactButton.TabIndex = 1;
            this.AddNewContactButton.Text = "Add New Contact";
            this.AddNewContactButton.UseVisualStyleBackColor = true;
            this.AddNewContactButton.Click += new System.EventHandler(this.AddNewContactButton_Click);
            // 
            // ContactGridView
            // 
            this.ContactGridView.AllowUserToAddRows = false;
            this.ContactGridView.AllowUserToDeleteRows = false;
            this.ContactGridView.AllowUserToOrderColumns = true;
            this.ContactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.ContactGridView.Location = new System.Drawing.Point(11, 100);
            this.ContactGridView.Name = "ContactGridView";
            this.ContactGridView.ReadOnly = true;
            this.ContactGridView.RowHeadersWidth = 62;
            this.ContactGridView.RowTemplate.Height = 28;
            this.ContactGridView.Size = new System.Drawing.Size(787, 345);
            this.ContactGridView.TabIndex = 2;
            this.ContactGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactGridView_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 68);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 450);
            this.Controls.Add(this.AddNewContactButton);
            this.Controls.Add(this.ContactGridView);
            this.Name = "MainForm";
            this.Text = "FrmListContact";
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewContactButton;
        private System.Windows.Forms.DataGridView ContactGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

