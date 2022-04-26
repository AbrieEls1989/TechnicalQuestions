
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

            //Loop through int array
            for (int i = 0; i < points.Length; i++)
            {

                if (Q < 0 && points[i] >= points[i - 1])
                {
                    Q = i - 1;
                }

                if ((Q >= 0 && R < 0) && (points[i] <= points[i - 1] || i +1 == points.Length))
                {

                    if (points[i] <= points[i - 1])
                    {
                        R = i - 1;
                    }
                    else
                    {
                        R = i;
                    }
                    //Getting max depth 
                    depth = Math.Max(depth, Math.Min(points[P] - points[Q],points[R]- points[Q]));
                    P = i - 1;
                    Q = R = -1;

                }

            }
            if (depth == 0)
            {
                depth = -1;
            }

            return depth;

        }


    }
}
