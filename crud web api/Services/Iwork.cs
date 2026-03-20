namespace crud_web_api.Services
{
	public interface Iwork
	{
		public Task<List<T>> getTasks<T>() where T : class;
	}
}
