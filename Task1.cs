using System;

namespace lab_classes
{
    // ========================= TASK #1 ========================= //


    class Person
    {
        string name;
        int age;
        static int count = 0;
        public Person()
        {
            count++;
        }
        public static void GetInfo()
        {
            System.Console.WriteLine($"Count of created object is {count}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Vualick = new Person();
            Person Denis = new Person();
            Person Vovansie = new Person();
            Person.GetInfo();
        }
    }



    // ========================= TASK #2 ========================= //


    //class User
    //{
    //    public string id { get; set; }
    //    public string name { get; set; }
    //    public string surname { get; set; }
    //    public string age { get; set; }

    //    public static int count { get; set; } = 0;

    //    public User()
    //    {
    //        count++;
    //    }

    //    public User(string obj_id, string obj_name, string obj_surname, string obj_age)
    //    {
    //        id = obj_id;
    //        name = obj_name;
    //        surname = obj_surname;
    //        age = obj_age;
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User Vualick = new User("1", "Vualick", "Boichas", "21");
    //        User Denis = new User("2", "Denis", "Mozgovenko", "21");
    //        User Vovansie = new User("3", "Vova", "Akishev", "21");
    //        User ktoto = new User("4", "Kto-to", "Ktotenko", "21");
    //        User vitalik = new User("5", "Vitaliy", "Goroshko", "21");
    //        User[] mass = new User[5];
    //        mass[0] = Vualick;
    //        mass[1] = Denis;
    //        mass[2] = Vovansie;
    //        mass[3] = ktoto;
    //        mass[4] = vitalik;

    //        Console.WriteLine("Enter search extension:");
    //        string str_search = Console.ReadLine();
    //        bool res = false;
    //        foreach (User i in mass)
    //        {
    //            if (i.id == str_search || i.name == str_search || i.surname == str_search || i.age == str_search)
    //            {
    //                Console.WriteLine(
    //                    $"User ID: {i.id}, User name: {i.name}, User Surname: {i.surname}, User Age: {i.age}"
    //                    );
    //                res = true;
    //            }
    //        }
    //        if (!res) { Console.WriteLine("We can`t find any record!"); }
    //    }
    //}


    // ========================= TASK #3 ========================= //


    //class Worker
    //{
    //    public double salary { get; set; }

    //    public static double operator +(Worker worker, double premia)
    //    {
    //        return worker.salary + premia;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker Petya = new Worker();
    //        Petya.salary = 25000;
    //        double premia = Petya.salary / 5;
    //        double payment = Petya + premia;
    //        Console.WriteLine(payment);

    //    }
    //}



    // ========================= TASK #4 ========================= //


    //class Person
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string surname { get; set; }
    //    public int age { get; set; }

    //    public static int count = 0;

    //    public Person()
    //    {
    //        id = count;
    //        name = "Default Name";
    //        surname = "Default Surname";
    //        age = 0;
    //        count++;
    //    }
    //    public Person(string Name, string Surname, int Age)
    //    {
    //        id = count;
    //        name = Name;
    //        surname = Surname;
    //        age = Age;
    //        count++;
    //    }
    //    public Person(int Id, string Name, string Surname, int Age)
    //    {
    //        id = Id;
    //        name = Name;
    //        surname = Surname;
    //        age = Age;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person defaultUser = new Person();
    //        Person user1 = new Person("Petya", "Pyatochkin", 25);
    //        Person user2 = new Person(521, "Fedor", "Malovichko", 41);

    //        Console.WriteLine(
    //            $"Default User: {defaultUser.id} | {defaultUser.name} | {defaultUser.surname} | {defaultUser.age} \n" +
    //            $"User #1: {user1.id} | {user1.name} | {user1.surname} | {user1.age}\n" +
    //            $"User #2: {user2.id} | {user2.name} | {user2.surname} | {user2.age}\n"
    //            );

    //    }
    //}

    // ========================= TASK #5 ========================= //

    //class User
    //    {
    //        public int id { get; } = 1;
    //        public string login { get; } = "Login of user";
    //        public string password { get; } = "Password of user";

    //        public User(int ID, string Login, string Password)
    //        {
    //            id = ID;
    //            login = Login;
    //            password = Password;
    //        }


    //    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User user = new User(1, "Patrick", "Zirko");
    //        Console.WriteLine($"User: \n {user.id}, {user.login}, {user.password}");
    //        //user.id = 123;  // Доступ только для чтения
    //        //user.login = "Sponge Bob";  // Доступ только для чтения
    //        //user.password = "square pants";  // Доступ только для чтения
    //        //Console.WriteLine($"Change_User: \n {user.id}, {user.login}, {user.password}");

    //    }
    //}


    // ========================= TASK #6 ========================= //
    //class Сustomer
    //{

    //    public static string name { get; set; } = "DefaultName";
    //    public static string lastName { get; set; } = "DefaultSurname";
    //    public static int age { get; set; } = 0;
    //    public static string cardNumber { get; set; }
    //    public static double orderSum { get; set; } = 0;

    //    public static void CreateCustomer()
    //    {
    //        Console.WriteLine("Enter name: ");
    //        name = Console.ReadLine();
    //        Console.WriteLine("Enter LastName: ");
    //        lastName = Console.ReadLine();
    //        Console.WriteLine("Enter Age (only numbers): ");
    //        age = Int32.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Card Number (only numbers): ");
    //        cardNumber = Console.ReadLine();
    //        Console.WriteLine("Enter full sum of the order (only numbers):");
    //        orderSum = double.Parse(Console.ReadLine());



    //    }
    //    public static double operator *(Сustomer orderSum, double sale)
    //    {
    //        return Сustomer.orderSum * sale;
    //    }
    //    public static void getInfoAboutCustomer()
    //    {
    //        Console.WriteLine(
    //            $"\n" +
    //            $" ============ Info about customer =========== \n" +
    //            $"Name: {name} \n" +
    //            $"LastName: {lastName}\n" +
    //            $"Age: {age}\n" +
    //            $"Card Number: {cardNumber}");
    //        if (orderSum > 5000)
    //        {
    //            Console.WriteLine($"Your new price is {orderSum - orderSum * 0.05}!");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Order Sum: {orderSum}");
    //        }

    //    }


    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Сustomer newCustomer = new Сustomer();
    //        Сustomer.CreateCustomer();
    //        Сustomer.getInfoAboutCustomer();
    //    }
    //}




}