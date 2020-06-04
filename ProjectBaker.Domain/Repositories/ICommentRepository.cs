using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.Domain.Repositories
{
	public interface ICommentRepository
	{
		void AddComment(Comment comment);
		Comment GetCommentById(int id);
		List<Comment> GetAllComments();
		List<Comment> GetProjectComments(int projectId);
		List<Comment> GetUserComments(string userEmail);
		List<Comment> PageComments(int skip, int take);
		void UpdateComment(Comment comment);
		void DeleteComment(Comment comment);

	}
}
