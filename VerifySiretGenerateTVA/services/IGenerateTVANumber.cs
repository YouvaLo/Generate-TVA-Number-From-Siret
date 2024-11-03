using System;

namespace VerifySiretGenerateTVA.services;

public interface IGenerateTVANumber
{
   string TvaBySiret(string siret);
}
