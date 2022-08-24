using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    /*
     * In this class we have all the business rules
     */
    public class BusinessLogicLayer
    {
        //Define a private variable to connect with the data access layer
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            //Create a new instance of data access layer inside a new constructor
            _dataAccessLayer = new DataAccessLayer();
        }

        /*
         * This method allows save the contact 
         */
        public Contact SaveContact(Contact cont)
        {
            if (cont.Id == 0)
            {
                _dataAccessLayer.InsertContact(cont);
            }
            else
            {
                _dataAccessLayer.UpdateContact(cont);
            }
            return cont;
        }

        /*
         * This method allows delete the contact 
         */
        public void DeleteContact(int id)
        {
            _dataAccessLayer.DeleteContact(id);
        }

        public List<Contact> GetContacts()
        {
            return _dataAccessLayer.GetContacts();
        }

    }
}
