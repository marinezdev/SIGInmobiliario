﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class Email
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string asunto { get; set; }
        public string telefono { get; set; }
        public string mensaje { get; set; }
        public string recaptcha { get; set; }
    }

    public class CorreoEmail
    {
        public List<Email> email { get; set; }
    }
}
