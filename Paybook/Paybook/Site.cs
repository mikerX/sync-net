﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaybookSDK
{
    public class Site
    {
        public string id_site { get; set; }
        public string id_site_organization { get; set; }
        public string id_site_organization_type { get; set; }
        public string name { get; set; }
        public List<Credentials_Structure> credentials { get; set; }
    }
}