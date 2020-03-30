using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TravelBlog.Models
{
  public class TravelBlogContextFactory : IDesignTimeDbContextFactory<TravelBlogContext>
  {

    TravelBlogContext IDesignTimeDbContextFactory<TravelBlogContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<TravelBlogContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new TravelBlogContext(builder.Options);
    }
  }
}