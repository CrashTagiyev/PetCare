using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
	public class NotificationReadRepository : GenericRepository<Notification>, INotificationReadRepository
	{
		public NotificationReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<Notification>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<Notification?> GetByIdAsync(int id)
		{
			var notification = await _table.FirstOrDefaultAsync(n => n.Id == id);
			return notification;
		}

		public async Task<IEnumerable<Notification>> GetNotificationsByUsername(string username)
		{
			return await Task.Run(() =>
				{
					return _table.Include(n => n.User).Where(n => n.User.UserName == username);
				});
		}
	}
}
