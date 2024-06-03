using System;

namespace LearningCsharp
{
        public class Areal : Matematik
        {
            static public double arealCirkel(double r)
            {
            double arealC = Math.PI * Math.Pow(r,2);
                return arealC;
            } 
        }
}
