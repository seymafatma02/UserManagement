using Microsoft.AspNetCore.Mvc;
using UserManagement.API.Fake;
using UserManagement.API.Models;


namespace UserManagement.API.Controllers

{

    [Route("api/[controller]")]// controllerimin ismi neyse api yanına o gelicek

    public class UserController:ControllerBase // miras aldım 
    {
        private List<User> _users = FakeData.GetUsers(200);



        [HttpGet]
        public List<User> Get() {
            return _users;
            
            
                }
        [HttpGet("{id}")]
        public User Get(int id)// 2 .metot ıd ye gore user getirme diger get den farkı ıd diye parametre alması
        {

            var user =_users.FirstOrDefault(x => x.Id == id);//user bulduruyor ,benim user ın id si sen parametre olarak hangi id gondermissen ona esitle demek 
            return user;
        }
    }
}
