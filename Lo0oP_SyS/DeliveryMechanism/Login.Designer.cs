namespace Lo0oP_SyS.Boundaries
{
  partial class Login
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnLogin = new System.Windows.Forms.Button();
      this.TxtBoxUserName = new System.Windows.Forms.TextBox();
      this.LblUserName = new System.Windows.Forms.Label();
      this.TxtBoxPassword = new System.Windows.Forms.TextBox();
      this.LblPassword = new System.Windows.Forms.Label();
      this.GrpBoxLogin = new System.Windows.Forms.GroupBox();
      this.GrpBoxLogin.SuspendLayout();
      this.SuspendLayout();
      // 
      // BtnLogin
      // 
      this.BtnLogin.Location = new System.Drawing.Point(155, 259);
      this.BtnLogin.Name = "BtnLogin";
      this.BtnLogin.Size = new System.Drawing.Size(94, 29);
      this.BtnLogin.TabIndex = 0;
      this.BtnLogin.Text = "Login";
      this.BtnLogin.UseVisualStyleBackColor = true;
      this.BtnLogin.Click += new System.EventHandler(this.LoginClicked);
      // 
      // TxtBoxUserName
      // 
      this.TxtBoxUserName.Location = new System.Drawing.Point(41, 101);
      this.TxtBoxUserName.Name = "TxtBoxUserName";
      this.TxtBoxUserName.Size = new System.Drawing.Size(208, 30);
      this.TxtBoxUserName.TabIndex = 1;
      // 
      // LblUserName
      // 
      this.LblUserName.AutoSize = true;
      this.LblUserName.Location = new System.Drawing.Point(41, 66);
      this.LblUserName.Name = "LblUserName";
      this.LblUserName.Size = new System.Drawing.Size(142, 23);
      this.LblUserName.TabIndex = 2;
      this.LblUserName.Text = "Nome de usuário";
      // 
      // TxtBoxPassword
      // 
      this.TxtBoxPassword.Location = new System.Drawing.Point(65, 223);
      this.TxtBoxPassword.Name = "TxtBoxPassword";
      this.TxtBoxPassword.Size = new System.Drawing.Size(208, 30);
      this.TxtBoxPassword.TabIndex = 1;
      // 
      // LblPassword
      // 
      this.LblPassword.AutoSize = true;
      this.LblPassword.Location = new System.Drawing.Point(65, 188);
      this.LblPassword.Name = "LblPassword";
      this.LblPassword.Size = new System.Drawing.Size(57, 23);
      this.LblPassword.TabIndex = 2;
      this.LblPassword.Text = "Senha";
      // 
      // GrpBoxLogin
      // 
      this.GrpBoxLogin.Controls.Add(this.LblUserName);
      this.GrpBoxLogin.Controls.Add(this.TxtBoxUserName);
      this.GrpBoxLogin.Controls.Add(this.BtnLogin);
      this.GrpBoxLogin.Location = new System.Drawing.Point(24, 34);
      this.GrpBoxLogin.Name = "GrpBoxLogin";
      this.GrpBoxLogin.Size = new System.Drawing.Size(304, 327);
      this.GrpBoxLogin.TabIndex = 3;
      this.GrpBoxLogin.TabStop = false;
      this.GrpBoxLogin.Text = "Login";
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 397);
      this.Controls.Add(this.LblPassword);
      this.Controls.Add(this.TxtBoxPassword);
      this.Controls.Add(this.GrpBoxLogin);
      this.Name = "Login";
      this.Text = "Lo0oP_SyS LoginPage";
      this.GrpBoxLogin.ResumeLayout(false);
      this.GrpBoxLogin.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnLogin;
    private System.Windows.Forms.TextBox TxtBoxUserName;
    private System.Windows.Forms.Label LblUserName;
    private System.Windows.Forms.TextBox TxtBoxPassword;
    private System.Windows.Forms.Label LblPassword;
    private System.Windows.Forms.GroupBox GrpBoxLogin;
  }
}