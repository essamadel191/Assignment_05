namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      G-NET-12-C#-5                                 ║");
            Console.WriteLine("║                      6 Questions                                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");

            #region Enums Q1

            //Console.Write("Enter a day number (0-6): ");
            //int dayNumber = int.Parse(Console.ReadLine());
            //DayOfWeek day = (DayOfWeek)dayNumber;
            //Console.WriteLine($"Day: {day}");

            //string weekend = dayNumber switch
            //{
            //    0 => "Weekend",
            //    6 => "Weekend",
            //    _ => "Workday"
            //};
            //Console.WriteLine($"It's The {weekend}.");

            #endregion

            #region Arrays Q1

            //Console.Write("Enter array size: ");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] elements = new int[arraySize];

            //int sum = 0;
            //decimal average = 0;
            //int max = 0; 
            //int min = 0;

            //int[] reverseElements = new int[arraySize];

            //for (int i = 0; i < arraySize; i++)
            //{
            //    Console.Write($"Enter element {i}: ");
            //    elements[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arraySize; i++)
            //{
            //    sum += elements[i];
            //    average = (decimal)sum / arraySize;
            //    if (i == 0)
            //    {
            //        max = elements[i];
            //        min = elements[i];
            //    }
            //    else
            //    {
            //        if (elements[i] > max)
            //            max = elements[i];
            //        if (elements[i] < min)
            //            min = elements[i];
            //    }
            //    reverseElements[arraySize - 1 - i] = elements[i];
            //}

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");
            //Console.WriteLine($"Max: {max}");
            //Console.WriteLine($"Min: {min}");
            //Console.WriteLine("Reversed Array: " + string.Join(", ", reverseElements));

            #endregion

            #region Arrays Q2

            //int[,] student_grade = new int[3, 4];
            //int[] studentTotal = new int[3];

            ////Read
            //for (int i = 0; i < student_grade.GetLength(0); i++) {
            //    for(int j = 0; j < student_grade.GetLength(1); j++) {
            //        Console.Write($"Enter grade for student {i + 1}, subject {j + 1}: ");
            //        student_grade[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();

            ////Print
            //for (int i = 0; i < student_grade.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades for student {i + 1}: ");

            //    for (int j = 0; j < student_grade.GetLength(1); j++)
            //    {
            //        Console.Write($"subject {j + 1}: ");
            //        Console.WriteLine(student_grade[i, j] + " ");
            //    }

            //    studentTotal[i] = (student_grade[i, 0] + student_grade[i, 1] + student_grade[i, 2] + student_grade[i, 3]) / 4;
            //    Console.WriteLine();
            //}

            ////Print total grade
            //for (int i = 0;i < studentTotal.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Total grade for student {i + 1}: {studentTotal[i]}");
            //}

            #endregion

            #region Functions Q1

            //static int Add(int x, int y) {
            //    return x + y;
            //}

            //static int Subtract(int x, int y)
            //{
            //    return x - y;
            //}

            //static int Multiply(int x, int y)
            //{
            //    return x * y;
            //}

            //static double Divide(int x,int y)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Cannot divide by zero.");
            //        return 0;
            //    }
            //    return (double)x / y;
            //}

            //Console.Write($"Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write($"Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Choose operation (+, -, *, /): ");
            //string operation = Console.ReadLine();

            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine($"Result: {Add(num1, num2)}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"Result: {Subtract(num1, num2)}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"Result: {Multiply(num1, num2)}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"Result: {(num2 == 0 ? "Invalid" : Divide(num1, num2).ToString())}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation.");
            //        break;
            //}



            #endregion

            #region Functions Q2



            #endregion
        }
    }
}