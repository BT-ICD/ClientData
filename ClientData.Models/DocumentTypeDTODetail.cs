﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class DocumentTypeDTODetail
    {
        public int DocumentTypeId { get; set; }
      
        public string Name { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
