using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Repositorio.Entidades;

namespace Repositorio
{
    public class SessionFactory
    {

        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=banco;Integrated Security=True;";
        private static ISessionFactory session;

        public static ISessionFactory CrateSessionFactory()
        {
            if (session != null)
                return session;

            IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString);

            var configMap = Fluently.Configure().Database(configDB)
                //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true)) 
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmpresaMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<VagaMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<HabilidadeMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UsuarioMap>());

            session = configMap.BuildSessionFactory();

            return session;
        }

        public static ISession AbrirSession()
        {
            return CrateSessionFactory().OpenSession();
        }
    }
}
