public class Solution {
    public string AddBinary(string a, string b) {
    
     int i = a.Length - 1;
     int j = b.Length - 1;
     string result = "";
     int carry = 0;

     while(i >= 0 || j >= 0 || carry == 1)
     {
         int sum = carry;
         
         // Convert char to int subtract '0'
         // if index out of range means negative add 0 instead
         sum += (i >= 0) ? a[i] - '0': 0;
         sum += (j >= 0) ? b[j] - '0': 0;

         int quotient = sum / 2;
         int rem = sum % 2;
         result = rem + result;
         carry = quotient;
         i--; j--;
     }
    
    return result;
    }
}