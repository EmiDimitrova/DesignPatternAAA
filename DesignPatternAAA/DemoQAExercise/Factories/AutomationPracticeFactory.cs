using OldHomeworks.Models;

namespace OldHomeworks.Factories
{
    public class AutomationPracticeFactory
    {
        public static AutomationPracticeModel Create()
        {
            return new AutomationPracticeModel
            {
                FirstName = "Alana",
                LastName = "Miles",
                Password = "12345",
                Address = "Elmor Str. 5",
                City = "Washington",
                CountryField = "United States",
                StateField = "Washington",
                PostalCode = "98005",
                PhoneNumber = "8888888888",
            };
        }
    }
}
