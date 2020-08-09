using Lo0oP_SyS.Boundaries;
using Lo0oP_SyS.Tests.ByLayer.Boundaries;
using System;

namespace Lo0oP_SyS.Tests
{
  class TestCenter
  {
    private TestLogin testLogin { get; set; }

    /// <summary>
    /// Inicializa os objetos de testes das camadas específicas
    /// </summary>
    public TestCenter()
    {
      testLogin = new TestLogin();
    }

    /// <summary>
    /// Executa todos os testes
    /// </summary>
    public void ExecuteAll()
    {
      ExecuteAllCenterTests();
      testLogin.ExecuteAll();
    }
    /// <summary>
    /// Executa todos os testes deste objeto
    /// </summary>
    private void ExecuteAllCenterTests()
    {
      CanApplicationInitialize();
      CanLoginFormRuns();
    }

    #region General tests
    /// <summary>
    /// Testa se a aplicação está iniciando
    /// </summary>
    private void CanApplicationInitialize()
    {
      try
      {
        Program.InitializeEnvironment();
      }
      catch (Exception ex)
      {
        // Log
        Program.PopUpError(ex.Message);
      }
    }
    /// <summary>
    /// Testa se a janela de Login está sendo criada com sucesso
    /// </summary>
    private void CanLoginFormRuns()
    {
      try
      {
        GlobalVariables.frmLogin = new Login();
      }
      catch (Exception ex)
      {
        // Log
        Program.PopUpError(ex.Message);
      }
    }
    #endregion
  }
}
