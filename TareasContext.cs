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
        modelBuilder.Entity<Categoria>(categoria=>{
            categoria.ToTable("Categoria"); //Nombre de la tabla
            categoria.HasKey(p=>p.CategoriaID); //Llave primaria

            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150); //Nombre de la categoria
            categoria.Property(p=>p.Descripcion); //Descripcion de la categoria

          
        });

        modelBuilder.Entity<Tarea>(tarea=>{
            tarea.ToTable("Tarea"); //Nombre de la tabla
            tarea.HasKey(p=>p.TareaID); //Llave primaria

            tarea.HasOne(p=>p.Categoria).WithMany(p=>p.Tareas).HasForeignKey(p=>p.CategoriaID); //1 tarea tiene 1 categoria
            
            tarea.Property(p=>p.Nombre).IsRequired().HasMaxLength(150); //Nombre de la tarea
            tarea.Property(p=>p.Descripcion); //Descripcion de la tarea
            tarea.Property(p=>p.FechaCreacion); //Fecha de creacion de la tarea
            tarea.Property(p=>p.PrioridadTarea); //Prioridad de la tarea

            tarea.Ignore(p=>p.Resumen); //Ignoramos el campo resumen
        });
    }
}