public interface IRepository<TData>
{
     TData GetData(string type);
     void AddData(TData data);
     void Update(TData data);
}