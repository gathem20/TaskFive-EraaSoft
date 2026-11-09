while (true)
{


    System.Console.WriteLine("Main Menu");
    System.Console.WriteLine("1. Doctor Mode");
    System.Console.WriteLine("2. Student Mode");
    System.Console.WriteLine("3. Exit");

    string input = Console.ReadLine();



    if (input == "1")
    {
        System.Console.WriteLine("Welcome Doctor");
        Doctor.DoctorMode();
    }
    if (input == "2")
    {
        System.Console.WriteLine("Welcome Student");
        Student.StudentMode();
    }
    if (input == "3")
    {
        System.Console.WriteLine("Good Bye");
        return;
    }


}
