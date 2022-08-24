using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    /*
     * In this class we can establish the connection to the database
     * and to all the queries that we will need to the good working of the app
     */
    public class DataAccessLayer
    {
        //Create the connection to the database
        private SqlConnection dbConn = new SqlConnection(
        "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ContactBook;Data Source=LAPTOP-JGK26CKK"
        );

        //Create the insert method
        public void InsertContact(Contact cont)
        {
            try
            {
                //Open the connection
                dbConn.Open();
                //Create the sql query, in this case, insert
                string sql = @"
                            INSERT INTO contact
                            (firstName, lastName, phone, address)
                            VALUES (@firstName, @lastName, @phone, @address)
                        ";

                //Set the parameter to replace the values of the query
                SqlParameter firstName = new SqlParameter("@firstName", cont.FirstName);
                SqlParameter lastName = new SqlParameter("@lastName", cont.LastName);
                SqlParameter phone = new SqlParameter("@phone", cont.Phone);
                SqlParameter address = new SqlParameter("@address", cont.Address);

                //Assing the command to execute with the query and the database connection
                SqlCommand command = new SqlCommand(sql, dbConn);

                //Assing the parameters to the command
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                //Execute the query
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                /*
                 * Close the connetion, it doesn't matter if an error comes out or not,
                 * we have to close the connetion, ALWAYS
                 */
                dbConn.Close();
            }
        }

        //Create the update method
        public void UpdateContact(Contact cont)
        {
            try
            {
                //Open the connection
                dbConn.Open();
                //Create the sql query, in this case, update
                string sql = @"
                            UPDATE contact SET
                                firstName = @firstName,
                                lastName = @lastName,
                                phone = @phone,
                                address = @address
                            WHERE id = @id
                        ";

                //Set the parameter to replace the values of the query
                SqlParameter id = new SqlParameter("@id", cont.Id);
                SqlParameter firstName = new SqlParameter("@firstName", cont.FirstName);
                SqlParameter lastName = new SqlParameter("@lastName", cont.LastName);
                SqlParameter phone = new SqlParameter("@phone", cont.Phone);
                SqlParameter address = new SqlParameter("@address", cont.Address);

                //Assing the command to execute with the query and the database connection
                SqlCommand command = new SqlCommand(sql, dbConn);

                //Assing the parameters to the command
                command.Parameters.Add(id);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                //Execute the query
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                /*
                 * Close the connetion, it doesn't matter if an error comes out or not,
                 * we have to close the connetion, ALWAYS
                 */
                dbConn.Close();
            }
        }

        //Create the delete method
        public void DeleteContact(int id)
        {
            try
            {
                //Open the connection
                dbConn.Open();
                //Create the sql query, in this case, delete
                string sql = @"DELETE FROM contact WHERE id = @id";

                //Assing the command to execute with the query and the database connection
                SqlCommand command = new SqlCommand(sql, dbConn);

                //Assing the parameters to the command
                command.Parameters.Add(new SqlParameter("@id", id));

                //Execute the query
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                /*
                 * Close the connetion, it doesn't matter if an error comes out or not,
                 * we have to close the connetion, ALWAYS
                 */
                dbConn.Close();
            }
        }

        //Create the select method to show the contacts on the grid
        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                dbConn.Open();
                string sql = @"
                                SELECT 
	                                id,
	                                firstName,
	                                lastName,
	                                phone,
	                                address
                                FROM contact
                            ";

                SqlCommand command = new SqlCommand(sql, dbConn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbConn.Close();
            }
            return contacts;
        }
    }
}
