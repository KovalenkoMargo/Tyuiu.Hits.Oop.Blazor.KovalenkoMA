namespace blazor.KovalenkoMA.Data.Interfaces
{
    namespace TodoServerApp.Data.Interfaces
    {
        public interface IDataService
        {
            IEnumerable<TaskItem> GetTaskItems();
        }
    }
}
