using System;

namespace ArchiLib {

    public static class ArrayExtention {

        public static string ToArrayString(this int[] arr) {
            string str = "";
            for (int i = 0; i < arr.Length; i += 1) {
                int value = arr[i];
                str += value.ToString() + ",";
            }
            str = str.TrimEnd(',');
            return str;
        }

    }
}