﻿namespace BashSoft
{
    class Launcher
    {
        private static void Main(string[] args)
        {
            //Exercise 1 Test
            //IOManager.TraverseDirectory(@"D:\GitHub\CSharp-Fundamentals-Software-University\CSharp Advance Course\BashSoft\BashSoft");

            //Exercise 2 Tests
            //StudentsRepository.InitializeData();
            ////StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //Exercise 3 Tests
            //Tester.CompareContent(@"..\..\test1.txt", @"..\..\test2.txt");
            //Tester.CompareContent(@"..\..\test2.txt", @"..\..\test3.txt");
            //IOManager.CreateDirectoryInCurrentFolder("pesho");
            //IOManager.ChangeCurrentDirectoryRelative("pesho");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.TraverseDirectory(900);

            //Exercise 4 Tests
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);
            //IOManager.CreateDirectoryInCurrentFolder("*gesho");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");

            InputReader.StartReadingCommands();
        }
    }
}