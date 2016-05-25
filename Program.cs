using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITHRDepartment;

namespace Start{

    class Program{

        static void Main(string[] args){
            Employee empl1 = new Employee("Dmitriy Ivanovich Naumov", "developer", "middle", "8-960-152-65-78", "IvanovichDmitriy92@yandex.ru", "Ivan Sergeevich", "09305");
            Employee empl2 = new Employee("Dmitriy Urievich Hasanov", "qa", "team lead", "8-960-152-65-78", "DmitryHasanov@gmail.com", "Ivan Sergeevich", "09305");
            Employee empl3 = new Employee("Andrey Ivanovich Nabiullin", "project manager", "junior", "8-960-152-65-78", "andrey123@yandex.ru", "Dmitriy Kasapov", "09307");
            Employee empl4 = new Employee("Alexey Ivanovich Kuznezov", "bussiness analyst", "middle", "8-960-152-65-78", "alexis@yandex.ru", "Dmitriy Kasapov", "09307");
            Employee empl5 = new Employee("Petr Ivanovich Vasnecov", "product owner", "senior", "8-960-152-65-78", "petrvasnec@gmail.com", "Alexey Naumovich", "09308");

            Console.WriteLine("down in position");
            empl1.printInformation();
            empl1.downPosition();
            empl1.printInformation();

            Console.WriteLine("change email");
            empl1.changeEmail("svngdsn@yandex.ru");
            empl1.printInformation();

            Console.WriteLine("change subdivision");
            empl1.changeSubdivision("09308");
            empl1.printInformation();

            Console.WriteLine("Attemp to change subdivison on 09309, but nothing to happen, because this position doesn't exist");
            empl1.changeSubdivision("09309");
            empl1.printInformation();

            Console.WriteLine("add new subdivision");
            empl1.addSubdivision("09309");
            empl1.changeSubdivision("09309");
            empl1.printInformation();

            Console.WriteLine("loading from file 'employee.txt'");
            ArrayList list = Employee.readFromFile();
            String[] t = (String[])list[0];
            Console.WriteLine(t[0] + " " + t[1] + " " + t[2] + " " + t[3] + " " + t[4] + " " + t[5] + " " + t[6]);

            // write to file
            Employee.WriteToFile(empl2);

            Console.ReadKey();

            

        }
    }
}
