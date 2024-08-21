using Microsoft.AspNetCore.Mvc;


namespace UserManagement.API.Controllers

{

    [Route("api/[controller]")]// controllerimin ismi neyse api yanına o gelicek

    public class UserController:ControllerBase // miras aldım 
    {
        public string Get() {

            return " Get users";
                }
    }
}
