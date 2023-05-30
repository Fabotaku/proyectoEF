namespace proyectoef.Models;

public class {
    public Guid TareaID { get; set; }
        public Guid CategoriaID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public Prioridad PrioridadTarea { get; set; }

    public virtual Categoria Categoria { get; set; }
}

public enum Prioridad {
    alta, 
    media, 
    baja

}