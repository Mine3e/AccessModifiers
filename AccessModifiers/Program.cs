using System.Text.RegularExpressions;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string _no;
            
            Console.Write("N0:");
            _no = Console.ReadLine();
            

            string _studentLimitstr="";
            int _studentLimit;
            do
            {
                Console.Write("StudentLimit:");
                _studentLimitstr = Console.ReadLine();
            } while (!int.TryParse(_studentLimitstr, out _studentLimit));
            Group group=new Group(_no,_studentLimit);
            

            int choise;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Tələbə əlavə et");
                Console.WriteLine("2. Bütün tələbələrə bax");
                Console.WriteLine("3. Tələbələr üzrə axtarış et");
                Console.WriteLine("0. Proqramı bitir");
                int.TryParse( Console.ReadLine(), out choise);
                switch( choise )
                {
                    case 0:
                        Console.WriteLine("Proses bitdi.");
                        break;
                    case 1:
                        Console.Write("FullName:");
                        string fullName= Console.ReadLine();
                       
                        string groupNostr="";
                        int groupNo;
                        do
                        {
                            Console.Write("GroupNo:");
                            groupNostr = Console.ReadLine();
                        } while (!int.TryParse(groupNostr, out groupNo));
                        string avgPointstr;
                        double avgPoint;
                        do
                        {
                            Console.Write("AvgPoint:");
                            avgPointstr = Console.ReadLine();
                        }while (!double.TryParse(avgPointstr, out avgPoint));
                        Student student = new Student(fullName, groupNo, avgPoint);
                        group.AddStudent(student);
                       

                        break;
                    case 2:
                      group.ShowAllStudents();
                        break;
                    case 3:
                        Console.Write("searchvalue :");
                        string searchvalue=Console.ReadLine();
                        group.SearchStudents(searchvalue);
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin:");
                        break ;
                    

                }
            }while(choise!=0);  



        }
    }
}
