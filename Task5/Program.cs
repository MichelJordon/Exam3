using Domain;
var studentlist = new List<User>();
var teacherlist = new List<User>();
for ( int i=0; i<2; i++ ){
    int userId = Convert.ToInt32(System.Console.ReadLine());
    string username = System.Console.ReadLine();
    string password = System.Console.ReadLine();
    var student = new Student(userId, username, password);
    var teacher = new Teacher(userId, username, password);
    studentlist.Add(student);
    teacherlist.Add(teacher);
}
foreach (var item in studentlist)
{
    item.GetUserInfo();
}
foreach (var item in teacherlist)
{
    item.GetUserInfo();
}
