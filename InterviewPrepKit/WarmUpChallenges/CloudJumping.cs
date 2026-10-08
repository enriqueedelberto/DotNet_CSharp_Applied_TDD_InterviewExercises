using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepKit.WarmUpChallenges;

public class CloudJumping
{
  public static int JumpOnClouds(List<int> clouds)
    {
        int numOfJumps = 0;

        //The array contains only zeros and ones.
        if(!clouds.All (x => x == 1 || x == 0)   )
        {
            return 0;
        }

        //First and last element should be zero.
        if ( clouds[0] != 0 &&  clouds[clouds.Count - 1] != 0)
        {
            return 0;
        }

        int cloudNumber = 1;
        while (cloudNumber < clouds.Count  )
        {
            if (clouds[cloudNumber] == 1)
            {
                cloudNumber++;
                continue;
            }

            //Begin from second index
            if(cloudNumber > 0)
            {
                //Next pair jump there is a zero
                if(cloudNumber + 1 < clouds.Count 
                    && cloudNumber + 2 < clouds.Count 
                    && clouds[cloudNumber + 1] == 0 
                    && clouds[cloudNumber + 2] == 0)
                {
                    numOfJumps++;
                    cloudNumber += 2;
                    continue;
                }
                
                    numOfJumps++;
                    cloudNumber++; 
                   
            }


        }

        return numOfJumps;
    }
}