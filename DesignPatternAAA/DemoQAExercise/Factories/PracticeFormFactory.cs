using DemoQAExecise.Models;

namespace DemoQAExecise.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                FirstName = "First",
                LastName = "Last",
                Email = "Email@fsds.com",
                Gender = "Male",
                PhoneNumber = "0888888888",
                //SportsCheckBox.Click(),
            };
        }
    }
}
