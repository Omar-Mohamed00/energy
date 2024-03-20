using energy.Models;
using Microsoft.EntityFrameworkCore;

namespace energy.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Device1>().HasData(

                new Device1
                {
                    id = 1,
                    DeviceCurrent = 21,
                    volt = 42,
                    KWHour = 4,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-1",
                    DeviceInfo = "Device1"
                },
                new Device1
                {
                    id = 2,
                    DeviceCurrent = 31,
                    volt = 45,
                    KWHour = 8,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-1",
                    DeviceInfo = "Device1"
                },
                new Device1
                {
                    id = 3,
                    DeviceCurrent= 29,
                    volt = 47,
                    KWHour = 12,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-1",
                    DeviceInfo = "Device1"
                },
                new Device1
                {
                    id = 4,
                    DeviceCurrent= 76,
                    volt = 52,
                    KWHour = 22,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-1",
                    DeviceInfo = "Device1"
                }, 
                new Device1
                {
                    id = 5,
                    DeviceCurrent = 51,
                    volt = 21,
                    KWHour = 7,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-1",
                    DeviceInfo = "Device1"
                }
                );

            modelBuilder.Entity<Device2>().HasData(

                new Device2
                {
                    id = 1,
                    DeviceCurrent= 26,
                    volt = 62,
                    KWHour = 32,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-2",
                    DeviceInfo = "Device2"
                },
                new Device2
                {
                    id = 2,
                    DeviceCurrent = 35,
                    volt = 15,
                    KWHour = 5,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-2",
                    DeviceInfo = "Device2"
                },
                new Device2
                {
                    id = 3,
                    DeviceCurrent = 29,
                    volt = 47,
                    KWHour = 12,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-2",
                    DeviceInfo = "Device2"
                },
                new Device2
                {
                    id = 4,
                    DeviceCurrent = 76,
                    volt = 52,
                    KWHour = 22,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-2",
                    DeviceInfo = "Device2"
                },
                new Device2
                {
                    id = 5,
                    DeviceCurrent = 11,
                    volt = 51,
                    KWHour = 12,
                    Time = DateTime.UtcNow,
                    DeviceName = "D-2",
                    DeviceInfo = "Device2"
                }
                );

        }
        public DbSet<Device1> Device1 {  get; set; }
        public DbSet<Device2> Device2 {  get; set; }
        public DbSet<CurrentVoltSecond> CurrentVoltSecond {  get; set; }
        public DbSet<CurrentVoltMinutes> CurrentVoltMinutes {  get; set; }
        public DbSet<CurrentVoltKWHourPerHour> CurrentVoltKWHourPerHour {  get; set; }
        public DbSet<CurrentVoltKWHourPerDay> CurrentVoltKWHourPerDay {  get; set; }
        public DbSet<CurrentVoltKWHourPerMonth> CurrentVoltKWHourPerMonth {  get; set; }
    }
}
