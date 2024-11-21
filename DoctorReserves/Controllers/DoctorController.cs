using DoctorReserves.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorReserves.Controllers
{
    public class DoctorController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Booking()
        {
            var Doctors = _context.Doctors.ToList();
            return View(model: Doctors);
        }
        public IActionResult CompleteAppointement(int id)
        {
            var Doctor = _context.Doctors.Find(id);
            return View(model: Doctor);
        }
        public IActionResult AppointementList()
        {
            var Bookingg = _context.Bookings.Include(e => e.Doctor).ToList();
            return View(model: Bookingg);
        }
        public IActionResult AddBooking(string patient_name, DateOnly date, TimeOnly time, int doctor_id)
        {
            _context.Bookings.Add(new()
            {
                PatientName = patient_name,
                Date = date,
                Time = time,
                DoctorId = doctor_id
            });
            _context.SaveChanges();
            return RedirectToAction(nameof(Success));
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
