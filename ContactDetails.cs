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

            _businessLogicLayer.SaveContact(cont);
        }
    }
}
