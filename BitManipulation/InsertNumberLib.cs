using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    public static class InsertNumberLib
    {
        /// <summary>
        /// The implementation algorithm which insert from the j-th to the i-th bits
        /// of one number to another so that the bits of the second number
        /// occupy positions from bit j to bit i
        /// </summary>
        /// <param name="numbSource">Is source number</param>
        /// <param name="numbIn">Is inсomming subnumber</param>
        /// <param name="indI">Index i</param>
        /// <param name="indJ">Index j</param>
        /// <exception cref=ArgumentException>
        /// Thrown if index i is greate than index j
        /// Thrown if index j out of range digits of numbers
        /// Thrown if one or both indexes lower then 0
        /// </exception>
        /// <returns>resulting number</returns>
        public static int InsertNumber(int numbSource, int numbIn, int indI, int indJ)
        {   
            if (indJ<indI) throw new ArgumentException("Index I should be <= Index J");
            if (indJ>31) throw new ArgumentException("Index J should be <= 31 digit");
            if ((indJ <0)||(indI<0)) throw new ArgumentException("Indexes should be only positive number");
            int bitsScope = indJ - indI + 1;
            int mask = -1 << bitsScope; //create mask for clearing not meaning bits numbIn 
            mask = 0 - mask - 1; //invert mask
            numbIn &= mask; //Combine mask with numbIn
            numbIn <<= indI;    //move numbIn to destination position
            int result = numbSource | numbIn;
            return result;
        }
        
    }
}
