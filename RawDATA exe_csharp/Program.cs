using System;
using System.Collections.Generic;

namespace RawDATA_exe_csharp
{
    class Func_Dep
    {
        string A = "";
        string B = "";
        string C = "";
        string D = "";
        string E = "";



        List<string> LeftHandSide = new List<string>();
        List<string> RightHandSide = new List<string>();


        static void Main(string[] args)
        {
            Func_Dep test1 = new Func_Dep();
            test1.CreateList();
            Console.WriteLine(test1.Dependency("A", "B", "C"));
        }

        public void CreateList()
        {

            LeftHandSide.Add(A);
            LeftHandSide.Add(B);
            LeftHandSide.Add(C);

            RightHandSide.Add(D);
            RightHandSide.Add(E);

        }

        public string Dependency(string A, string B, string C)
        {
            LeftHandSide.Insert(0, A);
            LeftHandSide.Insert(1, B);
            LeftHandSide.Insert(2, C);


            string temp = LeftHandSide[2].ToString() + LeftHandSide[1].ToString();
            RightHandSide.Insert(0, temp);
            temp = LeftHandSide[1].ToString() + "yeah half of that";
            RightHandSide.Insert(1, temp);

            string leftSideOutput = LeftHandSide[0].ToString() + LeftHandSide[1].ToString() + LeftHandSide[2].ToString();

            string rightSideOutput = RightHandSide[0].ToString() + RightHandSide[1].ToString();

            return leftSideOutput + " -> " + rightSideOutput;
        }
    }
}