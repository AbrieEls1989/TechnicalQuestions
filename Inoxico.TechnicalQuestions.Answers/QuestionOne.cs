
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {

            string[] splitVal = s.Split(".");

            int maxValue = 0;
            foreach (string sValue in splitVal)
            {
                int count = Count(sValue);
                if (maxValue < count)
                {
                    maxValue = count;
                }
            }
            return maxValue;
        }

        //Counting all words in sentance.
        static int Count(string sen)
        {
            int wordCount = 0;
            for (int i = 0; i < sen.Length; i++)

                if (char.IsWhiteSpace(sen[i]) && !char.IsWhiteSpace(sen[i + 1]) && i > 0)
                    wordCount++;

            return ++wordCount;

        }
    }
}




