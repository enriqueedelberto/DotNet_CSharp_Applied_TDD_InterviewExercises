using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepKit.Arrays
{
    public class LeftRotate
    {
        /**
         * Return the left rotation of an array
         * @params
         */
        public static List<int> rotLeft(List<int> arr, int numberOfRotations)
        {
           
            while (numberOfRotations>0)
            {

                var rotateHelper = arr[0]; 
                for (var i = 1; i<arr.Count-1; i++)
                {
                     
                    var rot = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i - 1] = rot;
                }
                 


                //Last step
                arr[arr.Count - 1] = rotateHelper;
                numberOfRotations --; 

            }
            return arr; 

        }
    }
}
