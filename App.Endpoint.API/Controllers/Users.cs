using App.Domain.AppServices.User;
using App.Domain.Core.Users.Contract.AppServices;
using App.Domain.Core.Users.Contract.Repositories;
using App.Domain.Core.Users.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Endpoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController,AllowAnonymous]
    public class Users : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IRoleAppService roleAppService;
        // just for 
        //private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUserAppServies _userAppServies;

        public Users(
            IUnitOfWork unitOfWork,
            IRoleAppService roleAppService,
            IUserAppServies userAppServies
            /*IHttpContextAccessor contextAccessor*/)
        {
            _unitOfWork = unitOfWork;
            this.roleAppService = roleAppService;
            _userAppServies = userAppServies;
            /*_contextAccessor = contextAccessor*/;
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterInputDto dto)
        {
            var token = await _userAppServies.Register(dto);
            return Ok(token);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var h = HttpContext.Request.Headers;
            var y = HttpContext.User.Identity.IsAuthenticated;
            var x = HttpContext.User.Identity.Name;
            var token = await _userAppServies.Login(dto);
            return Ok(token);
        }

        [HttpGet("GetRolesByUserId")]
        public async Task<IActionResult> GetRolesByUserId(int userId)
        {
            var result = await _unitOfWork.RoleRepository.GetRolesByUserId(userId);
            return Ok(result);
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(AddRoleDto addRoleDto)
        {
            var result = await roleAppService.RegisterRole(addRoleDto);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result);

        }


    }
}
