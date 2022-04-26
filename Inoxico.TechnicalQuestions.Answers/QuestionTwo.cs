
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            
            int depth = 0;
            int P = 0;
            int Q = -1;
            int R = -1;

            for (int i = 0; i < points.Length; i++)
            {

                if (Q < 0 && points[i] >= points[i - 1])
                { 
                }

            }
            if(depth == 0)
            {
                depth = -1;
            }

            return depth;

        }

       
    }
}
