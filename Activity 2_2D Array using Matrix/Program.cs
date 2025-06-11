using System;
class StudentGrades
{
    static void Main()
    {

        int[,] grades = new int[5, 3]
        {
          {83, 76, 75},  //S1
          {77, 89, 78},  //S2
          {90, 86, 92},  //S3
          {84, 89, 95},  //S4
          {93, 95, 91}   //S5
        };
        Console.WriteLine("Grades Matrix:\n");
        DisplayGradesMatrix(grades);
        Console.WriteLine("\nAverage Grades per Student:\n");
        CalculateStudentAverages(grades);
        Console.WriteLine("\nHighest Grades per Subject:\n");
        FindSubjectHighest(grades);
        Console.WriteLine("\nMedian Grade per Subject:\n");
        CalculateSubjectMedians(grades);
        Console.WriteLine("\nPress any key to exit...\n");
        Console.ReadKey();
    }

    static void DisplayGradesMatrix(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);
        for (int i = 0; i < studentCount; i++)
        {
            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"{grades[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    static void CalculateStudentAverages(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);
        for (int i = 0; i < studentCount; i++)
        {
            int sum = 0;
            for (int j = 0; j < subjectCount; j++)
            {
                sum += grades[i, j];
            }
            double average = (double)sum / subjectCount;
            Console.WriteLine($"Student {i + 1}: {average:F0}");
        }
    }

    static void FindSubjectHighest(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);
        for (int j = 0; j < subjectCount; j++)
        {
            int highest = grades[0, j];
            for (int i = 1; i < studentCount; i++)
            {
                if (grades[i, j] > highest)
                {
                    highest = grades[i, j];
                }
            }
            Console.WriteLine($"Subject {j + 1}: {highest:F0}");
        }
    }

    static void FindSubjectLowest(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);
        for (int j = 0; j < subjectCount; j++)
        {
            int lowest = grades[0, j];
            for (int i = 1; i < studentCount; i++)
            {
                if (grades[i, j] < lowest)
                {
                    lowest = grades[i, j];
                }
            }
            Console.WriteLine($"Subject {j + 1}: {lowest:F0}");
        }
    }
    static void CalculateSubjectMedians(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);
        for (int j = 0; j < subjectCount; j++)
        {
            int[] subjectGrades = new int[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                subjectGrades[i] = grades[i, j];
            }
            Array.Sort(subjectGrades);
            double median;
            if (studentCount % 2 == 0)
            {
                median = (subjectGrades[studentCount / 2 - 1] + subjectGrades[studentCount / 2]) / 2.0;
            }
            else
            {
                median = subjectGrades[studentCount / 2];
            }
            Console.WriteLine($"Subject {j + 1}; {median:F0}");
        }
    }
}
