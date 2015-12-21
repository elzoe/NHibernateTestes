using FluentNHibernate.Mapping;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual char Status { get; set; }
    }

    public class UsuarioMap : ClassMap<Usuario>
    {
        UsuarioMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Login);
            Map(x => x.Senha);
            Map(x => x.Status);
            Table("usuarios");
        }
    }
}