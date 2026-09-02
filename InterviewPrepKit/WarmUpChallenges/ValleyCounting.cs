using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepKit.WarmUpChallenges;

public class ValleyCounting
{
    private const string UP = "U";
    private const string DOWN = "D";

    public static int CountValleys(int steps, string path)
    {
        var amountOfValleys = 0;

        if (steps < 2)
            return 0;

        if (!path.Contains(UP) && !path.Contains(DOWN))
            return 0;

            var consecutiveDownSteps = 0;

        for (int i = 0; i < steps; i++)
        {
            if (path[i].Equals(DOWN))
            {
                
            }
        }    


        return amountOfValleys;
    }

}