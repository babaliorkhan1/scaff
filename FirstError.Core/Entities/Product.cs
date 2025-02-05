﻿using FirstApi.Core.Entities;
using FirstError.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstError.Core.Entities
{
    public  class Product:BaseEntity
    {
         public string Name { get; set; }   
         public string Price { get; set; }   
         public string Image  { get; set; }   
         public string ImageUrl  { get; set; }   
        public int CategoryId { get; set; }     
        public Category Category { get; set; }  
    }
}
