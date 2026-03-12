using StudentApi.Model;     // using will import student.api--> project name , model --> folder
using Microsoft.EntityFrameworkCore;    //it will help to ocnnect to db 

namespace StudentApi.Data   // namespace is a container it will group related classes and libraries together
{
    public class AppDbContext : DbContext   // public it is a access modifier and can be accessed anywhere in file , inheritance 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student>Students{ get; set; }
    }
}