using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public enum TypeSubject
    {
        Fisica,
        Quimica,
        Matematicas

    }
    public enum TypeState
    {
        Aprobado,
        Reprobado

    }
    public class Nota
    {
        [Key]
        [Required]
        public TypeSubject Subject { get; set; }
        [Required]
        public int Grades { get; set; }
        [Required]
        public TypeState State { get; set; }

        public Estudiante Estudiante { get; set; }
    }
}