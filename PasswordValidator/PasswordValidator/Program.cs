using System;
using System.Text.RegularExpressions; // Utilizing the  RegularExpressions

class PasswordValidator // Main Class anme 
{
    static void Main()
    {
        while (true) //Using the While loop 
        {
            Console.Write("Enter a password to check strength (or type 'exit' to quit): "); // when programm start running a text will be appread to show Enter a password to check strength (or type 'exit' to quit
            string password = Console.ReadLine(); // Taking input 

            if (password.ToLower() == "exit") // This command helps in the exiting the code 
                break;

            Console.WriteLine($"Password: {password} - Strength: {ValidatePassword(password)}\n"); // For validating the the input using te  strength
        }
    }

    static string ValidatePassword(string password) // here created the function for checking the password strength 
    {
        int criteriaMet = 0; // Taking a name of criteriaMet as 0 

        if (password.Length >= 8) criteriaMet++;  // this condition checking the length of the password 
        if (Regex.IsMatch(password, "[A-Z]")) criteriaMet++; //  This condition check for password uppercase the alphabets 
        if (Regex.IsMatch(password, "[a-z]")) criteriaMet++; // This condition check for the password has lowercase letters
        if (Regex.IsMatch(password, "[0-9]")) criteriaMet++; // This condition check for numeric values
        if (Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]")) criteriaMet++; // This condition check for the special charecter 
        
        //here the cheking  the password lies in which criteria
        if (criteriaMet >= 5)  // For Strong  
            return "Strong";
        else if (criteriaMet >= 3) // for Moderate
            return "Moderate";
        else  // For weak
            return "Weak";
    }
}