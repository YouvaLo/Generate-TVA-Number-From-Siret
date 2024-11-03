using VerifySiretGenerateTVA.services;

namespace VerifySiretGenerateTVA.Utils;

class GenerateTVANumber : IGenerateTVANumber
{
   //Calculate French TVA Number 
   public string TvaBySiret(string siret)
   {
      var siren = siret.Substring(0, 9);
      //Calculate the control Key 
      var controlKey = (12 + 3 * (int.Parse(siren) % 97)) % 97;
      //Tva Number : FR68775701485 -> FR(2) + controlKey(2) + Siren(9) 
      return "FR" + controlKey + siren;
   }
}
