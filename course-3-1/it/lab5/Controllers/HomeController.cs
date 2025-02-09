using System.Diagnostics;
using lab5.Context;
using Microsoft.AspNetCore.Mvc;
using lab5.Models;
using lab5.Request;

namespace lab5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(
        ILogger<HomeController> logger
    )
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        DefaultContext db = new DefaultContext();

        IEnumerable<Room> rooms = db.Rooms;

        ViewBag.Rooms = rooms;

        return View("~/Views/Home/Index.cshtml");
    }

    [HttpGet]
    public IActionResult Booking(int id)
    {
        DefaultContext db = new DefaultContext();

        Room? room = db.Rooms.Find(id);

        if (room == null)
        {
            throw new Exception("Room not found");
        }

        ViewBag.Room = room;

        return View("~/Views/Home/Booking.cshtml");
    }

    [HttpPost]
    public IActionResult Booking([FromForm] CreateBookingRequest request)
    {
        DefaultContext db = new DefaultContext();

        DateTime bookingDate = DateTime.Now;

        Booking booking = new Booking
        {
            VisitorFirtsName = request.VisitorFirtsName,
            VisitorLastName = request.VisitorLastName,
            VisitorPassport = request.VisitorPassport,
            RoomId = request.RoomId,
            BookingStartDate = bookingDate
        };

        db.Bookings.Add(booking);

        db.SaveChanges();

        Room? room = db.Rooms.Find(request.RoomId);

        ViewData["Message"] =
            $"Спасибо, {request.VisitorLastName} {request.VisitorFirtsName}, ваша бронь апартаментов {room?.Number}," +
            $" начинатеся {bookingDate}!";

        return View("~/Views/Home/SuccessBooking.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}