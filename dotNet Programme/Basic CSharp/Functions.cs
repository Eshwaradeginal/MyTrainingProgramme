using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class MathComponent
    {
        //Instance method
        public long AddFunction(int iVal1, int iVal2)
        {
            long result = iVal1 + iVal2;
            return result;
        }

        public void MathFunc(double v1, double v2, out double addedValue, out double subtractedValue, out double multipliedValue, out double divValue)
        {
            addedValue = v1 + v2;
            subtractedValue = v1 - v2;
            multipliedValue = v1 * v2;
            if (v2 != 0)
                divValue = v1 / v2;
            else
                throw new DivideByZeroException();
        }

        public void SquareBasedFunc(int inputValue, ref double squareValue, ref double sqrRoot)
        {
            squareValue = inputValue * inputValue;
            sqrRoot = Math.Sqrt(inputValue);
        }
    }
    class Functions
    {
        static void Main(string[] args)
        {
            MathComponent component = new MathComponent();


            int iVal1 = 5;
            double fVal = 0, sVal = 0;
            component.SquareBasedFunc(iVal1, ref fVal, ref sVal);
            Console.WriteLine($"The fVal : {fVal} and sVal : {sVal}");

            int firstValue = 111, secondValue = 10;
            double addedVal, subVal, mulVal, divVal;
            component.MathFunc(firstValue, secondValue, out addedVal, out subVal, out mulVal, out divVal);
            Console.WriteLine($"The Added value: {addedVal}\nSubtracted Value: {subVal}\nThe multiplied Value: {mulVal}\nThe Divided Value: {divVal: ##.##}");
        }
    }
}
