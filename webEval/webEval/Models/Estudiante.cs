﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public class Estudiante
    {
        public enum TypeSex
        {
            female,
            male
        }
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeSex Sex { get; set; }
        [Required]
        public int Birthdate { get; set; }

        public virtual ICollection<Nota> Notas { get; set; }
    }
}