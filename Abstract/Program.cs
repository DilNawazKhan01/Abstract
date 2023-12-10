using System;

namespace Task_2
{
    // Singleton Pattern for Printer Class
    public class Printer
    {
        private static readonly Printer instance = new Printer();

        private Printer() { }

        public static Printer Instance => instance;

        public void Print(string message)
        {
            Console.WriteLine($"Printing: {message}");
        }
    }

    // Interface for Exam
    public interface IExam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }

    // Abstract Factory for Exam
    public interface IExamFactory
    {
        IExam CreateExam();
    }

    // Concrete class for MathExam
    public class MathExam : IExam
    {
        public void Conduct()
        {
            Console.WriteLine("Conducting Math Exam");
            Printer.Instance.Print("Conducting Math Exam");
        }

        public void Evaluate()
        {
            Console.WriteLine("Evaluating Math Exam");
            Printer.Instance.Print("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            Console.WriteLine("Publishing Math Exam Results");
            Printer.Instance.Print("Publishing Math Exam Results");
        }
    }

    // Concrete class for ScienceExam
    public class ScienceExam : IExam
    {
        public void Conduct()
        {
            Console.WriteLine("Conducting Science Exam");
            Printer.Instance.Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            Console.WriteLine("Evaluating Science Exam");
            Printer.Instance.Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            Console.WriteLine("Publishing Science Exam");
            Printer.Instance.Print("Publishing Science Exam");
        }
    }

    // Concrete class for ProgrammingExam
    public class ProgrammingExam : IExam
    {
        public void Conduct()
        {
            Console.WriteLine("Conducting Programming Exam");
            Printer.Instance.Print("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            Console.WriteLine("Evaluating Programming Exam");
            Printer.Instance.Print("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            Console.WriteLine("Publishing Programming Exam");
            Printer.Instance.Print("Publishing Programming Exam");
        }
    }

    // Concrete Factory for MathExam
    public class MathExamFactory : IExamFactory
    {
        public IExam CreateExam()
        {
            return new MathExam();
        }
    }

    // Concrete Factory for ScienceExam
    public class ScienceExamFactory : IExamFactory
    {
        public IExam CreateExam()
        {
            return new ScienceExam();
        }
    }

    // Concrete Factory for ProgrammingExam
    public class ProgrammingExamFactory : IExamFactory
    {
        public IExam CreateExam()
        {
            return new ProgrammingExam();
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Printer using Singleton pattern
            Printer printer = Printer.Instance;

            // Test that the created Printer works, by calling the Print method
            printer.Print("The print is working");

            // Ensure that only one Printer instance is used throughout the application.
            // Try to create a new Printer object and compare the two objects to check,
            // that the new printer object is the same instance
            Printer anotherPrinter = Printer.Instance;
            if (printer == anotherPrinter)
            {
                Console.WriteLine("Both printer are the in same instance");
            }

            // Use Abstract Factory to create different types of exams.
            IExamFactory mathExamFactory = new MathExamFactory();
            IExam mathExam = mathExamFactory.CreateExam();
            mathExam.Conduct();
            mathExam.Evaluate();
            mathExam.PublishResults();

            IExamFactory scienceExamFactory = new ScienceExamFactory();
            IExam scienceExam = scienceExamFactory.CreateExam();
            scienceExam.Conduct();
            scienceExam.Evaluate();
            scienceExam.PublishResults();

            IExamFactory programmingExamFactory = new ProgrammingExamFactory();
            IExam programmingExam = programmingExamFactory.CreateExam();
            programmingExam.Conduct();
            programmingExam.Evaluate();
            programmingExam.PublishResults();
        }
    }
}
