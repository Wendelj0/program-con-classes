using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference Reference { get; set; }
        private List<Word> Words { get; set; }
        private Random RandomGenerator = new Random();

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = new List<Word>();
            string[] splitWords = text.Split(' ');
            foreach (string word in splitWords)
            {
                Words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine(Reference.ToString());

            List<string> wordStrings = new List<string>();
            foreach (Word w in Words)
            {
                wordStrings.Add(w.ToString());
            }

            Console.WriteLine(string.Join(" ", wordStrings));
        }

        public void HideRandomWords(int count)
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word w in Words)
            {
                if (w.IsHidden == false)
                {
                    visibleWords.Add(w);
                }
            }

            if (visibleWords.Count == 0) return;

            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                int index = RandomGenerator.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public bool AllHidden()
        {
            foreach (Word w in Words)
            {
                if (w.IsHidden == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
