using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallorieMapBL
{
    public class User
    {
        
        
        public string FirstName { get; }
        public string LastName { get;}
        public int Id { get; set; }
        public double  Height { get; set; }
        public double Weight { get; set; }
        public string Gender { get; }
        public DateTime BirdDate { get; }
        public string Login { get; }
        public string Password { get; set; }



        public User(string firstName, string lastName, int id, int height, int weight, string gender, DateTime birdDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Height = height;
            Weight = weight;
            Gender = gender;
            BirdDate = birdDate;
        }
    }
}
