using RunnerMVC.Models;

namespace RunnerMVC.Services
{
    public interface ITimelineService
    {
        List<TimelineEvent> GetAllEvents();
        Dictionary<int, List<TimelineEvent>> GetEventsByYear();
        List<int> GetAvailableYears();
        TimelineEvent? GetEventById(int id);
    }
}