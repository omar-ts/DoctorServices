﻿namespace DoctorReserves.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
