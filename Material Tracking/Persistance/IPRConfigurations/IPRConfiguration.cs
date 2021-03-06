﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Persistance
{
    public class IPRConfiguration
                : EntityTypeConfiguration<ProjectIpr>
    {
        public IPRConfiguration()
        {
            HasKey(a => a.ProjectIprId);

            Property(a => a.Path)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
