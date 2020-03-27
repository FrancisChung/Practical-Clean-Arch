﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CaWorkshop.Domain.Entities
{
    public class TodoList
    {
        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}
