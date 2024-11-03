using System;

namespace VerifySiretGenerateTVA.services;

public interface IVerifySiretNumber
{
   bool IsSiretValid(string siret);
}
