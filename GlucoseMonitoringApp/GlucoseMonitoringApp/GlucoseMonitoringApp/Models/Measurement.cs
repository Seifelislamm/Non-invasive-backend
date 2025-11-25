namespace GlucoseMonitoringApp.Models
{
    public class Measurement
    {
        public int Glucose { get; set; }
        public int Spo2 { get; set; }
        public int HeartRate { get; set; }
        public string BloodPressure { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
