using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {

        }
        public EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }
        public override string ToString()
        {
            return $"{Name}, {Address} {ZipCode}";
        }
    }
}
