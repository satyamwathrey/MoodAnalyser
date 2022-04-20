﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-=-=-=Welcome To The Mood Analyzer Problem=-=-=-=-=-=-=-=");

            //UC1:-Respond Happy and Sad Mood
            MoodAnalyzer analyser = new MoodAnalyzer("I am in sad Mood");
            Console.WriteLine("I am in Sad Mood:- " + analyser.AnalyzeMood());
            MoodAnalyzer analysermood = new MoodAnalyzer("I am in happy Mood");
            Console.WriteLine("I am in Any Mood:- " + analysermood.AnalyzeMood());

            //UC2:-Null mood Should Return Happy
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("");
            Console.WriteLine("Given Null Message:- " + moodAnalyser.AnalyzeMood());

            Console.ReadLine();

        }
    }
}
