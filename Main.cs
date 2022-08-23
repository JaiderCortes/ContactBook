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
    public partial class Main : Form
    {
        //Define a private variable to connect with the business logic layer
        public BusinessLogicLayer _businessLogicLayer;

        public Main()
        {
            InitializeComponent();
            //Create a new instance of business logic layer inside the constructor
            _businessLogicLayer = new BusinessLogicLayer();
        }

        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Call the method that calls the ContactDetails window
            OpenContactDetailsDiag();
        }

        #endregion Events

        #region PrivateMethos

        private void OpenContactDetailsDiag()
        {
            /*
             * Instantiate the class ContactDetails wich is the WinForM that allows
             * the edit or insert of a new contact, to call it when the add button
             * is pressed
             */
            ContactDetails cd = new ContactDetails();
            cd.ShowDialog(this);
        }

        #endregion PrivateMethods

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        /*
         * This methos will load the contacts from the database on the grid
         */
        public void PopulateContacts()
        {
            List<Contact> contact = _businessLogicLayer.GetContacts();
            gridContacts.DataSource = contact;
        }
    }
}
