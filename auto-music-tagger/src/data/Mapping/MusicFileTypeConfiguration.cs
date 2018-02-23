// <copyright file="MusicFileTypeConfiguration.cs" company="AMT">
// Copyright (c) AMT. All rights reserved.
// </copyright>

namespace data.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using entities;

    internal class MusicFileTypeConfiguration : EntityTypeConfiguration<MusicFile>
    {
        public MusicFileTypeConfiguration()
        {
            ToTable("MusicFile");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(0);

            Property(x => x.FilePath)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false)
                .HasColumnOrder(1);

            Property(x => x.FileName)
                .IsRequired()
                .IsVariableLength()
                .IsUnicode(false)
                .HasColumnOrder(2);
        }
    }
}
