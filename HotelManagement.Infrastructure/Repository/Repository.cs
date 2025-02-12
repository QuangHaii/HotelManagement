using HotelManagement.Application.Interfaces;
using HotelManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		internal DbSet<T> dbSet;
		public Repository(ApplicationDbContext context)
		{
			_context = context;
			dbSet = _context.Set<T>();
		}
		public void Add(T entity)
		{
			dbSet.Add(entity);
		}

		public IEnumerable<T> GetAll()
		{
			return dbSet.ToList();
		}

		public T GetById(int id)
		{
			return dbSet.Find(id);
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}

		public void Update(T entity)
		{
			dbSet.Update(entity);
		}

	}
}
