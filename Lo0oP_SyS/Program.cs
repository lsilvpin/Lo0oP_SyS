using System;
using System.Windows.Forms;
using Lo0oP_SyS.Boundaries;
using Lo0oP_SyS.Tests;

namespace Lo0oP_SyS
{
  static class Program
  {
    static private TestCenter testCenter;

    /// <summary>
    ///  Executa a aplicação testando-a
    /// </summary>
    [STAThread]
    static void Main()
    {
      testCenter = new TestCenter();
      testCenter.ExecuteAll();
    }

    /// <summary>
    /// Prepara o ambiente para a aplicação
    /// </summary>
    static internal void InitializeEnvironment()
    {
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      testCenter = new TestCenter();
    }
    /// <summary>
    /// Instancia a janela de login e a inicializa
    /// </summary>
    static internal void RunFormLogin()
    {
      Application.Run(new Login());
    }

    #region Utility tools
    /// <summary>
    /// Faz aparecer uma jenela de erro, informando o que deu errado
    /// </summary>
    /// <param name="errorMessage">Mensagem informativa</param>
    static internal void PopUpError(string errorMessage)
    {
      MessageBox.Show(
        errorMessage,
        "Alerta de erro",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error
      );
    }
    #endregion
  }
}
