using Lo0oP_SyS.Interactors.Helpers;
using System;

namespace Lo0oP_SyS.Interactors
{
  class UserInteractor
  {
    private Security security;

    /// <summary>
    /// Ao instanciar um objeto inicializa os campos necessários
    /// </summary>
    internal UserInteractor()
    {
      security = new Security();
    }

    internal void Login(string text1, string text2)
    {
      throw new NotImplementedException();
    }
  }
}
