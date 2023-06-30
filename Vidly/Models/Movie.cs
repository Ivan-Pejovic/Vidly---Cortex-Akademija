﻿namespace Vidly.Models
{
    public class Movie
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public Movie(int? id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Movie() : this(0, "")
        {
            
        }
    }
}
