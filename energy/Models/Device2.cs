namespace energy.Models
{
    public class Device2
    {
        public int id { get; set; }
        public DateTime Time { get; set; }
        public int current { get; set; }
        public int volt { get; set; }
        public int KWHour { get; set; }
        public string Name { get; set; }
        public string DeviceInfo { get; set; }
    }
}
