﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularTutorial.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        [MaxLength(800)]
        public String Todo { get; set; }
        public String TodoText { get; set; }
        public String BioText { get; set; }
        public byte Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? Added { get; set; }
    }
}