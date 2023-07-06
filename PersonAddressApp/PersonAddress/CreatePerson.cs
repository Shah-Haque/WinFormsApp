using PersonAddressLibrary;
using PersonAddressLibrary.interfaces;
using PersonAddressLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAddress
{

    //52:11
    public partial class CreatePerson : Form, ISaveAddress
    {

        BindingList<AddressModel> Addresses = new BindingList<AddressModel>();

        public CreatePerson()
        {
            InitializeComponent();

            AddressListBox.DataSource = Addresses;
            AddressListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void AddNewAddress_Button_Click(object sender, EventArgs e)
        {
          
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }



        public void SaveAddress(AddressModel address)
        {
           Addresses.Add(address);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = FirstName_TextBox.Text,
                LastName = LastName_TextBox.Text,
                IsActive = IsActiveCheckBox.Checked,
                Addresses = Addresses.ToList()
            };

        }
    }
}
