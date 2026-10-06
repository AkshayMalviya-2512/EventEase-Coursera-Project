using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> events =
    [
        new Event
        {
            Id = 1,
            Title = "Tech Conference 2026",
            Description = "A conference covering modern software development and technology.",
            Date = new DateTime(2026, 10, 20),
            Location = "New Delhi",
            ImageUrl = "https://images.unsplash.com/photo-1540575467063-178a50c2df87",
            Capacity = 100,
            RegisteredCount = 85
        },

        new Event
        {
            Id = 2,
            Title = "AI & Machine Learning Workshop",
            Description = "Hands-on workshop covering artificial intelligence and machine learning.",
            Date = new DateTime(2026, 11, 5),
            Location = "Bengaluru",
            ImageUrl = "https://images.unsplash.com/photo-1555949963-ff9fe0c870eb",
            Capacity = 100,
            RegisteredCount = 42
        },

        new Event
        {
            Id = 3,
            Title = "Web Development Bootcamp",
            Description = "Learn modern web development technologies and best practices.",
            Date = new DateTime(2026, 11, 18),
            Location = "Mumbai",
            ImageUrl = "https://images.unsplash.com/photo-1498050108023-c5249f4df085",
            Capacity = 150,
            RegisteredCount = 67
        }
    ];

    public List<Event> GetEvents()
    {
        return events;
    }

    public Event? GetEventById(int id)
    {
        return events.FirstOrDefault(e => e.Id == id);
    }
}