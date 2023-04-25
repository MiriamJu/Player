using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Services.PlayerAPI.Models.Enums;

namespace Services.PlayerAPI.Models
{
    public class LifeStatusAdditionalData
    {
        [Key]
        public Guid Id { get; set; }
        public LifeStatus status { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
