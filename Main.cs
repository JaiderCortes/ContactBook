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
        public Main()
        {
            InitializeComponent();
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
            cd.ShowDialog();
        }

        #endregion PrivateMethods
    }
}
