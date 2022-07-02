
using Lab2;
List<EmployeeModel> Employeelist = new List<EmployeeModel>();
int option;
do
{
   

    
    Console.WriteLine("1. Enter Employee details ");
    Console.WriteLine("2. Update Employee details ");
    Console.WriteLine("3. Delete Employee details ");
    Console.WriteLine("4. Display Employee details ");
    Console.WriteLine("5. Exit ");
    Console.Write("Please select the option from the above:");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            EmployeeDetails employeeDetails = new EmployeeDetails();
            EmployeeModel employeeModel = employeeDetails.CreateEmployeeDetails();
            Employeelist.Add(employeeModel);
            break;

        case 2:
            EmployeeDetails updateemployee = new EmployeeDetails();
            Employeelist = updateemployee.UpdateEmployeeDetails(Employeelist);
            break;

        case 3:
            EmployeeDetails deleteemployee = new EmployeeDetails();
            Employeelist = deleteemployee.DeleteEmployee(Employeelist);
            break;

        case 4:
            EmployeeDetails employeeView = new EmployeeDetails();
            employeeView.DisplayEmployeeDetails(Employeelist);
            break;

        case 5:
            break;
    }
}

while (option > 0 & option < 6);