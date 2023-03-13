using System;

namespace Project {
    class First {
        static void Main(string[] args){
            Console.Write("Input x1 Axis: ");
            float x1 = float.Parse(Console.ReadLine()); // X Position
            Console.Write("Input y1 Axis: "); 
            float y1 = float.Parse(Console.ReadLine()); // Y Position
            Console.Write("Input w1 Axis: ");
            float w1 = float.Parse(Console.ReadLine()); // Weight
            Console.Write("Input h1 Axis: ");
            float h1 = float.Parse(Console.ReadLine()); // Height
            
            Console.Write("Input x2 Axis: ");
            float x2 = float.Parse(Console.ReadLine()); // X Position
            Console.Write("Input y2 Axis: "); 
            float y2 = float.Parse(Console.ReadLine()); // Y Position
            Console.Write("Input w2 Axis: ");
            float w2 = float.Parse(Console.ReadLine()); // Weight
            Console.Write("Input h2 Axis: ");
            float h2 = float.Parse(Console.ReadLine()); // Height
            
            float max_X = 0;
            float max_Y = 0;
            float min_X = 0;
            float min_Y = 0;

            if (x1 >= x2) {
                max_X = x1-w1;
                min_X = x2+w2;
            } else {
                max_X = x2-w2;
                min_X = x1+w1;
            }

             if (y1 >= y2) {
                max_Y = y1-h1;
                min_Y = y2+h2;
            } else {
                max_Y = y2-h2;
                min_Y = y1+h1;
            }

            float ix = (min_X) - (max_X);
            float iy = (min_Y) - (max_Y);

            if (ix < 0) {
                ix = 0;
            }
            if (iy < 0) {
                iy = 0;
            }

            float intersection_Area = ix * iy;
            Console.WriteLine("Area: {0}", intersection_Area);

            // Check Condition
            if (intersection_Area > 8) {
                Console.WriteLine("Too Much Overlaping");
            } else if (intersection_Area > 0){
                Console.WriteLine("Not Much Overlapping");
            } else {
                Console.WriteLine("No Overlapping");
            }
        }

    }
}