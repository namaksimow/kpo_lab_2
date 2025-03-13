using System.ComponentModel;

namespace kpo_lab_2;

partial class AuthenticationAndRegistration
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lblAuthAndRegLogin = new System.Windows.Forms.Label();
        txtBoxAuthAndRegLogin = new System.Windows.Forms.TextBox();
        txtBoxAuthAndRegPassword = new System.Windows.Forms.TextBox();
        lblAuthAndRegPassword = new System.Windows.Forms.Label();
        btnAuthAndRegLogin = new System.Windows.Forms.Button();
        btnAuthAndRegRegistration = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblAuthAndRegLogin
        // 
        lblAuthAndRegLogin.Location = new System.Drawing.Point(18, 16);
        lblAuthAndRegLogin.Name = "lblAuthAndRegLogin";
        lblAuthAndRegLogin.Size = new System.Drawing.Size(41, 18);
        lblAuthAndRegLogin.TabIndex = 0;
        lblAuthAndRegLogin.Text = "Login";
        // 
        // txtBoxAuthAndRegLogin
        // 
        txtBoxAuthAndRegLogin.Location = new System.Drawing.Point(104, 11);
        txtBoxAuthAndRegLogin.Name = "txtBoxAuthAndRegLogin";
        txtBoxAuthAndRegLogin.Size = new System.Drawing.Size(203, 23);
        txtBoxAuthAndRegLogin.TabIndex = 1;
        // 
        // txtBoxAuthAndRegPassword
        // 
        txtBoxAuthAndRegPassword.Location = new System.Drawing.Point(104, 39);
        txtBoxAuthAndRegPassword.Name = "txtBoxAuthAndRegPassword";
        txtBoxAuthAndRegPassword.Size = new System.Drawing.Size(203, 23);
        txtBoxAuthAndRegPassword.TabIndex = 2;
        // 
        // lblAuthAndRegPassword
        // 
        lblAuthAndRegPassword.Location = new System.Drawing.Point(18, 44);
        lblAuthAndRegPassword.Name = "lblAuthAndRegPassword";
        lblAuthAndRegPassword.Size = new System.Drawing.Size(60, 18);
        lblAuthAndRegPassword.TabIndex = 3;
        lblAuthAndRegPassword.Text = "Password";
        // 
        // btnAuthAndRegLogin
        // 
        btnAuthAndRegLogin.Location = new System.Drawing.Point(82, 84);
        btnAuthAndRegLogin.Name = "btnAuthAndRegLogin";
        btnAuthAndRegLogin.Size = new System.Drawing.Size(153, 24);
        btnAuthAndRegLogin.TabIndex = 4;
        btnAuthAndRegLogin.Text = "Login";
        btnAuthAndRegLogin.UseVisualStyleBackColor = true;
        btnAuthAndRegLogin.Click += btnAuthAndRegLogin_Click;
        // 
        // btnAuthAndRegRegistration
        // 
        btnAuthAndRegRegistration.Location = new System.Drawing.Point(82, 114);
        btnAuthAndRegRegistration.Name = "btnAuthAndRegRegistration";
        btnAuthAndRegRegistration.Size = new System.Drawing.Size(153, 24);
        btnAuthAndRegRegistration.TabIndex = 5;
        btnAuthAndRegRegistration.Text = "Registration";
        btnAuthAndRegRegistration.UseVisualStyleBackColor = true;
        btnAuthAndRegRegistration.Click += btnAuthAndRegRegistration_Click;
        // 
        // AuthenticationAndRegistration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(313, 161);
        Controls.Add(btnAuthAndRegRegistration);
        Controls.Add(btnAuthAndRegLogin);
        Controls.Add(lblAuthAndRegPassword);
        Controls.Add(txtBoxAuthAndRegPassword);
        Controls.Add(txtBoxAuthAndRegLogin);
        Controls.Add(lblAuthAndRegLogin);
        Text = "AuthenticationAndRegistration";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblAuthAndRegLogin;
    private System.Windows.Forms.TextBox txtBoxAuthAndRegLogin;
    private System.Windows.Forms.TextBox txtBoxAuthAndRegPassword;
    private System.Windows.Forms.Label lblAuthAndRegPassword;
    private System.Windows.Forms.Button btnAuthAndRegLogin;
    private System.Windows.Forms.Button btnAuthAndRegRegistration;

    #endregion
}