using System;
using VerifySiretGenerateTVA.services;

namespace VerifySiretGenerateTVA.Utils;

public class VerifySiretNumber : IVerifySiretNumber
{
   // Luhn Algorithm to verify if Siret number is valid
   public bool IsSiretValid(string siret)
   {
      if (string.IsNullOrEmpty(siret) || siret.Length != 14) return false;

      int sum = 0;
      bool temp = false;

      for (int i = siret.Length - 1; i >= 0; i--)
      {
         int digit = int.Parse(siret[i].ToString());

         if (temp)
         {
            digit *= 2;
            if (digit > 9)
            {
               digit -= 9;
            }
         }

         sum += digit;
         temp = !temp;
      }

      return (sum % 10 == 0);
   }
}
