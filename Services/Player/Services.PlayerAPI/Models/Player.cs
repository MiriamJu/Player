using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.PlayerAPI.Models
{
    [Table("player")]
    public class Player
    {
        [Key]
        public string PlayerId { get; set; }
        public LifeStatusAdditionalData BirthStatusAdditionalData { get; set; }
        public LifeStatusAdditionalData DeathStatusAdditionalData { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameGiven { get; set; }
        public int Weight { get; set; }
        public int Bats { get; set; }
        public int Throws { get; set; }
        public DateTime Debut { get; set; }
        public DateTime FinalGame { get; set; }
        [ForeignKey("OrderHeaderId")]
        public string RetroId { get; set; }
        [ForeignKey("OrderHeaderId")]
        public string DdRefId { get; set; }
    }
}
