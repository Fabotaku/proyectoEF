using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;

public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options): base(options)  { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria(){CategoriaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7741"), Nombre = "Actividades Pendientes", peso = 20});
        categoriasInit.Add(new Categoria(){CategoriaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7742"), Nombre = "Actividades Personales", peso = 50});


        modelBuilder.Entity<Categoria>(categoria=>{
            categoria.ToTable("Categoria"); //Nombre de la tabla
            categoria.HasKey(p=>p.CategoriaID); //Llave primaria

            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150); //Nombre de la categoria
            categoria.Property(p=>p.Descripcion).IsRequired(false); //Descripcion de la categoria
            categoria.Property(p=>p.peso); //Peso de la categoria

            categoria.HasData(categoriasInit);

          
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea(){TareaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7743"), CategoriaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7741"), PrioridadTarea = Prioridad.media, Nombre = "Pago de servicios publicos", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea(){TareaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7744"), CategoriaID = Guid.Parse("e8a90193-9f42-4348-a122-2aad81cb7742"), PrioridadTarea = Prioridad.baja, Nombre = "Terminar de ver pelicula", FechaCreacion = DateTime.Now });
        modelBuilder.Entity<Tarea>(tarea=>{
           
           
            tarea.ToTable("Tarea"); //Nombre de la tabla
            tarea.HasKey(p=>p.TareaID); //Llave primaria

            tarea.HasOne(p=>p.Categoria).WithMany(p=>p.Tareas).HasForeignKey(p=>p.CategoriaID); //1 tarea tiene 1 categoria
            
            tarea.Property(p=>p.Nombre).IsRequired().HasMaxLength(150); //Nombre de la tarea
            tarea.Property(p=>p.Descripcion).IsRequired(false); //Descripcion de la tarea
            tarea.Property(p=>p.FechaCreacion); //Fecha de creacion de la tarea
            tarea.Property(p=>p.PrioridadTarea); //Prioridad de la tarea

            tarea.Ignore(p=>p.Resumen); //Ignoramos el campo resumen

            tarea.HasData(tareasInit);
        });
    }
}