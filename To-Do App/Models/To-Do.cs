using System;
using System.ComponentModel.DataAnnotations;
using To_Do_App.Models;

namespace To_Do_App.Models
{
    public class Todo
    {
        [Key]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

          


        

    }
}