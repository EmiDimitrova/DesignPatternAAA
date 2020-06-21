using DemoQAExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQAExercise.Factories
{
    public class GoogleSearchFactory
    {
        public static GoogleSearchModel Create()
        {
            return new GoogleSearchModel
            {
                SearchField = "selenium",
            };
        }
    }
}
