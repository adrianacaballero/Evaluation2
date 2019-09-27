namespace apiEval.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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

        
    }
}