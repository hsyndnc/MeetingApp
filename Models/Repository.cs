namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        public static List<UserInfo> Users { 
            get {
                return _users;
            }
        }

        static Repository()
        {
            _users.Add(new UserInfo() { Id=  1, Name ="Ali" , Email="abc@gmail.com", Phone="111111111",WillAttend=true});
            _users.Add(new UserInfo() { Id = 2, Name = "Mehmet", Email = "abc@gmail.com", Phone = "2222222222", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Can", Email = "abc@gmail.com", Phone = "33333333333333", WillAttend = true });
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count +1 ;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id==id);
        }

    }
}