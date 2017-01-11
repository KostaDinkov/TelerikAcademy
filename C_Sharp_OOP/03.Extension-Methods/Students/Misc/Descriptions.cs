namespace Homework.Misc
{
    public static class Descriptions
    {
        public const string Problem1 =
            "Problem 1. StringBuilder.Substring\r\n\r\nImplement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.";

        public const string Problem2 =
            "Problem 2. IEnumerable extensions\r\n\r\nImplement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.";

        public const string Problem3 =
            "Problem 3. First before last\r\n\r\nWrite a method that from a given array of students finds all students whose first name is before its last name alphabetically.\r\nUse LINQ query operators.";

        public const string Problem4 =
            "Problem 4. Age range\r\n\r\nWrite a LINQ query that finds the first name and last name of all students with age between 18 and 24.";

        public const string Problem5 =
            "Problem 5. Order students\r\n\r\nUsing the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.\r\nRewrite the same with LINQ.";

        public const string Problem6 =
            "Problem 6. Divisible by 7 and 3\r\n\r\nWrite a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.";

        public const string Problem7 =
            "Problem 7. Timer\r\n\r\nUsing delegates write a class Timer that can execute certain method at each t seconds.";

        public const string Problem8 =
            "Problem 8.* Events\r\n\r\nRead in MSDN about the keyword event in C# and how to publish events.\r\nRe-implement the above using .NET events and following the best practices.";

        public const string Problem9 =
            "Problem 9. Student groups\r\n\r\nCreate a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.\r\nCreate a List<Student> with sample students. Select only the students that are from group number 2.\r\nUse LINQ query. Order the students by FirstName.";

        public const string Problem10 =
            "Problem 10. Student groups extensions\r\n\r\nImplement the previous using the same query expressed with extension methods.";

        public const string Problem11 =
            "Problem 11. Extract students by email\r\n\r\nExtract all students that have email in abv.bg.\r\nUse string methods and LINQ.";

        public const string Problem12 =
            "Problem 12. Extract students by phone\r\n\r\nExtract all students with phones in Sofia.\r\nUse LINQ.";

        public const string Problem13 =
            "Problem 13. Extract students by marks\r\n\r\nSelect all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.\r\nUse LINQ.";

        public const string Problem14 =
            "Problem 14. Extract students with two marks\r\n\r\nWrite down a similar program that extracts the students with exactly two marks \"2\".\r\nUse extension methods.";

        public const string Problem15 =
            "Problem 15. Extract marks\r\n\r\nExtract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).";

        public const string Problem16 =
            "Problem 16.* Groups\r\n\r\nCreate a class Group with properties GroupNumber and DepartmentName.\r\nIntroduce a property GroupNumber in the Student class.\r\nExtract all students from \"Mathematics\" department.\r\nUse the Join operator.";

        public const string Problem17 =
            "Problem 17. Longest string\r\n\r\nWrite a program to return the string with maximum length from an array of strings.\r\nUse LINQ.";

        public const string Problem18 =
            "Problem 18. Grouped by GroupNumber\r\n\r\nCreate a program that extracts all students grouped by GroupNumber and then prints them to the console.\r\nUse LINQ.";

        public const string Problem19 =
            "Problem 19. Grouped by GroupName extensions\r\n\r\nRewrite the previous using extension methods.";
    }
}