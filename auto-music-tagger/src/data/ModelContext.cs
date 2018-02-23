// <copyright file="ModelContext.cs" company="AMT">
// Copyright (c) AMT. All rights reserved.
// </copyright>

namespace data
{
    using Configuration;
    using entities;
    using Mapping;
    using System;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(SqliteConfiguration))]
    public class ModelContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ModelContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'data.ModelContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ModelContext'  en el archivo de configuración de la aplicación.

        public ModelContext()
            : base()
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MusicFile> MusicFiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MusicFileTypeConfiguration());
        }
    }
}