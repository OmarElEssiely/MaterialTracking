using MT.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Persistance
{
    public class InstallmentConfiguration:
         EntityTypeConfiguration<Installment>
    {
        public InstallmentConfiguration()
        {
            HasKey(p => p.InstallmentId);

            Property(p => p.DueDate)
               .HasColumnType("date");
        }
    }
}
