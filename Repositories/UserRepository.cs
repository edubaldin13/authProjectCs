using ApiAuthCSharp.Models;

namespace ApiAuthCSharp.Repositories
{
    public class UserRepository{
        public static User GetUser(string username, string password){
            var users = new List<User>
           { 
            new () {Id=1,Username="Batman",Password="1234",Role="manager"},
            new () {Id=1,Username="Robin",Password="1234",Role="employee"}
            };

            return users.
            FirstOrDefault(x => x.Username == username && x.Password == password);}
    }
}