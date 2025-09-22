// 1.a Create a variable (string) with your name
const string myName = "Elin";

// 1.b Write out "Hello" and your name in the console
Console.WriteLine($"Hello {myName}");

// 2.a Create a variable (String) with name
const string name = "Elin";

// 2.b Create a variable with int containing your age
const int age = 29;

// 2.c Write out "My name is Elin and I am 29 years old"
Console.WriteLine($"My name is {name} and I am {age} years old");

// 3. What is the difference with Console.WriteLine and Console.Write? Try and see!
Console.Write("Hello");
Console.Write("World");
Console.WriteLine("Hello");
Console.WriteLine("World");

// 4.a and b Write out "Write your surname" and recive the input into a variable and let the marker wait for your input on the same line
Console.Write("Write your surname: ");
string? surname = Console.ReadLine();

// 4.c Write out "Write your lastname" and recive the input into a variable
Console.Write("Write your lastname: ");
string? lastname = Console.ReadLine();

// 4.d Then write out the input in reversed order "Your name is: lastname, surname"
Console.WriteLine($"Your name is: {lastname}, {surname}");

// 5.a Enter number 1:
Console.Write($"Enter the first number: ");
string? firstNumber = Console.ReadLine() ?? "0";

// 5.b Store this number in a variable

int numberOne = int.Parse(firstNumber);

// 5.c Enter number 2:
Console.Write($"Enter the second number: ");
string? secondNumber = Console.ReadLine() ?? "0";

// 5.d Store the value of this number
int numbertwo = int.Parse(secondNumber);

// 5.e Add number1 and number2 into a sum

int sum = numberOne + numbertwo;

// 5.f Print on the screen – The sum of number1 and number2 is: sum
Console.WriteLine($"The sum of the first number and the second number is: {sum}");

// 6.a. Receive the birth year and store it in a variable
Console.Write("Enter your birth year: ");
string? birth = Console.ReadLine() ?? "0";
int birthYear = int.Parse(birth);

// 6.b. Calculate the person's age
DateTime today = DateTime.Now;
int currentYear = today.Year;
int currentAge = currentYear - birthYear;

// 6.c. Print on the screen – Your age is: age
Console.WriteLine($"Your age is: {currentAge}");
