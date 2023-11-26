using TodoList.Entity;

namespace MudBlazorTemplates1.IServices
{
    public interface IApiUser
    {
        Task<List<User>> GetDataUsers();
        Task CreatUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);

    }
}
