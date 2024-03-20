using System.ComponentModel.DataAnnotations;

namespace energy.Models
{
    public class CurrentVoltKWHourPerMonth : BaseEntity
    {
        public int KWHour { get; set; }
    }
}
