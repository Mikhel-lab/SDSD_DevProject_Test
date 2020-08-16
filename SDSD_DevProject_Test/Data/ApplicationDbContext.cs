using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SDSD_DevProject_Test.Models;

namespace SDSD_DevProject_Test.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<UploadDoc> UploadDocs { get; set; }

		public DbSet<UploadImage> UploadImages { get; set; }
	}
}
