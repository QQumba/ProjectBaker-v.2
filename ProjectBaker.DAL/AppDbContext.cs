using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
			//Enable to recreate database
			//Database.EnsureDeleted();
			Database.EnsureCreated();
			//Create base roles
			Roles.Add(new Role() { Name = "admin" });
			Roles.Add(new Role() { Name = "user" });
		}

		public DbSet<Project> Projects { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Job> Jobs { get; set; }
		public DbSet<ProjectAccount> ProjectAccounts { get; set; }
		public DbSet<ProjectParticipant> Participants { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			//Entities configurations:
			
			//1
			//User
			var user = builder.Entity<User>();
			user.HasKey(k => k.Email);
			user.Property(u => u.Password).IsRequired();
			user.Property(u => u.HasEmailConfirmed).IsRequired();
			user.Property(u => u.FirstName).IsRequired();
			user.Property(u => u.Age).IsRequired();
			user.Property(u => u.Country).IsRequired();

			//2
			//Comment
			var comment = builder.Entity<Comment>();
			//comment.Property(c => c.UserEmail).IsRequired(false);
			//comment.HasOne(c => c.User)
			//	.WithMany(u => u.Comments)
			//	.OnDelete(DeleteBehavior.SetNull);			
			comment.Property(c => c.Text).IsRequired();
			comment.Property(c => c.PostDate).IsRequired();

			//3
			//Job
			var job = builder.Entity<Job>();
			job.Property(j => j.Name).IsRequired();
			job.Property(j => j.Description).IsRequired();
			job.Property(j => j.Salary).IsRequired();
			job.Property(j => j.PostDate).IsRequired();
			job.Property(j => j.EmployeeEmail).IsRequired(false);
			job.Property(j => j.ProjectId).IsRequired(false);

			//4
			//Review
			var review = builder.Entity<Review>();
			review.HasOne(r => r.User)
				.WithMany(u => u.Reviews)
				.OnDelete(DeleteBehavior.SetNull);
			review.Property(r => r.UserEmail).IsRequired(false);
			review.Property(r => r.Text).IsRequired();
			review.Property(r => r.PostDate).IsRequired();

			//5
			//Project
			var project = builder.Entity<Project>();
			project.Property(p => p.Name).IsRequired();
			project.Property(p => p.ProjectPhoto).IsRequired(false);
			project.Property(p => p.Description).IsRequired();
			project.Property(p => p.UserEmail).IsRequired();
			project.Property(p => p.PostDate).IsRequired();
			project.Property(p => p.FundGoal).IsRequired();
			project.Property(p => p.RatingPoints).IsRequired();

			//6
			//Role
			var role = builder.Entity<Role>();
			role.Property(r => r.Name).IsRequired();

			//7
			//ProjectParticipants
			var participants = builder.Entity<ProjectParticipant>();
			//participants.Property(p => p.ProjectId).IsRequired();
			//participants.Property(p => p.UserEmail).IsRequired();
			participants.Property(p => p.Position).IsRequired();

			//8
			//ProjectAccount
			var account = builder.Entity<ProjectAccount>();
			account.Property(a => a.ProjectId).IsRequired();
			account.Property(a => a.Amount).IsRequired();
			account.Property(a => a.Deadline).IsRequired();
			account.Property(a => a.LastUpdate).IsRequired();
		}
	}
}
