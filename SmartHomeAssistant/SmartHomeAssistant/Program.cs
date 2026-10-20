using System;

class SmartHomeAssistant // Main classname 
{
    static void Main()
    {
        string command;

        Console.WriteLine("Welcome to the Smart Home Assistant. Type 'exit' to quit."); // Welcome Text

        do  //Using Do while loop for managingthe conditions
        {
            Console.Write("Enter command: "); 
            command = Console.ReadLine().ToLower(); // Convert input to lowercase for consistency

            switch (command)  //using the switch 
            {
                case "turn on lights": //Commmands for light on 
                    Console.WriteLine("Lights are now ON.");
                    break;
                case "turn off lights": //Commmands for light off
                    Console.WriteLine("Lights are now OFF.");
                    break;
                case "set temperature": //Commmands for set temperature
                    Console.Write("Enter desired temperature: ");

                    try  //using try block handeling the error situation
                    {
                        int temperature = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Temperature set to {temperature} degrees.");
                    }
                    catch (FormatException) // catch block handles invalid (non-numeric) input
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break; // Break used for stopping the flow of program for further execution 
                case "play music": //Commmands for Play music
                    Console.WriteLine("Playing your favourite music.");
                    break;
                case "stop music": // Commmands for stop music
                    Console.WriteLine("Music stopped.");
                    break;
                case "exit": //Exit command for exxiting the programm
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Invalid command."); // If any other invalid input is given it will throw a message of invalid command
                    break;
            }
        } while (command != "exit");
    }
}
