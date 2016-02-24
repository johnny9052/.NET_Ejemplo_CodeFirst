using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*Using necesarios para que reconozca la conexion directa a la base de datos*/
using System.Data.Entity;
using VideoParte1.Models;

namespace VideoParte1.Context
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Gerente> Gerente { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            /*PERSONALIZAR UNA RELACION N A N*/
            modelBuilder.Entity<Empresa>()
                  .HasMany<Municipio>(s => s.Municipios)
                  .WithMany(c => c.Empresas)
                  .Map(cs =>
                  {
                      cs.MapLeftKey("EmpresaId");
                      cs.MapRightKey("MunicipioId");
                      cs.ToTable("EmpresaMunicipios");
                  });



            /*CONFIGURAR UNA RELACION DE 1 A 1 */

            
            modelBuilder.Entity<Gerente>()
                .HasKey(e => e.idEmpresa);

            
            modelBuilder.Entity<Empresa>()
                        .HasOptional(s => s.Gerente) 
                        .WithRequired(ad => ad.Empresa); 


            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataBaseContext, 
                Configuration>());
            base.OnModelCreating(modelBuilder);
        }
    }
}