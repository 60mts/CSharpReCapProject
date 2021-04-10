using reCapProjectt.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace reCapProjectt.Entities.Conncrete
    {
    public class Car:IEntities
        {
        public int Id { get; set; }
        public int brandId { get; set; }
        public int colorId { get; set; }
        public int modelYear { get; set; }
        public int dailyPrice { get; set; }
        public string description { get; set; }
        }
    }
