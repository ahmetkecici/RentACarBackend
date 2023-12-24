﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Mail { get; set; }
        public byte[] PasswordHash  { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }

    }
}

