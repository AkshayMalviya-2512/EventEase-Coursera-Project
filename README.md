# EventEase – Event Management Application

EventEase is a Blazor-based event management application that allows users to browse upcoming events, view detailed event information, register for events, and track attendee attendance.

The project was developed as part of a Coursera project focused on building an interactive event management application using Blazor and C#.

---

## Features

### 📅 Event Listing
- Displays a list of upcoming events.
- Each event card shows:
  - Event title
  - Date
  - Description
  - Location
  - Capacity
  - Registered attendees
- Responsive event card layout.

### 🔎 Event Details
- Dedicated page for each event.
- Displays detailed event information.
- Shows event capacity and current registration count.
- Calculates available seats.
- Handles invalid event IDs with an "Event Not Found" message.

### 📝 Event Registration
- Users can register for an event using:
  - Full name
  - Email address
- Form validation using Blazor's data annotation validation.
- Prevents duplicate registration for the same event and email address.
- Prevents registration when an event has reached its capacity.
- Displays registration success and error messages.

### 📊 Attendance Tracker
- Displays all registered attendees.
- Shows:
  - Attendee name
  - Email
  - Registered event
  - Attendance status
- Allows attendees to be marked as:
  - Present
  - Absent
- Provides summary statistics for total registrations, present attendees, and absent attendees.

### 🔄 State Management
- Uses shared application services to maintain event and registration state.
- Registration counts are updated when a registration is successfully completed.
- Registration data is shared with the Attendance Tracker.

### 🤖 Microsoft Copilot
Microsoft Copilot was used throughout the development process as a development assistant for:
- Generating component code
- Debugging and troubleshooting
- Improving validation and registration logic
- Identifying duplicate-registration and event-capacity issues
- Refining state management
- Suggesting implementation improvements

All generated suggestions were reviewed, modified when necessary, and tested before being incorporated into the application.

---

## Technologies Used

- **C#**
- **.NET 10**
- **Blazor**
- **Blazor Server / Interactive Server**
- **Razor Components**
- **HTML**
- **CSS**
- **Data Annotations**
- **Visual Studio Code**
- **Microsoft Copilot**

---

## Project Structure

```text
EventEase/
│
├── Components/
│   ├── Layout/
│   ├── Pages/
│   │   ├── Events.razor
│   │   ├── EventDetails.razor
│   │   ├── Register.razor
│   │   └── Attendance.razor
│   │
│   ├── EventCard.razor
│   ├── App.razor
│   ├── Routes.razor
│   └── _Imports.razor
│
├── Models/
│   ├── Event.cs
│   └── Registration.cs
│
├── Services/
│   ├── EventService.cs
│   └── EventStateService.cs
│
├── wwwroot/
│
├── Program.cs
├── EventEase.csproj
└── README.md