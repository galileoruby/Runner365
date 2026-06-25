using Microsoft.AspNetCore.Mvc;
using RunnerMVC.Services;
using System.Globalization;

namespace RunnerMVC.Controllers
{
    public class TimelineController : Controller
    {
        private readonly ILogger<TimelineController> _logger;
        private readonly ITimelineService _timelineService;

        public TimelineController(
            ILogger<TimelineController> logger,
            ITimelineService timelineService)
        {
            _logger = logger;
            _timelineService = timelineService;
        }

        public IActionResult Index()
        {
            var eventsByYear = _timelineService.GetEventsByYear();
            var availableYears = _timelineService.GetAvailableYears();

            ViewBag.EventsByYear = eventsByYear;
            ViewBag.AvailableYears = availableYears;
            ViewBag.CurrentYear = DateTime.Now.Year;

            return View();
        }
    }
}