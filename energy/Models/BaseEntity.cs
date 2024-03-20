using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace energy.Models
{
    public class BaseEntity
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Time { get; set; }
        public int DeviceCurrent { get; set; }
        public int volt { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? DeviceName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? DeviceInfo { get; set; }
    }
}
