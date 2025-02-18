﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutor.Enums;

namespace Tutor.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}