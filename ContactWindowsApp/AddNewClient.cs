using ContactBusnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWindowsApp
{
    public partial class AddNewClient: Form
    {
      
        enum enMode { AddNew = -1, Update = 1 };
        enMode mode ;

        private int _contactID;
        private clsContact contact;
        public AddNewClient(int id)
        {
            InitializeComponent();
            
            _contactID = id;

            if(id == -1)
                mode = enMode.AddNew;
            else
                mode = enMode.Update;
            _UploadData();
        }


        public void UploadCountryToComboBox()
        {
            DataTable dt = ContactBusnisLayer.clsCountry.GetCountries();
            cbCountry.DataSource = dt;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
        }

        private void _UploadData()
        {

            UploadCountryToComboBox();

            if (mode == enMode.AddNew)
            {
                labelMode.Text = "Add New Client";
                contact = new clsContact();
                return;
            }

            contact = clsContact.Find(_contactID);

            if (contact == null)
            {
                MessageBox.Show("Faild to Update You Should close this Page ", "Eror", MessageBoxButtons.OK);
                return;
            }

            labelMode.Text = "Updtae Contact ID = "+ contact.Id.ToString();
            labelContactID.Text = contact.Id.ToString();

            tbFirstName.Text = contact.FirstName;
            tbLastName.Text = contact.LastName;
            tbEmail.Text = contact.Email;
            tbAdress.Text = contact.Address; 
            mtbPhone.Text = contact.Phone;
            dtbDateOfBirth.Value = contact.BirthData;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(contact.CountryID).CountryName);

            if(contact.ImagePath != "")
            {
                pictureBox1.Load(contact.ImagePath);
            }

            llremoveImage.Visible = (contact.ImagePath != "");

        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int countryID = Convert.ToInt32(cbCountry.SelectedValue);

            contact.FirstName = tbFirstName.Text;
            contact.LastName = tbLastName.Text;
            contact.Email = tbEmail.Text;
            contact.Phone = mtbPhone.Text;
            contact.Address = tbAdress.Text;
            contact.BirthData = dtbDateOfBirth.Value;
            contact.CountryID = countryID;
            if (pictureBox1.Image != null)
            {
                contact.ImagePath = pictureBox1.ImageLocation.ToString();
            }
            else
            {
                contact.ImagePath = "";
            }

            if (contact.Save())
            {
                MessageBox.Show("Data Saved Succufly.");
            }
            else
            {
                MessageBox.Show("Faild to Save Data.");
            }


            mode = enMode.Update;
            labelMode.Text = "Update Contact ID = " + contact.Id.ToString();
            labelContactID.Text = contact.Id.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();

            if(file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llremoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
