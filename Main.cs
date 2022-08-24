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

        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validate if the click is on the edit link
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit" || cell.Value.ToString() == "edit")
            {
                /*
                 * Load the data of the road where was clicked the Edit button in a new
                 * contactDetails window
                 */
                ContactDetails cd = new ContactDetails();
                cd.LoadContact(new Contact
                {
                    Id = int.Parse((gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    FirstName = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString()
                });
                cd.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete" || cell.Value.ToString() == "delete")
            {
                /*
                 * Execute the delete query if the word of the link is equal to Delete.
                 * It receive the id of the contact that is clicked, like the edit method.
                 */
                int id = int.Parse((gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                DeleteContact(id);
                PopulateContacts();
            }
        }

        /*
         * Delete method that receive the id of the contact where is located the delete cell.
         * It comes from the business logic layer where is the call of the query.
         */
        private void DeleteContact(int id)
        {
            _businessLogicLayer.DeleteContact(id);
        }
    }
}
