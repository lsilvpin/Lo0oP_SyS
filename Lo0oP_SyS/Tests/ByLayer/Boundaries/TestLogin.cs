using Lo0oP_SyS.Boundaries;
using System;
using System.Text;

namespace Lo0oP_SyS.Tests.ByLayer.Boundaries
{
  class TestLogin
  {
    private UserBoundary userBoundary;

    /// <summary>
    /// Constrói objeto incializando o que for necessário
    /// </summary>
    internal TestLogin()
    {
      userBoundary = new UserBoundary();
    }

    /// <summary>
    /// Executa todos os testes de Login
    /// </summary>
    public void ExecuteAll()
    {
      // IsEntriesValidationWorking(); Já passou neste teste!
    }

    #region Testes de Login
    /// <summary>
    /// Verifica se a validação está funcionando corretamente
    /// Mude os valores no input e vá testando
    /// Quando estiver satisfeito, coloque um valor válido e rode
    /// </summary>
    private void IsEntriesValidationWorking()
    {
      try
      {
        string userNameInput = "lsilvpin";
        string passwordInput = "Ds$o2pA4a8b";
        bool[] validation = new bool[2];
        validation = userBoundary.ValidateEntries(userNameInput, passwordInput);

        if (!userBoundary.IsEntriesOk(validation))
        {
          StringBuilder response = new StringBuilder();
          response.Append("Problema nas entradas.\n");
          if (userBoundary.IsAnyEmpty(userNameInput, passwordInput))
          {
            response.Append("Alguma está vazia!");
          }
          else if (userBoundary.IsUserNameWrong(validation))
          {
            response.Append("O nome de usuário está violando as regras.");
          }
          else if (userBoundary.IsPasswordWrong(validation))
          {
            response.Append("A senha está violando as regras.");
          }

          string output = response.ToString();
          throw new Exception(output);
        }
      }
      catch (Exception ex)
      {
        // Log ex.Message
        Program.PopUpError(ex.Message);
      }
    }
    #endregion
  }
}
