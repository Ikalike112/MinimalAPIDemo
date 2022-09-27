namespace DataAccess.DbAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> Query<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
    Task Command<T>(string storedProcedure, T parameters, string connectionId = "Default");
}