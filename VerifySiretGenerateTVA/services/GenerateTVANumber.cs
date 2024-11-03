using VerifySiretGenerateTVA.services;

namespace VerifySiretGenerateTVA.Utils;

class GenerateTVANumber : IGenerateTVANumber
{
   //Calculate French TVA Number 
   public string TvaBySiret(string siret)
   {
      var siren = siret.Substring(0, 9);
      var controlKey = (12 + 3 * (int.Parse(siren) % 97)) % 97;
      return "FR" + controlKey + siren;
   }
}
