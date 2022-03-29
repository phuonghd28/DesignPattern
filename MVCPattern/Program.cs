using System;

namespace MVCPattern
{
    interface Model
    {
        void Create(string data);
        void Display();
        void Update(string data, int id);
        void Delete(int id);
    }
    class User : Model
    {
        public void Create(string data)
        {
            Console.WriteLine($"Create {data}");
        }

        public void Delete(int id)
        {
            Console.WriteLine($"Delete User by id: {id}");
        }

        public void Display()
        {
            Console.WriteLine("Display data");
        }

        public void Update(string data, int id)
        {
            Console.WriteLine($"Update {data} by id: {id}");
        }
    }

    class UserController
    {
        private User users = new User();
        public void Index()
        {
            users.Display();
        }

        public void Add(string data) {
            users.Create(data);
        }
        public void Update(string data, int id) {
            users.Update(data, id);
        }
        public void Destroy(int id) {
            users.Delete(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserController user = new UserController();
            user.Index();
            user.Add("User");
            user.Update("User", 1);
            user.Destroy(1);
        }
    }
}
