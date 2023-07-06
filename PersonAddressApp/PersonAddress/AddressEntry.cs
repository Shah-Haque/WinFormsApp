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
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = StreetAddress_TextBox.Text,
                Town = Town_TextBox.Text,
                County = County_TextBox.Text,
                PostCode = PostCode_TextBox.Text
            };

            _parent.SaveAddress(address);

            Close();
        }
    }
}
