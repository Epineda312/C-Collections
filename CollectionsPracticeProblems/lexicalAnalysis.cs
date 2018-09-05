using System.Collections.Generic;

namespace Practice
{
    public class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))
            {
                WordCount[word]++;
            }
            else
            {
                WordCount.Add(word, 1);
            }
        }
        
        public Dictionary<string, int> WordsWithCountGreaterThan(int i)
    	{
        	Dictionary<string, int> biggerWords = new Dictionary<string, int>();
        		foreach(var word in WordCount.Keys)
                {
            		if(WordCount[word] > i) 
                    {
                		biggerWords.Add(word, WordCount[word]);       
            		}
        		}
        	return biggerWords;
    	}

    }
}
