using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonAddressLibrary.Models
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public string AddressDisplayValue => $"{ StreetAddress }, { Town }, { County } { PostCode }";
    }
}