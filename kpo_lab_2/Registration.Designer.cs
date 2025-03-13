using System.ComponentModel;

namespace kpo_lab_2;

partial class Registration
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
        lblRegistrationUsername = new System.Windows.Forms.Label();
        lblRegistrationPassword = new System.Windows.Forms.Label();
        txtBoxRegistrationUsername = new System.Windows.Forms.TextBox();
        txtBoxRegistrationPassword = new System.Windows.Forms.TextBox();
        btbRegistrationRegistration = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblRegistrationUsername
        // 
        lblRegistrationUsername.Location = new System.Drawing.Point(9, 13);
        lblRegistrationUsername.Name = "lblRegistrationUsername";
        lblRegistrationUsername.Size = new System.Drawing.Size(65, 19);
        lblRegistrationUsername.TabIndex = 0;
        lblRegistrationUsername.Text = "Username";
        // 
        // lblRegistrationPassword
        // 
        lblRegistrationPassword.Location = new System.Drawing.Point(9, 49);
        lblRegistrationPassword.Name = "lblRegistrationPassword";
        lblRegistrationPassword.Size = new System.Drawing.Size(65, 19);
        lblRegistrationPassword.TabIndex = 1;
        lblRegistrationPassword.Text = "Password";
        // 
        // txtBoxRegistrationUsername
        // 
        txtBoxRegistrationUsername.Location = new System.Drawing.Point(108, 10);
        txtBoxRegistrationUsername.Name = "txtBoxRegistrationUsername";
        txtBoxRegistrationUsername.Size = new System.Drawing.Size(186, 23);
        txtBoxRegistrationUsername.TabIndex = 2;
        // 
        // txtBoxRegistrationPassword
        // 
        txtBoxRegistrationPassword.Location = new System.Drawing.Point(108, 45);
        txtBoxRegistrationPassword.Name = "txtBoxRegistrationPassword";
        txtBoxRegistrationPassword.Size = new System.Drawing.Size(186, 23);
        txtBoxRegistrationPassword.TabIndex = 3;
        // 
        // btbRegistrationRegistration
        // 
        btbRegistrationRegistration.Location = new System.Drawing.Point(90, 74);
        btbRegistrationRegistration.Name = "btbRegistrationRegistration";
        btbRegistrationRegistration.Size = new System.Drawing.Size(114, 29);
        btbRegistrationRegistration.TabIndex = 4;
        btbRegistrationRegistration.Text = "Registration";
        btbRegistrationRegistration.UseVisualStyleBackColor = true;
        btbRegistrationRegistration.Click += btbRegistrationRegistration_Click;
        // 
        // Registration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(307, 113);
        Controls.Add(btbRegistrationRegistration);
        Controls.Add(txtBoxRegistrationPassword);
        Controls.Add(txtBoxRegistrationUsername);
        Controls.Add(lblRegistrationPassword);
        Controls.Add(lblRegistrationUsername);
        Text = "Registration";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btbRegistrationRegistration;

    private System.Windows.Forms.TextBox txtBoxRegistrationUsername;
    private System.Windows.Forms.TextBox txtBoxRegistrationPassword;

    private System.Windows.Forms.Label lblRegistrationUsername;
    private System.Windows.Forms.Label lblRegistrationPassword;

    #endregion
}