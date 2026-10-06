using EventEase.Models;

namespace EventEase.Services;

public class EventStateService(EventService eventService)
{
    private readonly object _sync = new();

    private readonly List<Registration> _registrations = [];

    public bool TryRegister(
        Registration registration,
        out string error)
    {
        lock (_sync)
        {
            var eventItem =
                eventService.GetEventById(registration.EventId);

            if (eventItem is null)
            {
                error = "This event is no longer available.";
                return false;
            }

            var email = registration.Email?.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                error = "Enter a valid email address.";
                return false;
            }

            bool alreadyRegistered = _registrations.Any(r =>
                r.EventId == registration.EventId &&
                string.Equals(
                    r.Email.Trim(),
                    email,
                    StringComparison.OrdinalIgnoreCase));

            if (alreadyRegistered)
            {
                error =
                    "This email is already registered for this event.";

                return false;
            }

            if (eventItem.RegisteredCount >= eventItem.Capacity)
            {
                error =
                    "This event is full and can no longer accept registrations.";

                return false;
            }

            registration.Email = email;

            _registrations.Add(registration);

            eventItem.RegisteredCount++;

            error = string.Empty;

            return true;
        }
    }

    public IReadOnlyList<Registration> GetRegistrations()
    {
        lock (_sync)
        {
            return _registrations.ToList();
        }
    }
}