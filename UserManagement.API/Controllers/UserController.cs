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


        [HttpPost]
        public User Post([FromBody] User user)
        {
            _users.Add(user);//ıd si belli olur
            return user;//eklediğin useri ıd si ile beraber gonderir
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editedUser= _users.FirstOrDefault(x => x.Id==user.Id);
            editedUser.Firstname=user.Firstname;
            editedUser.Lastname=user.Lastname;
            editedUser.Address = user.Address;
            
            return user;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteUser=_users.FirstOrDefault(x => x.Id==id);
            _users.Remove(deleteUser);

        }
    }
}
