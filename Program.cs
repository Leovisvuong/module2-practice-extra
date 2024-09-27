using System.Globalization;
/*
// concatenation
// Q2
// part 1
string firstName = "Leovis";
string lastName = "Vuong";
Console.WriteLine(firstName + " " + lastName);

// part 2
Console.Write("Enter your firt name: ");
firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
lastName = Console.ReadLine();
Console.WriteLine(firstName + " " + lastName);

// part 3
firstName = "Clan";
string middleName = "of";
lastName = "fire";
Console.WriteLine(firstName + " " + middleName + " " + lastName);

// part 4
firstName = "Leovis";
float lastNameInInteger = 2008;
Console.WriteLine(firstName + lastNameInInteger);
*/



/*
// conversion
// Q3
// part 1
Console.Write("Enter your height in meters: ");
float height = float.Parse(Console.ReadLine());
Console.Write("Enter your weight in kilograms: ");
float weight = float.Parse(Console.ReadLine());
float BMI = weight/(height*height);
Console.WriteLine("Your BMI is " + BMI);
string message = "";
switch(BMI){
    case < 18.5f:
        message = "Underweight";
        break;
    case < 25:
        message = "Normal";
        break;
    case < 30:
        message = "Overweight";
        break;
    case >= 30:
        message = "Obese";
        break;
}
Console.WriteLine("You are " + message);

// part 2
Console.Write("Enter your height in feet: ");
float heightInFeet = float.Parse(Console.ReadLine());
Console.Write("Enter your height in inches: ");
float heightInInches = float.Parse(Console.ReadLine());
Console.Write("Enter your weight in pounds: ");
weight = float.Parse(Console.ReadLine());
BMI = (weight*703)/(heightInFeet*heightInInches);
Console.WriteLine("Your BMI is " + BMI);
message = "";
switch(BMI){
    case < 18.5f:
        message = "Underweight";
        break;
    case < 25:
        message = "Normal";
        break;
    case < 30:
        message = "Overweight";
        break;
    case >= 30:
        message = "Obese";
        break;
}
Console.WriteLine("You are " + message);

// part 3
Console.Write("Player's Score: ");
float score = float.Parse(Console.ReadLine());
Console.WriteLine("Player's Score with one decimal place: " + score.ToString("0.0"));

// part 4
Console.Write("Player's Health: ");
float health = float.Parse(Console.ReadLine());
Console.WriteLine("Player's Health as a percentage: " + health*100 + "%");

// part 5
Console.Write("Player's Coins: ");
float coins = float.Parse(Console.ReadLine());
Console.WriteLine("Player's Score with one decimal place: " + coins.ToString("0"));

// part 6
Console.Write("Player's Progress: ");
bool progress = bool.Parse(Console.ReadLine());
Console.Write("Player's Progress as a string: ");
if(progress) Console.Write("Completed");
else Console.Write("Incompleted");
*/


/*
// date_time
// Q2
// part 1
Console.Write("Enter the date: ");
string date = Console.ReadLine();
Console.Write("Enter the number of days to add or subtract: ");
int numberOfDays = int.Parse(Console.ReadLine());
int day = Int32.Parse(date.Substring(0,2));
int month = Int32.Parse(date.Substring(3,2));
int year =Int32.Parse(date.Substring(6,4));
DateTime inputDate = new DateTime(year,month,day);
Console.WriteLine("Date after " + numberOfDays + " days: " + (inputDate.AddDays(numberOfDays)).ToString("dd/MM/yyyy"));
Console.WriteLine("Date before " + numberOfDays + " days: " + inputDate.AddDays(-numberOfDays).ToString("dd/MM/yyyy"));

// part 2
Console.Write("Enter the date: ");
date = Console.ReadLine();
day = Int32.Parse(date.Substring(0,2));
month = Int32.Parse(date.Substring(3,2));
year =Int32.Parse(date.Substring(6,4));
inputDate = new DateTime(year,month,day);
DateTime nowDate = DateTime.Now;
TimeSpan dateLived = nowDate - inputDate;
inputDate = DateTime.MinValue.AddDays(dateLived.Days-1);
Console.WriteLine("You are " + (inputDate.Year-1) + " years, " + (inputDate.Month-1) + " months, " + inputDate.Day + " days old");

// part 3
Console.Write("Enter the first date: ");
date = Console.ReadLine();
day = Int32.Parse(date.Substring(0,2));
month = Int32.Parse(date.Substring(3,2));
year =Int32.Parse(date.Substring(6,4));
DateTime inputDate1 = new DateTime(year,month,day);
Console.Write("Enter the second date: ");
date = Console.ReadLine();
day = Int32.Parse(date.Substring(0,2));
month = Int32.Parse(date.Substring(3,2));
year =Int32.Parse(date.Substring(6,4));
DateTime inputDate2 = new DateTime(year,month,day);
TimeSpan daysDifference = inputDate2 - inputDate1;
Console.WriteLine("The difference between two dates is: " + daysDifference.Days + " days");

// part 4
Console.Write("Enter the number of days: ");
day = Int32.Parse(Console.ReadLine());
Console.WriteLine("Years: " + day/365 + "\nWeeks: " + (day%365)/7 + "\nDays: " + (day%365)%7);

// part 5
List<string> daysOfWeek = new List<string> {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
Console.Write("Enter the number of day: ");
day = Int32.Parse(Console.ReadLine());
Console.WriteLine(daysOfWeek[(day-1)%7]);

// part 6
Console.WriteLine("The current date is: " + DateTime.Now.ToString("dd/MM/yyyy"));

// part 7
Console.Write("The current date and time is: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
*/




// // DD programing
// // Q1-try_catch
// // part 1
// try{
//     int divisor = 10;
//     int dividend = 0;
//     int number = divisor/dividend;
// }
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }

// // part 2
// try{
//     int number = int.Parse("abc");
// }
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }

// // part 3
// try{
//     FileStream file = File.Open("nothing.txt",FileMode.Open,FileAccess.Read);
// }
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }

// // part 4
// try{
//     Console.Write("Enter anything to assign to an integer variable: ");
//     int intVariable = int.Parse(Console.ReadLine());
//     Console.WriteLine("input value can be assigned");
// }
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }

// // part 5
// try{
//     int a = 0;
//     double floatNumber = 1*5/a;
// }
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }



// // Q2-exceptions
// // part 1
// try{
//     Console.Write("Enter first number: ");
//     int numberA = int.Parse(Console.ReadLine());
//     Console.Write("Enter second number: ");
//     int numberB = int.Parse(Console.ReadLine());
//     Console.WriteLine(numberA/numberB);
// }
// catch(FormatException e){
//     Console.WriteLine(e.Message);
// }
// catch(DivideByZeroException e){
//     Console.WriteLine(e.Message);
// }

// // part 2
// try{
//     Console.Write("Enter a string to convert to an integer: ");
//     int number = int.Parse(Console.ReadLine());
//     Console.WriteLine("input value can be assigned");
// }
// catch(FormatException e){
//     Console.WriteLine(e.Message);
// }

// // part 3
// try{
//     int number = 0;
//     float floatNumber = 12/number;
// }
// catch(DivideByZeroException e){
//     Console.WriteLine(e.Message);
// }

// // part 4
// try{
//     Console.Write("Enter a string: ");
//     string String = Console.ReadLine();
//     if(String == "") String = null;
//     Console.WriteLine(String.ToUpper());
// }
// catch(NullReferenceException e){
//     Console.WriteLine(e.Message);
// }



/*
// Q3-file
//My Telephone Directory
string filePath = "PhoneDirectory.csv";
if (!File.Exists(filePath)){
   using (StreamWriter sw = File.CreateText(filePath)){
       sw.WriteLine("Name,Phone Number");
   }
}
int recordCount = 0;
string inputName, inputPhoneNumber;
do
{
   Console.Write("Enter name (or 'Exit' to quit): ");
   inputName = Console.ReadLine();
   if (inputName.ToLower() == "exit")
       break;
    Console.Write("Enter phone number: ");
    inputPhoneNumber = Console.ReadLine();
    using (StreamWriter sw = File.AppendText(filePath))
    {
       sw.WriteLine(inputName + "," + inputPhoneNumber);
    }
    recordCount++;
} while (true);
    Console.WriteLine("Number of records appended: " + recordCount);

// library loan
string inputFile = "loaninfo.csv";
string outputFile = "overdueinfo.csv";
try
{
   string[] lines = File.ReadAllLines(inputFile);
   using (StreamWriter sw = new StreamWriter(outputFile))
   {
       Console.WriteLine("{0,-10} {1,-12} {2,-14} {3,-14} {4,-12} {5,-13} {6,-8}", "Book ID", "Borrower ID", "Date Borrowed", "Date Returned", "Days Loaned", "Days Overdue", "Fine");
       sw.WriteLine("Book ID, Borrower ID, Days Overdue, Fine");
       for (int i = 1; i < lines.Length; i++)
       {
           string[] parts = lines[i].Split(',');
           string bookID = parts[0];
           string borrowerID = parts[1];
           DateTime dateBorrowed = DateTime.ParseExact(parts[2], "d/M/yyyy", CultureInfo.InvariantCulture);
           DateTime dateReturned = DateTime.ParseExact(parts[3], "d/M/yyyy", CultureInfo.InvariantCulture);
           int daysLoaned = (int)(dateReturned - dateBorrowed).TotalDays;
           int daysOverdue = Math.Max(daysLoaned - 14, 0);
           double fine = daysOverdue * 0.5;
           Console.WriteLine($"{bookID,-10} {borrowerID,-12} {dateBorrowed,-14:yyyy-MM-dd} {dateReturned,-14:yyyy-MM-dd} {daysLoaned,-12} {daysOverdue,-13} ${fine,-8:F2}");
           if (daysOverdue > 0)
           {
               sw.WriteLine($"{bookID}, {borrowerID}, {daysOverdue}, ${fine:F2}");
           }
       }
   }
}
catch (Exception e)
{
   Console.WriteLine($"An error occurred: {e.Message}");
}
*/