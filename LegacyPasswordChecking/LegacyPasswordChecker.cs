using System;
using System.Text.RegularExpressions;

namespace CalculatorLegacyDrills
{
    public class LegacyPasswordChecker
    {
        public bool Check(string password)
        {
            //length
            if (password.Length > 0 && password.Length < 17)
            {
                //one lower case letter, one upper case letter
                if (Regex.IsMatch(password,"[az]") && Regex.IsMatch(password,"[A-Z]"))
                {
                    //one number, one symbol
                    if (Regex.IsMatch(password,"0-9") 
                    && Regex.IsMatch(password, @"[!@#$%^&*()]"))
                    {
                        return true;
                    }
                    
                }

            }
            return false;
        }
        
    }
}