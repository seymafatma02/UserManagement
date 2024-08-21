using Microsoft.AspNetCore.Mvc;
using UserManagement.API.Fake;
using UserManagement.API.Models;


namespace UserManagement.API.Controllers

{

    [Route("api/[controller]")]// controllerimin ismi neyse api yanına o gelicek

    public class UserController:ControllerBase // miras aldım 
    {
        private List<User> _users = FakeData.GetUsers(200); 
        public List<User> Get() {
            return _users;
            
                }
    }
}
