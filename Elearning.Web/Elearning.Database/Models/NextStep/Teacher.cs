using Elearning.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elearning.Database.Models.NextStep
{
    /// <summary>
    /// Teacher
    /// </summary>
    public class Teacher : UpdateTime
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }
    }
}