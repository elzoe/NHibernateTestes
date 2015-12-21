using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using NHibernate;
using NHibernate.Linq;

namespace Repositorio.Mapeamento
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        public bool ValidarLogin(string login)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) select e).Count() > 0;
            }
        }

        public bool ValidarAcesso(string login, string senha)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) && e.Senha.Equals(senha) select e).Count() > 0;
            }
        }
    }
}
