﻿using System.Collections.Generic;
using System;

namespace Server.Models
{
    public class TodoModel
    {
        public TodoModel()
        {
            Completed = false;
            Date = DateTime.UtcNow;
            Tags = new List<TagModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<TagModel> Tags { get; set; }
    }
}
