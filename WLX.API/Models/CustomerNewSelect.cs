﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WLX.API.Models
{
    public class CustomerNewSelect
    {
       // c_num,c_Name,c_sex,c_address,c_birthday,c_identity
        public string c_num { get; set; }
        public string c_Name { get; set; }
        public string c_sex { get; set; }
        public string c_address { get; set; }
        public DateTime c_BirthDay { get; set; }
        public int c_Identity { get; set; }
        public string c_QQ { get; set; }
        public string c_Mail { get; set; }
        public string c_Company { get; set; }

    }
}