using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepKit.WarmUpChallenges;

public class SockMerchant
{
    public static int CountPairs(int n, List<int> ar)
    {
        var quantityOfPairs = 0;
        ar.Sort();

        for (int i = 0; i < n - 1; )
        {
            if (ar[i] == ar[i + 1])
            {
                quantityOfPairs++;
                i = i + 2;
                continue;
            }
        }
 

        return quantityOfPairs;
    }
}