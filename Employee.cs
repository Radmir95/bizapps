using System;
using System.Collections;
using System.IO;

namespace ITHRDepartment{

    public class Employee {
        private String FIO;
        private String role;
        private String position;
        private String telephone;
        private String email;
        private String lead;
        private String subdivision;

        // data structure where we are keeping our subdivisions
        private static ArrayList subdvisions = new ArrayList();
        // data structure where we are keeping positions of emplyees
        private static ArrayList positions = new ArrayList();

        public Employee(String FIO, String role, String position, String telephone, String email, String lead, String subdivision) {
            this.FIO = FIO;
            this.role = role;
            this.position = position;
            this.telephone = telephone;
            this.email = email;
            this.lead = lead;
            this.subdivision = subdivision;
            positions.Add("junior");
            positions.Add("middle");
            positions.Add("senior");
            positions.Add("team lead");
            subdvisions.Add("09305");
            subdvisions.Add("09306");
            subdvisions.Add("09307");
            subdvisions.Add("09308");

        }

       
        public void downPosition()
        {
            int rank = positions.IndexOf(this.position);
            if (rank != 0) {
                this.position = (String)positions[rank-1];
            }


        }

        public void upPosition()
        {
            int rank = positions.IndexOf(this.position);
            if (rank != 3)
            {
                this.position = (String)positions[rank + 1];
            }

        }


        public void changeTelephone(String newTelephone) {
            this.telephone = newTelephone;
        }

        public void changeEmail(String newEmail) {
            this.email = newEmail;
        }

        // change subdivision for employee
        public void changeSubdivision(String newSubdivision)
        {
            if (subdvisions.Contains(newSubdivision))
                this.subdivision = newSubdivision;
        }

        // Working with subdivisions

            //add new subdivision
        public void addSubdivision(String newSubdivision) {
            if (!subdvisions.Contains(newSubdivision))
                subdvisions.Add(newSubdivision);
        }
            //delete subdivision
        public void deleteSubdivision(String subdivision)
        {
            if (subdvisions.Contains(subdivision))
                subdvisions.Remove(subdivision);
        }

            // edit subdivision. If subdivision will change name
        public void editSubdivision(String oldSubdivision, String newSubdivision) {
            if (subdvisions.Contains(oldSubdivision)) {
                subdvisions.Remove(oldSubdivision);
                subdvisions.Add(newSubdivision);
            }
        }

        public void printInformation() {
            Console.WriteLine(FIO + " " + role + " " + position + " " + telephone + " " + email + " " + lead + " " +subdivision);

        }

        // SECTION FOR WORKING WITH FILES

        public static ArrayList readFromFile(){

            FileStream file = new FileStream("C:/Users/Radmir.XTREME95/Desktop/employee.txt", FileMode.Open, FileAccess.Read);
            ArrayList list = new ArrayList();
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                string[] newStr = s.Split(' ');
                string[] data = new string[7];
                string k = newStr[0] + " " + newStr[1] + " " +  newStr[2];
                data[0] = k;
                data[1] = newStr[3];
                data[2] = newStr[4];
                data[3] = newStr[5];
                data[4] = newStr[6]+ " " +newStr[8];
                data[6] = newStr[9];

                list.Add(data);

            }
            reader.Close();
            return list;
            
        }

        public static void WriteToFile(Employee empl) {
            FileStream file1 = new FileStream("C:/Users/Radmir.XTREME95/Desktop/employeeWrite.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine(empl.FIO + " " + " " + empl.role + " " + empl.position + " " + empl.telephone + " " + empl.email + " " + empl.lead + " " + empl.subdivision);
            writer.Close();

        }


    }

   

   
    

}
