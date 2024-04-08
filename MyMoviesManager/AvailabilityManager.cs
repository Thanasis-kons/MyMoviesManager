using MyMoviesManager;
using MyMoviesManager.Models;

public class AvailabilityManager
{
    private static AvailabilityManager instance;
    public List<Movies> Availabilities { get; private set; }

    private AvailabilityManager()
    {
        Availabilities = new List<Movies>();
    }

    public static AvailabilityManager GetInstance()
    {
        if (instance == null)
        {
            instance = new AvailabilityManager();
        }
        return instance;
    }

    public void AddAvailability(Movies availability)
    {
        if (!Availabilities.Any(a => a.Availability == availability.Availability))
        {
            Availabilities.Add(availability);
        }
    }

    public void UpdateAvailabilityName(Movies availability, string newName)
    {
        if (availability != null)
        {
            availability.Availability = newName;
        }
    }

    public void DeleteAvailability(Movies availability)
    {
        Availabilities.Remove(availability);
    }
}
