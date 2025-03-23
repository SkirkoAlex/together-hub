using Application.Data.DataBaseContext;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DataBaseContext
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public DbSet<Topic> Topics => Set<Topic>();

		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
	}
}
