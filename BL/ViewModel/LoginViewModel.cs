﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
 public   class LoginViewModel
    {

        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string PasswordHash { get; set; }
    }
}
