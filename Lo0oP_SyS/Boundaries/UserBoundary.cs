using Lo0oP_SyS.Interactors;
using System;
using System.Text.RegularExpressions;

namespace Lo0oP_SyS.Boundaries
{
  class UserBoundary
  {
    private UserInteractor userInteractor;

    /// <summary>
    /// Constrói uma instância inicializando o objeto userInteractor
    /// </summary>
    internal UserBoundary()
    {
      userInteractor = new UserInteractor();
    }

    /// <summary>
    /// Faz a validação das entradas (usando Regular expressions)
    /// </summary>
    /// <param name="userName">Nome de usuário</param>
    /// <param name="password">Senha</param>
    internal bool[] ValidateEntries(string userName, string password)
    {
      bool[] response = new bool[2];

      response[0] = Regex.IsMatch(
          userName,
          @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$"
      );

      response[1] = Regex.IsMatch(
          password,
          @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"
      );

      return response;
    }
    /// <summary>
    /// Verifica se as entradas estão satisfazendo as regras
    /// </summary>
    /// <param name="validationResponse">Resposta da camada Interactor</param>
    /// <returns>true se os campos estiverem Ok, false caso contrário</returns>
    internal bool IsEntriesOk(bool[] validationResponse)
    {
      return validationResponse[0] && validationResponse[1];
    }
    /// <summary>
    /// Delega o processo de login para Interactor
    /// </summary>
    /// <param name="userNameInput">Nome de usuário digitado</param>
    /// <param name="passwordInput">Senha digitada</param>
    internal void Login(string userNameInput, string passwordInput)
    {
      userInteractor.Login(userNameInput, passwordInput);
    }
    /// <summary>
    /// Verifica se algum campo está vazio
    /// </summary>
    /// <param name="userNameInput">Campo do nome de usuário</param>
    /// <param name="passwordInput">Campo da senha</param>
    /// <returns>true se algum estiver vazio, false caso contrário</returns>
    internal bool IsAnyEmpty(string userNameInput, string passwordInput)
    {
      return userNameInput == String.Empty || passwordInput == String.Empty;
    }
    /// <summary>
    /// Verifica se o nome de usuário está violando as regras
    /// </summary>
    /// <param name="validationResponse">Resposta do Interactor</param>
    /// <returns>true se o UserName estiver violando, false caso contrário</returns>
    internal bool IsUserNameWrong(bool[] validationResponse)
    {
      return !validationResponse[0];
    }
    /// <summary>
    /// Verifica se a senha está violando as regras
    /// </summary>
    /// <param name="validationResponse">Resposta da Interactor</param>
    /// <returns>true se a senha estiver violando, false caso contrário</returns>
    internal bool IsPasswordWrong(bool[] validationResponse)
    {
      return !validationResponse[1];
    }
    
  }
}
