using Microsoft.EntityFrameworkCore;
using TodoList.Entity;
using TodoList.ISerVice;

namespace TodoList.Service
{
    public class UserServices : IUser
    {
        private readonly AppdbContext dbcontext;
        public UserServices()
        {
            this.dbcontext = new AppdbContext();
        }
        public async Task<ErrorHelper> CreatUser(User user)
        {
            using (var trans = dbcontext.Database.BeginTransaction())
            {
                try
                {
                    if (dbcontext.users.Any(x => x.Email == user.Email))
                    {
                        return ErrorHelper.UserDaTonTai;
                    }
                    else
                    {
                        await dbcontext.AddAsync(user);
                        dbcontext.SaveChanges();
                        trans.Commit();
                        return ErrorHelper.TaoThanhCong;
                    }
                }
                catch (Exception)
                {
                    trans.Rollback();
                }
                return ErrorHelper.ThemThatBai;
            }
        }

        public async Task<ErrorHelper> DeleteUser(int id)
        {
            using (var trans = dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var userHt = dbcontext.users.FirstOrDefault(x => x.Id == id);
                    if (userHt != null)
                    {
                        dbcontext.users.Remove(userHt);
                        await dbcontext.SaveChangesAsync();
                        trans.Commit(); 
                        return ErrorHelper.XoaThanhCong;
                    }
                }
                catch (Exception)
                {
                    trans.Rollback();
                }
                return ErrorHelper.ThemThatBai;
            }
        }

        public async Task<ErrorHelper> UpdateUser(User user)
        {
            using (var trans = dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var userHT = dbcontext.users.FirstOrDefault(x => x.Id == user.Id);
                    if (userHT == null) {
                        return ErrorHelper.UserKhongTonTai;
                    }
                    else
                    {
                        userHT.Name = user.Name;
                        userHT.Email = user.Email;
                        userHT.NgaySinh = user.NgaySinh;

                        dbcontext.Update(userHT);
                        await dbcontext.SaveChangesAsync();
                        trans.Commit();
                        return ErrorHelper.SuaThanhCong;
                    }
                }
                catch (Exception) {
                    trans.Rollback();
                    return ErrorHelper.SuaThatBai;
                }
            }
        }
    }
}
