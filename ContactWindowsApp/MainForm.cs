using ContactBusnisLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ContactWindowsApp
{
    public partial class MainForm : Form
    {
        AddNewClient addNewClient;

        public MainForm()
        {
            InitializeComponent();
            UploadContactToDataGridView();
        }

        public void UploadContactToDataGridView()
        {
            DataTable dt = clsContact.GetContacts();

            ContactGridView.DataSource = dt;
        }

        private void AddNewContactButton_Click(object sender, EventArgs e)
        {
            addNewClient = new AddNewClient(-1);
            addNewClient.ShowDialog();
            UploadContactToDataGridView();   
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addNewClient = new AddNewClient((int)ContactGridView.CurrentRow.Cells[0].Value);
            addNewClient.ShowDialog();
            UploadContactToDataGridView();
        }

        private void ContactGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                ContactGridView.ClearSelection();
                ContactGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this contact ?", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int contactID = (int)ContactGridView.CurrentRow.Cells[0].Value;
                if (clsContact.DeleteContact(contactID))
                {
                    MessageBox.Show("Contact Deleted Succufly");
                    UploadContactToDataGridView();
                }
                else
                {
                    MessageBox.Show("Faild To Delete Contact");
                }
                
            }

        }
    }
}
