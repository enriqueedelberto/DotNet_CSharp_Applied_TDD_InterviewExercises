using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepKit.WarmUpChallenges;

public class ValleyCounting
{
    private const char UP = 'U';
    private const char DOWN = 'D';

    public static int CountValleys(int steps, string path)
    {


        if (steps < 2)
            return 0;

        if (!path.Contains(UP) || !path.Contains(DOWN))
            return 0;

        var amountOfValleys = 0;
        var seaLevel = 0;
        var consecutiveDownSteps = 0;
        var i = 0;

        while (i < steps)
        {
 
            if (path[i].Equals(DOWN))
            {
                consecutiveDownSteps++;
            }

            if (consecutiveDownSteps >= 2 && path[i].Equals(UP))
            {
                amountOfValleys++;
                consecutiveDownSteps = 0;
            }

            if (path[i].Equals(UP))
            {
                if (consecutiveDownSteps > 0)
                {
                    consecutiveDownSteps--;
                }

            }

            i++;
        }


        return amountOfValleys;
    }

}