using System;
//using VerifySiretGenerateTVA.Exceptions;
using VerifySiretGenerateTVA.services;

namespace VerifySiretGenerateTVA;

public class Start
{
   private readonly IGenerateTVANumber _generateTVANumber;
   private readonly IVerifySiretNumber _verifySiretNumber;

   public Start(IVerifySiretNumber verifySiretNumber, IGenerateTVANumber generateTVANumber)
   {
      _generateTVANumber = generateTVANumber;
      _verifySiretNumber = verifySiretNumber;
   }

   public void Run()
   {
      Console.Write("Please enter the Siret number : ");
      var siret = Console.ReadLine();
      while (!_verifySiretNumber.IsSiretValid(siret))
      {
         Console.Write("The siret number is invalid, please try again : ");
         siret = Console.ReadLine();
      }

      ////Or use Invalid Exception  
      //if (!_verifySiretNumber.IsSiretValid(siret)) 
      //   throw new InvalidSiretException("The siret number is invalid, please try again ! ");

      Console.WriteLine($"The TVA number corresponding to this siret {siret} is : {_generateTVANumber.TvaBySiret(siret)}");
   }
}
