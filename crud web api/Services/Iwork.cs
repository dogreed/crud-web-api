using crud_web_api.Models;

namespace crud_web_api.Services
{
	public interface Iwork
	{
		public Task<List<T>> getTasks<T>() where T : class;
		public Task<List<T>> createTask<T>(Taskcs task) where T : class;
	}
}
