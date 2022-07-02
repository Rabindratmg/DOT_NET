using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class EmployeeDetails
    {
        public EmployeeModel CreateEmployeeDetails()
        {
            Console.Write("Enter employee id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter employee name:");
            string name = Console.ReadLine();
            Console.Write("Enter employee Address:");
            string address = Console.ReadLine();

            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.Id = id;
            employeeModel.Name = name;
            employeeModel.Address = address;

            return employeeModel;
        }

        public List<EmployeeModel> UpdateEmployeeDetails(List<EmployeeModel> TemporaryemployeeList)
        {
            Console.Write("Enter the id you want to update: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;

            foreach(EmployeeModel employeeobject in TemporaryemployeeList)
            {
                if (employeeobject.Id == id)
                {
                    Console.Write("Enter the name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter the address:");
                    string address = Console.ReadLine();
                    employeeobject.Name = name;
                    employeeobject.Address = address;
                    Console.WriteLine("Id = {0} updated sucessfully \n", id);
                    return TemporaryemployeeList;
                    

                }
            }

            if (count == 0)
            {
                Console.WriteLine("Id didn't found \n");
                return TemporaryemployeeList;
            }
            return null;

           
        }


        public List<EmployeeModel> DeleteEmployee(List<EmployeeModel> Listemployee)
        {
            Console.Write("Enter the id you want to delete: ");
            int count = 0;
            int id = int.Parse(Console.ReadLine());

            foreach(EmployeeModel employye in Listemployee)
            {
                if (employye.Id == id)
                {
                    Listemployee.Remove(employye);
                    Console.WriteLine("Employee with id = {0} deleted sucessfully \n", id);
                    count++;
                    return Listemployee;
                }
                
            }
            if(count == 0)
            {
                Console.WriteLine("Id with given id is not found \n");
                return Listemployee;
            }
            return null;
            

            
            
        }


        public void DisplayEmployeeDetails(List<EmployeeModel> employeeList)
        {
            if( employeeList.Count<=0)
            {
                foreach (EmployeeModel employee in employeeList)
                {
                    Console.WriteLine("Id ={0} \t Name = {1}\t Address= {2} ", employee.Id, employee.Name, employee.Address);
                }

            }
            else
            {
                Console.WriteLine("There is no any employee in organization \n");
            }
            
        }
    }
}
