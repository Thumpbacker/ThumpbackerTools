﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// This class has math functions not found in System.Math
/// </summary>
namespace ThumpbackerTools.Math
{
    public class MathT
    {
        //--------------------------------------
        //Median Methods
        //--------------------------------------

        /// <summary>
        /// Finds thre median of a List of ints
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Median(List<int> intList)
        {
            //Sort the list
            intList.Sort();

            //Check if it's even or odd
            if(intList.Count % 2 == 0)
            {
                //Add the two middle numbers then divide by 2
                int midOne = intList[intList.Count / 2];
                int midTwo = intList[(intList.Count / 2) + 1];

                float median = (midOne + midTwo) / 2;

                return median;
            }
            else
            {
                //Return the middle number
                return intList[intList.Count / 2];
            }
        }

        /// <summary>
        /// Finds thre median of an Array of ints
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Median(int[] intArr)
        {
            //Sort the array
            Array.Sort(intArr);

            //Check if it's even or odd
            if (intArr.Length % 2 == 0)
            {
                //Add the two middle numbers then divide by 2
                int midOne = intArr[intArr.Length / 2];
                int midTwo = intArr[(intArr.Length / 2) + 1];

                float median = (midOne + midTwo) / 2;

                return median;
            }
            else
            {
                //Return the middle number
                return intArr[intArr.Length / 2];
            }
        }

        /// <summary>
        /// Finds thre median of a List of floats
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Median(List<float> floatList)
        {
            //Sort the list
            floatList.Sort();

            //Check if it's even or odd
            if (floatList.Count % 2 == 0)
            {
                //Add the two middle numbers then divide by 2
                float midOne = floatList[floatList.Count / 2];
                float midTwo = floatList[(floatList.Count / 2) + 1];

                float median = (midOne + midTwo) / 2;

                return median;
            }
            else
            {
                //Return the middle number
                return floatList[floatList.Count / 2];
            }
        }

        /// <summary>
        /// Finds thre median of an Array of floats
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Median(float[] floatArr)
        {
            //Sort the array
            Array.Sort(floatArr);

            //Check if it's even or odd
            if (floatArr.Length % 2 == 0)
            {
                //Add the two middle numbers then divide by 2
                float midOne = floatArr[floatArr.Length / 2];
                float midTwo = floatArr[(floatArr.Length / 2) + 1];

                float median = (midOne + midTwo) / 2;

                return median;
            }
            else
            {
                //Return the middle number
                return floatArr[floatArr.Length / 2];
            }
        }

        //----------------------------------------
        //Mode Methods
        //----------------------------------------

        /// <summary>
        /// Finds the mode of an int List
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public List<int> Mode(List<int> intList)
        {
            //Create new List
            List<int> returnList = new List<int>();

            //Create a dictionaries
            Dictionary<int, int> modeDictionary = new Dictionary<int, int>();

            //Sort the list
            intList.Sort();

            //Go through the list and add numbers to the dictionary
            foreach (var num in intList)
            {
                //If the number exist in the dictionart update the value
                //Else add it to the dictionary
                if(modeDictionary.ContainsKey(num))
                {
                    modeDictionary[num] += 1; 
                }
                else
                {
                    modeDictionary.Add(num, 1);
                }
            }

            int i = 0;
            int savedValue = modeDictionary.FirstOrDefault().Value;

            //Search for the most common numbers
            foreach (var modeDict in modeDictionary)
            {
                if(i > 0)
                {
                    //If the mode count is greater then the saved value then clear the list
                    //Else if the mode coun is equal add it
                    if(modeDict.Value > savedValue)
                    {
                        returnList.Clear();
                        returnList.Add(modeDict.Key);
                        savedValue = modeDict.Value;
                    }
                    else if(modeDict.Value == savedValue)
                    {
                        returnList.Add(modeDict.Key);
                    }
                }

                i++;
            }

            returnList.Distinct();

            return returnList;
        }


        //----------------------------------------------------------------------
        //Mean Methods
        //----------------------------------------------------------------------

        /// <summary>
        /// Finds the mean
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Mean(List<int> intList)
        {
            float sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < intList.Count; i++)
            {
                sum += intList[i];
            }

            //return the sum divided by 2

            return sum / intList.Count;
        }

        /// <summary>
        /// Finds the mean
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public float Mean(int[] intArray)
        {
            float sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }

            //return the sum divided by 2

            return sum / intArray.Length;
        }

        /// <summary>
        /// Finds the mean of floats
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public float Mean(List<float> floatList)
        {
            float sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < floatList.Count; i++)
            {
                sum += floatList[i];
            }

            //return the sum divided by 2

            return sum / floatList.Count;
        }

        /// <summary>
        /// Finds the mean of floats
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public float Mean(float[] floatArray)
        {
            float sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < floatArray.Length; i++)
            {
                sum += floatArray[i];
            }

            //return the sum divided by 2

            return sum / floatArray.Length;
        }

        /// <summary>
        /// Finds the mean of decimals
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public decimal Mean(List<decimal> decimalList)
        {
            decimal sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < decimalList.Count; i++)
            {
                sum += decimalList[i];
            }

            //return the sum divided by 2

            return sum / decimalList.Count;
        }

        /// <summary>
        /// Finds the mean of decimals
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public decimal Mean(decimal[] decimalArray)
        {
            decimal sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < decimalArray.Length; i++)
            {
                sum += decimalArray[i];
            }

            //return the sum divided by 2

            return sum / decimalArray.Length;
        }

        /// <summary>
        /// Finds the mean of doubles
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public double Mean(List<double> doubleList)
        {
            double sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < doubleList.Count; i++)
            {
                sum += doubleList[i];
            }

            //return the sum divided by 2

            return sum / doubleList.Count;
        }

        /// <summary>
        /// Finds the mean of doubles
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public double Mean(double[] doubleArray)
        {
            double sum = 0;

            //Get the sum of all the numbers
            for (int i = 0; i < doubleArray.Length; i++)
            {
                sum += doubleArray[i];
            }

            //return the sum divided by 2

            return sum / doubleArray.Length;
        }
    }
}
