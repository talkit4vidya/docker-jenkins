using System;
using DockerProj_1.Model;
using Microsoft.EntityFrameworkCore;

namespace DockerProj_1.DataAccess
{
	public class Database : DbContext

	{
		public Database(DbContextOptions<Database> options) : base(options) { }
		
    	public DbSet<Sales> sales { get; set; }
	}
}




