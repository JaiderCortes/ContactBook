using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class ContactDetails : Form
    {
        //Define a private variable to connect with the business logic layer
        public BusinessLogicLayer _businessLogicLayer;
        
        //Global variable of contact type
        private Contact _contact;
        public ContactDetails()
        {
            InitializeComponent();
            //Create a new instance of business logic layer inside the constructor
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
            ((Main)this.Owner).PopulateContacts();
        }

        private void SaveContact()
        {
            /*
             * Take and assign each property of the contact class to the 
             * content in each label 
             */
            Contact cont = new Contact();
            cont.FirstName = txtFirstName.Text;
            cont.LastName = txtLastName.Text;
            cont.Phone = txtPhone.Text;
            cont.Address = txtAddress.Text;

            cont.Id = _contact != null ? _contact.Id : 0;

            _businessLogicLayer.SaveContact(cont);
        }

        public void LoadContact(Contact contact)
        {
            //Validate if the text box are empty 
            _contact = contact;
            if(contact != null)
            {
                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtPhone.Text = contact.Phone;
                txtAddress.Text = contact.Address;
            }
        }

        public void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
