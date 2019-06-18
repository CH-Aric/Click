using System;
using System.Collections.Generic;
using System.Text;

namespace Click
{
    public static class ClientData
    {
        public static List<string> Resources=new List<string>() { "Power","Iron","Copper","Fuel","Water"};
        public static List<int> points=new List<int>() { 0,0,0,0,0};
        public static List<int> rate=new List<int>() { 1,1,1,1,1};
        public static List<int> rotationState = new List<int>() { 0, 0, 0, 0, 0 };
        public static List<int> rotationPer = new List<int>() { 16, 16, 16, 16, 16 };
        internal static object point;

        public static void Rotate(string Resource)
        {
            int r = Resources.IndexOf(Resource);
            rotationState[r]++;
            if (rotationState[r] >rotationPer[r])
            {
                rotationState[r] = 0;
                grantPoints(r);
            }
        }
        public static void grantPoints(int Resource)
        {
                points[Resource] += rate[Resource];
            
        }
        public static void consumePoint(string Resource)
        {
            int r= Resources.IndexOf(Resource);
            
                points[r]--;
        }
    }
}
