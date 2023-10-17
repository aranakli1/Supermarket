﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Providers
    {
        public int? Id { get; set; }
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Providers(int? id, string documentNumber, string name, string address, string phoneNumber, string email ) 
        { 
            Id = id;
            DocumentNumber = documentNumber;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }


    }
}
