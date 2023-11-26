using TodoList.Entity;

namespace TodoList.ISerVice
{
    public interface IUser
    {
        Task<ErrorHelper> CreatUser(User user);
        Task<ErrorHelper> DeleteUser(int id);
        Task<ErrorHelper> UpdateUser(User user);
    }
}
