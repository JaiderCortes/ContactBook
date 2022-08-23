using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    /*
     * This class is a representation of the data stored in the database, 
     * specifically each contact
     */
    public class Contact
    {
        //Define each property that is equal to each fiel on the database
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
