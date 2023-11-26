using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.Entity;
using TodoList.ISerVice;
using TodoList.Service;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        private readonly AppdbContext dbContext;
        public UserController() { 
            this._user = new UserServices();
            this.dbContext = new AppdbContext();
        }

        [HttpPost("creatUser")]
        public async Task<IActionResult> CreactUser(User user)
        {
            if (user == null)
            {
                return BadRequest("User Trông");
            }
            var result = await _user.CreatUser(user);
            if(result == ErrorHelper.UserDaTonTai)
            {
                return BadRequest("User đã tồn tại");
            }else if(result == ErrorHelper.TaoThanhCong)
            {
                return Ok("Tạo Thành Công");
            }
            return BadRequest("Thêm thất bại");


        }

        [HttpPut("updateUser")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (user == null)
            {
                return BadRequest("User Không được để trống");
            }
            var res = await _user.UpdateUser(user);
            if(res == ErrorHelper.UserKhongTonTai) {
                return BadRequest("User Không Tồn Tại");
            }else if(res == ErrorHelper.SuaThanhCong){
                return Ok("Sửa Thành Công");
            }
            return BadRequest("Sửa Thất Bại");
        }

        [HttpDelete("Delete/id")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == null)
            {
                return BadRequest("Xóa Thất Bại");
            }
            else
            {
                await _user.DeleteUser(id);
                return Ok("Xóa Thành Công");
            }
        }

        [HttpGet("getFilter")]
        public async Task<IActionResult> GetFilter(string? name, int pageIndex, int pageSize)
        {
            var query = dbContext.users.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(name.ToLower()));
            }

            // Không áp dụng phân trang nếu pageSize <= 0
            if (pageSize <= 0)
            {
                var filteredData = await query.ToListAsync();
                return Ok(filteredData);
            }

            // Phân trang
            int totalItems = await query.CountAsync();

            // Tính totalPages một cách chính xác
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // Đảm bảo rằng pageIndex hợp lệ và không vượt quá số lượng trang
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }
            else if (pageIndex > totalPages)
            {
                pageIndex = totalPages;
            }

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            var filteredDataWithPaging = await query.ToListAsync();

            // Trả về dữ liệu phân trang cùng với totalPages
            var result = new
            {
                Data = filteredDataWithPaging,
                TotalPages = totalPages
            };

            return Ok(result);
        }

    }
}
