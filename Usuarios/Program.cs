using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Repositorio.Mapeamento;
using Repositorio.Entidades;

namespace Repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistemas EL Zoe - FluentNHibernate");

            var repo = new UsuarioRepositorio();
            var usu = new Usuario() {Id = 2, Nome = "Eder Ferreira" , Login = "eder", Senha = "Eder", Status = 'A' };
            var usu2 = new Usuario() { Nome = "Joao Lopes", Login = "eder", Senha = "Eder", Status = 'A' };
            var usu3 = new Usuario() { Nome = "Paulo Lopes", Login = "eder", Senha = "Eder", Status = 'A' };

            //Console.WriteLine("Inserir...");
            //repo.Inserir(usu3);

            //Console.WriteLine("Alterar...");
            //repo.Alterar(usu);

            //Console.WriteLine("Excluir...");
            //repo.Excluir(usu);

            Console.WriteLine("Consultar...");
            Console.WriteLine(repo.Consultar()[3].Nome);

            Console.WriteLine("Retornar por ID...");
            Console.WriteLine(repo.RetornarPorId(4).Nome);
            
                        
        }

        //public static ISessionFactory CrateSessionFactory()
        //{
        //    var stringConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=banco;Integrated Security=True;";

        //    return Fluently.Configure()
        //        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(stringConexao).ShowSql())
        //        .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
        //        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmpresaMap>())
        //        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<VagaMap>())
        //        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<HabilidadeMap>())
        //        .BuildSessionFactory();           
        //}
    }
}
