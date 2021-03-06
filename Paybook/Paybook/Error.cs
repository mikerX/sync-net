﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaybookSDK
{
    public class Error : Exception
    {
        public string code { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
        public HttpResponseMessage response { get; set; }
        public Error(string code, bool status, string message, HttpResponseMessage response) : base(message)
        {
            this.code = code;
            this.status = status;
            this.message = message;
            this.response = response;
        }
    }
}
