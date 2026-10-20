# C# Console Apps

Two .NET 8 console applications covering programming fundamentals: input handling, loops, conditionals, `switch` statements, regular expressions and exception handling.

> University coursework: *Fundamentals of Programming*, BSc (Hons) Computing at Regent College London.

## 1. Password Strength Validator

Checks a password against five rules and rates it **Weak**, **Moderate** or **Strong**.

| Rule | Check |
|---|---|
| Length | at least 8 characters |
| Uppercase | `[A-Z]` |
| Lowercase | `[a-z]` |
| Number | `[0-9]` |
| Special character | `[!@#$%^&*(),.?":{}|<>]` |

5 rules met = Strong · 3–4 = Moderate · 0–2 = Weak

```
Enter a password to check strength (or type 'exit' to quit): Hello123
Password: Hello123 - Strength: Moderate
```

**Concepts:** `while` loop · methods · `System.Text.RegularExpressions` · counters

## 2. Smart Home Assistant

A text-command assistant that simulates controlling lights, temperature and music.

```
Welcome to the Smart Home Assistant. Type 'exit' to quit.
Enter command: turn on lights
Lights are now ON.
Enter command: set temperature
Enter desired temperature: abc
Invalid input. Please enter a valid number.
```

Commands: `turn on lights` · `turn off lights` · `set temperature` · `play music` · `stop music` · `exit`

**Concepts:** `do…while` loop · `switch` · `try/catch` for `FormatException` · case-insensitive input

## How to run

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download). Open the `.sln` file in **Visual Studio**, or run from a terminal:

```bash
cd PasswordValidator/PasswordValidator
dotnet run
```

```bash
cd SmartHomeAssistant/SmartHomeAssistant
dotnet run
```

## Possible improvements

- Hide the password while typing, and don't print it back
- Remember device state (lights on/off, current temperature) and add a `status` command

## Author

**Gabriel Malini Rodrigues** · [LinkedIn](https://www.linkedin.com/in/gabriel-malini)
