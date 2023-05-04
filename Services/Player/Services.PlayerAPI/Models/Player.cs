using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Services.PlayerAPI.Models
{
    [Table("player")]
    public class Player
    {
        [Key]
        public string PlayerId { get; set; }
        public BirthStatusAdditionalData BirthStatusAdditionalData { get; set; } = null;
        public DeathStatusAdditionalData DeathStatusAdditionalData { get; set; } = null;
        public string NameFirst { get; set; } = null;
        public string NameLast { get; set; } = null;
        public string NameGiven { get; set; } = null;
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Height { get; set; }
        public string Bats { get; set; } = null;
        public Nullable<int> Throws { get; set; }
        public Nullable<DateTime> Debut { get; set; }
        public Nullable<DateTime> FinalGame { get; set; }
        public string RetroId { get; set; } = null;
        public string DdRefId { get; set; } = null;
    }
}
