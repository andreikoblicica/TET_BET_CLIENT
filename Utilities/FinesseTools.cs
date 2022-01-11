using System;
using System.Collections.Generic;

namespace TET_BET.Utilities
{
    public static class FinesseTools
    {
        public static List<int> ByteArrayToIntList(byte[] byteArray)
        {
            List<int> intsList = new List<int>();

            int arraySize = byteArray.Length;

            byte[] byteArrayOfSize4;

            for (int i = 0; i < arraySize; i += 4)
            {
                byteArrayOfSize4 = new byte[4];
                byteArrayOfSize4[0] = byteArray[i];
                byteArrayOfSize4[1] = byteArray[i + 1];
                byteArrayOfSize4[2] = byteArray[i + 2];
                byteArrayOfSize4[3] = byteArray[i + 3];

                intsList.Add(ByteArrayOfSize4ToInt(byteArrayOfSize4));
            }

            return intsList;
        }

        private static int ByteArrayOfSize4ToInt(byte[] byteArrayOfSize8)
        {
            return BitConverter.ToInt32(byteArrayOfSize8, 0);
        }
    }
}