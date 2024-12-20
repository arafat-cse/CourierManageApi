using CourierManageApi.Attributes;
using CourierManageApi.Models;
using CourierManageApi.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourierManageApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDetail>> GetUserDetail(int id)
        {
            CourierApiContext _context = new CourierApiContext();
            var userDetail = await _context.UserDetails.FindAsync(id);

            if (userDetail == null)
            {
                return NotFound();
            }

            return userDetail;
        }

        // POST: api/Login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [EnableCors("Policy1")]
        [HttpPost]
        public async Task<IActionResult> PostUserDetail(UserDetail userDetail)
        {
            CourierApiContext _context = new CourierApiContext();
            var oUserDetail = await _context.UserDetails.Where(x => x.UserName == userDetail.UserName && x.PassWord == userDetail.PassWord).FirstOrDefaultAsync();
            if (oUserDetail == null)
            {
                return NotFound();
            }
            else
            {
                if (oUserDetail != null)
                {
                    #region Token
                    var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                    var WebClient = MyConfig.GetValue<string>("WebClient");
                    var TokenExpire = MyConfig.GetValue<int>("TokenExpire");
                    oUserDetail.PassWord = JsonWebToken.Encode(new UserPayload() { CreateDate = DateTime.Now, UserId = oUserDetail.UserId, TokenExpire = TokenExpire, UserName = oUserDetail.UserName }, WebClient, JwtHashAlgorithm.HS512);
                    #endregion
                }
                return CreatedAtAction("GetUserDetail", new { id = oUserDetail.UserId }, oUserDetail);
            }
        }


        private bool UserDetailExists(int id)
        {
            CourierApiContext _context = new CourierApiContext();
            return _context.UserDetails.Any(e => e.UserId == id);
        }
    }
}
