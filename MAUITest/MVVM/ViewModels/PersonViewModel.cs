using MAUITest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITest.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new()
            {
                Name = "Andres Velez",
                Age = 24,
                BirthDate = new DateTime(1999, 9, 15),
                IsMarried = true,
                LunchTime = new TimeSpan(2, 0, 0),
                Weigth = 80
            };
        }

        public Person Person { get; set; }


    }
}
