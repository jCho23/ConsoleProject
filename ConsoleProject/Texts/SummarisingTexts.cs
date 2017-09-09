//using System;
//using System.Collections.Generic;

//namespace ConsoleProject.Texts
//{
//    class SummarisingTexts
//    {
//        static void Main(string[] args)
//        {
//            var sentence = "This is an example of a super long sentence that is best exemplified in a blog post of some kind, if you know what I mean!";
//            var summary = SummarizeText(sentence, 30);
//            Console.WriteLine(summary);
//        }

//        static string SummarizeText(string text, int maxLength = 20)
//        {
//            //Instead of hardcoding the max length here, we are passing it through the Method
//            const int maxlength = 20;

//            if (text.Length < maxlength)
//                return text;

//            else
//            {
//                //Breaking sentences into words
//                var words = text.Split(' ');
//                var totalCharacters = 0;
//                var summaryWords = new List<string>();

//                foreach (var word in words)
//                {
//                    summaryWords.Add(word);

//                    totalCharacters += word.Length + 1;
//                    if (totalCharacters > maxlength)
//                        break;
//                }

//                //Note that no words are cut off since we Split them by ' '
//                //var summary = String.Join(" ", summaryWords) + "...";
//                //return summary;

//                //This is the same code as above
//                return String.Join(" ", summaryWords) + "...";
//            }
//        }
//    }
//}
