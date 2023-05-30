using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;

public class Tarea {
    [Key]
    public Guid TareaID { get; set; } //PK
    [ForeignKey("CategoriaID")]
    public Guid CategoriaID { get; set; } //FK
    [Required]
    [MaxLength(150)]
    public string Nombre { get; set; } //Nombre de la tarea

    public string Descripcion { get; set; } //Descripcion de la tarea
    public DateTime FechaCreacion { get; set; } //Fecha de creacion de la tarea
    public Prioridad PrioridadTarea { get; set; } //Prioridad de la tarea

    public virtual Categoria Categoria { get; set; } //1 tarea tiene 1 categoria

    [NotMapped]
    public string Resumen  {get; set;}
}

public enum Prioridad {
    alta, 
    media, 
    baja

}