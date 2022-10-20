using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context

{


    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        { // Usado para Criar Migrações
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123"; //Criado no MYSQL
       var optionBuilder = new DbContextOptionsBuilder<MyContext> ();
       optionBuilder.UseMySql (connectionString);
        return new MyContext (optionBuilder.Options);
       
       
       
        }
    }


}
