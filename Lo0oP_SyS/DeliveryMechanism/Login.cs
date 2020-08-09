using Lo0oP_SyS.Interactors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lo0oP_SyS.Boundaries
{
  public partial class Login : Form
  {
    private UserBoundary userBoundary;

    /// <summary>
    /// Inicializa todos os elementos da janela
    /// </summary>
    public Login()
    {
      InitializeComponent();
      InitializeInteractor();
    }

    /// <summary>
    /// Inicializa os objetos de interação
    /// </summary>
    private void InitializeInteractor()
    {
      userBoundary = new UserBoundary();
    }

    #region Event handler
    /// <summary>
    /// Usuário clica no botão Login
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LoginClicked(object sender, System.EventArgs e)
    {
      string userNameInput = TxtBoxUserName.Text;
      string passwordInput = TxtBoxPassword.Text;

      bool[] validation = userBoundary.
        ValidateEntries(userNameInput, passwordInput);

      if (userBoundary.IsEntriesOk(validation))
      {
        userBoundary.Login(userNameInput, passwordInput);
      }
      else
      {
        if (userBoundary.IsAnyEmpty(userNameInput, passwordInput))
        {
          // Log
          Program.PopUpError("Algum campo ficou vazio");
        }
        else if (userBoundary.IsUserNameWrong(validation))
        {
          // Log
          Program.PopUpError("O nome de usuário está violando as regras");
        }
        else if (userBoundary.IsPasswordWrong(validation))
        {
          // Log
          Program.PopUpError("A senha está violando as regras");
        }
      }
    }
    #endregion

  }
}
