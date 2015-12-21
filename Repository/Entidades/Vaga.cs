using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Vaga
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Habilidade> Habilidades { get; set; }
    }

    public class VagaMap : ClassMap<Vaga>
    {
        VagaMap()
        {
            Id(x => x.Id)
                .Not.Nullable();

            Map(x => x.Descricao)
                .Not.Nullable()
                .Length(70);

            HasMany(x => x.Habilidades).Cascade.All();  
        }
    }

}
