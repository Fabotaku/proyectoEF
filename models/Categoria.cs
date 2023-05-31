using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace proyectoef.Models;

public class Categoria {
   
   // [Key] //PK
    public Guid CategoriaID { get; set; } //PK
    //[Required]
    //[MaxLength(150)]
    public string Nombre { get; set; } //Nombre de la categoria
    public string Descripcion { get; set; }

    public int peso { get; set; }
    [JsonIgnore]
    public virtual ICollection<Tarea> Tareas { get; set; } //1 categoria tiene muchas tareas
}