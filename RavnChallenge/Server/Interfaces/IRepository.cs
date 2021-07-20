using RavnChallenge.Shared;

namespace RavnChallenge.Server.Interfaces
{
    public interface IRepository
    {
        T GetSingle<T>(string Endpoint, string Id) where T : Entity;
        EntityResult<T> GetAllPaginated<T>(string EntityName, string PageNumber = "1") where T : Entity;
    }
}
