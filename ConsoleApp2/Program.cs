using System;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;//to change font color
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Name: June Charles Mariquit   Date: March 18 2023");
            Console.WriteLine("Course/Section: BSIT - 2C     Instructor: Mr. Kaye Harris Salvacion");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.ResetColor();//to reset the font color
            string[] game_lvl = { "E", "M", "H" };//variable for game_lvl

            string gamemode;//vairable for gamemode and variable to give the command
            int point = 0;//for score

            Console.ForegroundColor = ConsoleColor.DarkYellow;//to change font color
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                       Quiz Game");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                           Game Mode");
            Console.WriteLine("                  Legend                 Mode");
            Console.WriteLine("");
            Console.WriteLine("                    E          -          Easy");
            Console.WriteLine("                    M          -         Medium");
            Console.WriteLine("                    H          -          Hard");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.ResetColor();//to reset the font color

            Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Choose Game Mode Legend: ");
            Console.WriteLine("");//to reset the font color

            gamemode = Console.ReadLine();//start of declaration of the variable
            Console.ResetColor();//to reset the font color
            Console.WriteLine("-------------------------------------------------------------------");
            if (gamemode == game_lvl[0])//easy mode
            {
                string[] answer = { "A", "B", "C", "D", "E" };//letter of the answer, variable for answer

                string answers;//variable to give command

                Console.ForegroundColor = ConsoleColor.DarkYellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("                           Choices");
                Console.WriteLine("                  Letters                 Answer");
                Console.WriteLine("");
                Console.WriteLine("                    A          -       7 Continent");
                Console.WriteLine("                    B          -         4 Ocean");
                Console.WriteLine("                    C          -           Asia");
                Console.WriteLine("                    D          -       Pacific Ocean");
                Console.WriteLine("                    E          -         Australia");
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                Console.WriteLine("     Direction: Choose the leter of the correct answer");
                Console.ResetColor();//to reset font color
                Console.WriteLine("");

                Console.WriteLine("What ocean has the largest area?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[3])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("How many continent in earth?: ");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[0])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }

                Console.WriteLine("What continent has the largest area?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[2])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.Write("What continent has the Smallest area?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[4])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.Write("How many ocean are there on earth?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[1])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }

                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.Blue;//to change text background color
                Console.WriteLine("                Your Final Score is: " + point);//to show total score
                Console.ResetColor();//to reset font color
                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color
            }
            else if (gamemode == game_lvl[1])//moderate mode
            {
                string[] answer = { "A", "B", "C", "D", "E" };//answer variable

                string answers;//answers variable

                Console.ForegroundColor = ConsoleColor.DarkYellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("                             Choices");
                Console.WriteLine("                  Letters                 Answer");
                Console.WriteLine("");
                Console.WriteLine("                    A          -          Lion");
                Console.WriteLine("                    B          -        Elephant");
                Console.WriteLine("                    C          -      Etruscan shrew");
                Console.WriteLine("                    D          -         Cheeta");
                Console.WriteLine("                    E          -      Antartic whale");
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                Console.WriteLine("     Direction: Choose the leter of the correct answer");
                Console.ResetColor();//to reset font color
                Console.WriteLine("");

                Console.WriteLine("What is the fastest animal on Earth?:");//question
                answers = Console.ReadLine();//declaration of the variable
                if (answers == answer[3])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the heaviest land animal on Earth?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[1])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the largest animal on Earth?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[4])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the smallest animal on Earth?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[2])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What animal is the king of the jungle?:");//question
                answers = Console.ReadLine();//declaration of answers variable
                if (answers == answer[0])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }

                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.Blue;//to change text background color
                Console.WriteLine("                Your Final Score is: " + point);//to show total score
                Console.ResetColor();//to reset font color
                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color


            }
            else if (gamemode == game_lvl[2])//hard mode
            {
                string[] answer = { "A", "B", "C", "D", "E" };//answer variable

                string answers;//answers variable

                Console.ForegroundColor = ConsoleColor.DarkYellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("                           Choices");
                Console.WriteLine("                  Letters                 Answer");
                Console.WriteLine("");
                Console.WriteLine("                    A          -       Benjamin Franklin");
                Console.WriteLine("                    B          -         3rd planet from the sun");
                Console.WriteLine("                    C          -           Russia");
                Console.WriteLine("                    D          -       Charles Babbage");
                Console.WriteLine("                    E          -         Vatican City");
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                Console.WriteLine("     Direction: Choose the leter of the correct answer");
                Console.ResetColor();//to reset font color
                Console.WriteLine("");

                Console.WriteLine("Who invented the electricity?:");//question
                answers = Console.ReadLine();//declaration of the answer variable
                if (answers == answer[0])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("Who invented the computer?:");//question
                answers = Console.ReadLine();//declaration of the answer variable
                if (answers == answer[3])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the largest country on Earth?:");//question
                answers = Console.ReadLine();//declaration of the answer variable
                if (answers == answer[2])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the smallest country on Earth?:");//question
                answers = Console.ReadLine();//declaration of the answer variable
                if (answers == answer[4])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }
                Console.WriteLine("What is the position of Earth in Solar System?:");//question
                answers = Console.ReadLine();//declaration of the answer variable
                if (answers == answer[1])//declaration of answers and answer variable
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//to change font color
                    Console.WriteLine("Correct");
                    Console.ResetColor();//to reset font color
                    ++point;// to add score
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//to change font color
                    Console.WriteLine("Wrong");
                    Console.ResetColor();//to reset font color
                }

                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.Blue;//to change text background color
                Console.WriteLine("                Your Final Score is: " + point);//to show total score
                Console.ResetColor();//to reset font color
                Console.ForegroundColor = ConsoleColor.Yellow;//to change font color
                Console.WriteLine("---------------------------------------------------------------");
                Console.ResetColor();//to reset font color
            }
        }
    }
}
