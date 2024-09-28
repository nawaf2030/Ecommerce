using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
	public class DBContextApplicationFactory : IDesignTimeDbContextFactory<DBContextApplication>
	{
		public DBContextApplication CreateDbContext(string[] args) 
		{
			//Bulid  Counfegration from appseting.json
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			//Get the conction string from confugration
			var connectionString = configuration.GetConnectionString("DefaultConnection");

			//Create DbcontextoptionsBulder with the connection string
			var optionsBuilder = new DbContextOptionsBuilder<DBContextApplication>();
			optionsBuilder.UseSqlServer(connectionString);

			//return new instns  of dbcontxt
			return new DBContextApplication(optionsBuilder.Options);
		}
	}
}
