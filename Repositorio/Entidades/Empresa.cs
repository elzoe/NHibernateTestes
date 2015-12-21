using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Empresa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Vaga> Vagas { get; set; }
    }

    public class EmpresaMap : ClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Id(x => x.Id)
                .Not.Nullable();

            Map(x => x.Nome)
                .Not.Nullable();

            HasMany(x => x.Vagas);
        }
    }
}
