using System;
using System.Collections.Generic;
using System.Text;

namespace Click
{
    public static class ClientData
    {
        public static List<string> Resources=new List<string>() { "Power","Iron","Copper","Fuel","Water","Stone"};
        public static List<int> points=new List<int>() { 0,0,0,0,0,0};
        public static List<int> rate=new List<int>() { 1,1,1,1,1,1};
        public static List<int> rotationState = new List<int>() { 0, 0, 0, 0, 0 ,0};
        public static List<int> rotationPer = new List<int>() { 16, 16, 16, 16, 16 , 16};
        public static List<int> mineCounts = new List<int>() { 0, 0, 0, 0 };//Inscreases rotation state by 1 per point here when production is clicked
        public static List<int> processorCounts = new List<int>() { 0,0,0};//Converts raw resources to smelted versions
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
