using MAUITest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITest.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new()
            {
                new Person { Name = "Juan", Age = 24,BirthDate = new DateTime(1994, 1, 15),IsMarried = true, LunchTime = new TimeSpan(12, 30, 0), Weigth = 89},
                new Person { Name = "Ledy", Age = 18,BirthDate = new DateTime(1994, 1, 15),IsMarried = true, LunchTime = new TimeSpan(12, 30, 0), Weigth = 89},
                new Person { Name = "Andres", Age = 43,BirthDate = new DateTime(1994, 1, 15),IsMarried = true, LunchTime = new TimeSpan(12, 30, 0), Weigth = 89},
                new Person { Name = "Valery", Age = 24,BirthDate = new DateTime(1994, 1, 15),IsMarried = true, LunchTime = new TimeSpan(12, 30, 0), Weigth = 89},
                new Person { Name = "Mariana", Age =34,BirthDate = new DateTime(1994, 1, 15),IsMarried = true, LunchTime = new TimeSpan(12, 30, 0), Weigth = 89},
            };
        }
        public List<Person> People { get; set; }
    }

    
}
