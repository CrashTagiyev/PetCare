using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	internal class NotificationWriteRepository : GenericRepository<Notification>, INotificationWriteRepository
	{
		public NotificationWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Notification entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var notification = await _table.FirstOrDefaultAsync(n => n.Id == id);
			if (notification != null)
				_table.Remove(notification);
			await SaveChangesDbAsync();
			//Burda exception atsa yaxshi olar
		}

		public async Task UpdateAsync(Notification entity)
		{
			_table.Update(entity);
			await Task.CompletedTask;
			await SaveChangesDbAsync();
		}
	}
}
