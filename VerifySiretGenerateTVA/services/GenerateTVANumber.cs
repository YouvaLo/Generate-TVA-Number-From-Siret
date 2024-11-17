using VerifySiretGenerateTVA.services;

namespace VerifySiretGenerateTVA.Utils;

class GenerateTVANumber : IGenerateTVANumber
{
   //Calculate French TVA Number 
   public string TvaBySiret(string siret)
   {
      var siren = siret.Substring(0, 9);
      //Calculate the control Key (12 : Country Code, 97 to put controlKey between 0 and 96)
      var controlKey = ((12 + 3 * (int.Parse(siren) % 97)) % 97).ToString();

      if(controlKey.Length == 1) controlKey = "0" + controlKey;

      //Tva Number : FR68775701485 -> FR(2) + controlKey(2) + Siren(9) 
      return "FR" + controlKey + siren;
   }
}
