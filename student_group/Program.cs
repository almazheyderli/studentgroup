using System.Text.RegularExpressions;

namespace student_group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupNo;
            int studentLimit;

            do
            {
                Console.WriteLine("qrupun nomresini yazin:");
                groupNo = Console.ReadLine();
            } while (!GroupNo(groupNo));

            string limitStr;
            int limit;

            do
            {
                Console.WriteLine("telebe limitini daxil edin:");
                limitStr = Console.ReadLine();

            } while (!int.TryParse(limitStr, out studentLimit) || studentLimit < 1 || studentLimit > 20);

            Group group = new Group(groupNo, studentLimit);
            string choiceStr;
            int choice;
            do
            {

                Console.WriteLine("1.telebe elave et");
                Console.WriteLine("2. telebelere bax");
                Console.WriteLine("3. telebe axtar");
                Console.WriteLine("0. proqrami bitir");
                choiceStr = Console.ReadLine();

                while (!int.TryParse(choiceStr, out choice) || choice < 0 || choice > 3)
                {

                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Telebenin adini daxil edin:");
                        string fullName = Console.ReadLine();

                        string avgStr;
                        double avgPoint;
                        do
                        {
                            Console.WriteLine("Telebenin ortalama balini daxil edin:");
                            avgStr = Console.ReadLine();
                        }

                        while (!double.TryParse(avgStr, out avgPoint));


                        Student student = new Student(fullName, group.No, avgPoint);
                        group.AddStudent(student);
                        break;
                    case 2:

                        group.CheckStudents();


                        break;
                    case 3:
                        Console.WriteLine("Axtarmaq istediyiniz telebenin adini yazin:");
                        string findName = Console.ReadLine();
                        group.FindStudents(findName);
                        break;

                    case 0:
                        Console.WriteLine("proqram bitdi");
                        break;
                }
                } while (choice != 0) ;
            
            }

        static bool GroupNo(string groupNo)

        {
            
            if (groupNo.Length == 5)
            {
                return true;
            }

            if (groupNo[0]>=65 && groupNo[0]<=90 || groupNo[1]>=65 && groupNo[1]<=90)
            {
                return true;
            }

            if (groupNo[2]>=0 && groupNo[2]<=9|| groupNo[3]>=0 && groupNo[3]<=9 || groupNo[4]>=0 && groupNo[4]<=9)
            {
                return true;
            }

            return false;
        }


    }




}



    
    

