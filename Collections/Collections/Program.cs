// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.Models;
using System.Collections;
using Employee = Collections.Employee;


#region Operator Overloading
//Employee employee1 = new Employee();
//employee1.Name = "Pervin";
//employee1.Age = 25;
//employee1.Id = 1;

//Employee employee2 = new Employee();
//employee1.Name = "Cavid";
//employee1.Age = 22;
//employee1.Id = 2;

//var result = employee1 > employee2;

//Console.WriteLine(result);
#endregion


#region PracticeList
////Hashtable datas = new Hashtable();
////datas.Add(1, "Cavid");
////datas.Add(2, "Pervin");
////datas.Add(3, "Mirze");

////foreach (DictionaryEntry item in datas)
////{
////    //Console.WriteLine(item.Key + "-" + item.Value);

////    if ((int)item.Key == 1)
////    {
////        Console.WriteLine(item.Value);
////    }
////}
///

////SortedList datas = new SortedList();
////datas.Add(1, "Cavid");
////datas.Add(2, "Pervin");
////datas.Add(3, "Mirze");

////foreach (DictionaryEntry item in datas)
////{
////    Console.WriteLine(item.Key + "-" + item.Value);
////}

//ArrayList datas = new ArrayList();

//datas.Add("Salam");
//datas.Add(2);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//List<int> datas = new List<int>();

//datas.Add(1);
//datas.Add(40);
//datas.Add(3);
//datas.Sort();
//datas.Reverse();
//datas.Remove(1);
//var res=datas.Contains(1);
//Console.WriteLine(res);

//Console.WriteLine(datas[0]);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//List<string> names = new List<string>() { "Cavid", "Aqshin", "Shaiq"  };

//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//    if (item == "Cavid")
//    {
//        Console.WriteLine(item);
//    }
//}

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//var result = names.Find(m => m == "Cavid");
//Console.WriteLine(result);


//var result = names.FindAll(m => m == "Cavid").Count;
//Console.WriteLine(result);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//List<int> numbers = new List<int>() { 1, 2, 3, 4, };
////Console.WriteLine(numbers.Sum(m=>m));

//Console.WriteLine(numbers.FindAll(m=>m%2==0).Sum(m =>m));

//var res = numbers.FindAll(m => m % 2 == 0);
//int sum = 0;
//foreach (var item in res)

//{
//    sum += item;
//}
//Console.WriteLine(sum);

//List<Student> students = new();

//Student stu1 = new Student()
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 26,
//    Address = "Sumqayit"

//};
//Student stu2 = new Student()
//{
//    Id = 2,
//    FullName = "Ferid Abdullayev",
//    Age = 17,
//    Address = "Nesimi"

//};
//Student stu3 = new Student()
//{
//    Id = 3,
//    FullName = "Saiq Kazimov",
//    Age = 25,
//    Address = "Sedmoy",

//};
//Student stu4 = new Student()
//{
//    Id = 4,
//    FullName = "Elcan Qurbanov",
//    Age = 19,
//    Address = "Hovsan"

//};
//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3);
//students.Add(stu4);

//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}


//Console.WriteLine("Add full name");
//string fullName = Console.ReadLine();
//Console.WriteLine("Add address");
//string address = Console.ReadLine();
//Console.WriteLine("Add age");
//int age  = Convert.ToInt32(Console.ReadLine());

//Student student = new Student()
//{
//    Id=1,
//    FullName=fullName,
//    Address=address,
//    Age=age
//};

//AddStudent(student);

//static void AddStudent(Student student)
//{
//    List<Student> students = new();
//        students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName);
//    }
//}

//Console.WriteLine(GetStudentsCount());

//Console.WriteLine(GetSameNameCount());


//static int  GetSameNameCount()
//{
//    string text = "Cavid";
//    var result = GetAllStudents();
//    return result.FindAll(m=>m.FullName==text).Count();
//}


//static int GetStudentsCount()
//{
//    var students = GetAllStudents();

//    return students.Count;
//}
//static List<Student> GetAllStudents()
//{
//List<Student> students = new();

//    Student stu1 = new Student()
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 26,
//        Address = "Sumqayit"

//    };
//    Student stu2 = new Student()
//    {
//        Id = 2,
//        FullName = "Ferid Abdullayev",
//        Age = 17,
//        Address = "Nesimi"

//    };
//    Student stu3 = new Student()
//    {
//        Id = 3,
//        FullName = "Saiq Kazimov",
//        Age = 25,
//        Address = "Sedmoy",

//    };
//    Student stu4 = new Student()
//    {
//        Id = 4,
//        FullName = "Elcan Qurbanov",
//        Age = 19,
//        Address = "Hovsan"

//    };
//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    return students;

//}

//SortedList<int, string> datas = new SortedList<int, string>();
//datas.Add(1, "Cavid");

//foreach (KeyValuePair<int,string>item in datas)
//{
//    Console.WriteLine(item.Key+" "+ item.Value);
//}

//HashSet<int>types=new HashSet<int>();
//types.Add(2);
//types.Add(1);
//types.Add(1);
//foreach (var item in types)
//{
//    Console.WriteLine(item);
//}


//Stack<string>stack=new Stack<string>();
//stack.Push("Salam");
//stack.Push("Sagol");
//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

//Queue<string> queue=new Queue<string>();
//queue.Enqueue("salam");
//queue.Enqueue("Sagol");
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

//Dictionary<string,string>data=new Dictionary<string,string>();

//data.Add("Admin", "Mirze");
//data.Add("Member", "Hacker");
//data.Add("SuperAdmin","Saiq");

//foreach (KeyValuePair<string,string> item in data)
//{
//    Console.WriteLine(item.Key+" "+ item.Value);
//}

//foreach (KeyValuePair<string,string> item in data)
//{
//    if (item.Key == "Admin")
//    {
//        Console.WriteLine(item.Value);
//    }
//}

#endregion


#region Kelvin Celsius

////Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve Degree adli property-leri var. Celcius uchun implicit     
////    operatorunu yazin: (0C = 273K)


//Celsius celsius = new Celsius(56);

//Kelvin kelvin = celsius;
//Console.WriteLine(kelvin.Degree + "K");
#endregion


#region Author
//2) Author tipinden listiniz olacaq. Yashi 40-dan yuxari olan authorlarin ad ve soyadini gosteren method yazmaq.



//Author author1 = new Author()
//{
//    Id = 1,
//    Name = "Shaiq",
//    Surname = "Kazimov",
//    Age = 25
//};

//Author author2 = new Author()
//{
//    Id = 2,
//    Name = "Ferid",
//    Surname = "Abdullayev",
//    Age = 18
//};

//Author author3 = new Author()
//{
//    Id = 3,
//    Name = "Cavid",
//    Surname = "Ismayilzade",
//    Age = 15
//};

//Author author4 = new Author()
//{
//    Id = 4,
//    Name = "Konul",
//    Surname = "Ibrahimova",
//    Age = 44
//};

//List<Author> authors = new List<Author>();
//authors.Add(author1);
//authors.Add(author2);
//authors.Add(author3);
//authors.Add(author4);
//foreach (var item in authors)
//{
//    if (item.Age > 40)
//    {
//        Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname);
//    }
//}
#endregion


#region Employee
//Employee employee1 = new Employee()
//{
//    Name = "Arif",
//    Surname = "Kerimov",
//    Birhday = new DateTime(1990, 08, 12),
//    Salary = 2000
//};
//Employee employee2 = new Employee()
//{
//    Name = "Nergiz",
//    Surname = "Veliyeva",
//    Birhday = new DateTime(2004, 08, 12),
//    Salary = 2700
//};

//Employee employee3 = new Employee()
//{
//    Name = "Azer",
//    Surname = "Kerimov",
//    Birhday = new DateTime(2002, 08, 12),
//    Salary = 1500
//};
//Employee employee4 = new Employee()
//{
//    Name = "Cavid",
//    Surname = "Ezizov",
//    Birhday = new DateTime(1998, 08, 12),
//    Salary = 2200
//};

//List<Employee> employees = new List<Employee>();
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);
//Console.WriteLine(GetEmployee(new DateTime(1990, 08, 12), new DateTime(2002, 08, 12)));

//int GetEmployee(DateTime start, DateTime end)

//{
//    int count = 0;

//    foreach (var item in employees)
//    {
//      if ( item.Birhday > start && item.Birhday < end && item.Salary > 2000)
//        {
//            count++;
//        }

//    }
//    return count;  
//}

#endregion


#region PracticeTasksWithMethod
//static List<Employee> GetAllEmploye()
//{
//    List<Employee> employees = new List<Employee>();

//    Employee employee1 = new Employee()
//    {
//        Name = "Arif",
//        Surname = "Kerimov",
//        Birhday = new DateTime(1990, 08, 12),
//        Salary = 2000
//    };
//    Employee employee2 = new Employee()
//    {
//        Name = "Nergiz",
//        Surname = "Veliyeva",
//        Birhday = new DateTime(2004, 08, 12),
//        Salary = 2700
//    };

//    Employee employee3 = new Employee()
//    {
//        Name = "Azer",
//        Surname = "Kerimov",
//        Birhday = new DateTime(2002, 08, 12),
//        Salary = 1500
//    };
//    Employee employee4 = new Employee()
//    {
//        Name = "Cavid",
//        Surname = "Ezizov",
//        Birhday = new DateTime(1998, 08, 12),
//        Salary = 2200

//    };
//    employees.Add(employee1);
//    employees.Add(employee2);
//    employees.Add(employee3);
//    employees.Add(employee4);
//    return employees;
//}

//static int GetSameNameCount(DateTime start,DateTime end)
//{
//    var result = GetAllEmploye();
//    return result.FindAll(m => m.Salary>2000&&m.Birhday>start&&m.Birhday<end).Count();
//}
//Console.WriteLine(GetSameNameCount(new DateTime(1995,08,12),new DateTime(1998,11,08)));


static List<Author> GetAuthors()
{
    List<Author> authors = new List<Author>();

    Author author1 = new Author()
    {
        Id = 1,
        Name = "Shaiq",
        Surname = "Kazimov",
        Age = 25
    };

    Author author2 = new Author()
    {
        Id = 2,
        Name = "Ferid",
        Surname = "Abdullayev",
        Age = 18
    };

    Author author3 = new Author()
    {
        Id = 3,
        Name = "Cavid",
        Surname = "Ismayilzade",
        Age = 15
    };

    Author author4 = new Author()
    {
        Id = 4,
        Name = "Konul",
        Surname = "Ibrahimova",
        Age = 44
    };
    authors.Add(author1);
    authors.Add(author2);
    authors.Add(author3);
    authors.Add(author4);
    return authors;

}


static List<Author> GetAuthorsName(int age)
{
    var result = GetAuthors().FindAll(m => m.Age > age);
    return result;
    
}

static void ShowAgeName()
{
    int age = 40;
    var result = GetAuthorsName(age);
    foreach (var item in result)
    {
        Console.WriteLine(item.Name+" "+ item.Surname);
    }
}
ShowAgeName();
#endregion


