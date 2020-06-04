using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class CommentRepository : ICommentRepository
	{
		private AppDbContext _db;

		public CommentRepository(AppDbContext context)
		{
			_db = context;
		}

		public void AddComment(Comment comment)
		{
			throw new NotImplementedException();
		}

		public void DeleteComment(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetAllComments()
		{
			throw new NotImplementedException();
		}

		public Comment GetCommentById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetProjectComments(int projectId)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetUserComments(string userEmail)
		{
			throw new NotImplementedException();
		}

		public List<Comment> PageComments(int skip, int take)
		{
			throw new NotImplementedException();
		}

		public void UpdateComment(Comment comment)
		{
			throw new NotImplementedException();
		}
	}
}
