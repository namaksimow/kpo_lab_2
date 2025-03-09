using System.ComponentModel;

namespace kpo_lab_2;

partial class PerformerCreate
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
        lblName = new System.Windows.Forms.Label();
        lblSurname = new System.Windows.Forms.Label();
        lblNickname = new System.Windows.Forms.Label();
        txtBoxName = new System.Windows.Forms.TextBox();
        txtBoxSurname = new System.Windows.Forms.TextBox();
        txtBoxNickname = new System.Windows.Forms.TextBox();
        btnAddPerformer = new System.Windows.Forms.Button();
        btnCancelPerformer = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.Location = new System.Drawing.Point(22, 18);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(40, 18);
        lblName.TabIndex = 0;
        lblName.Text = "Name";
        // 
        // lblSurname
        // 
        lblSurname.Location = new System.Drawing.Point(22, 50);
        lblSurname.Name = "lblSurname";
        lblSurname.Size = new System.Drawing.Size(59, 18);
        lblSurname.TabIndex = 1;
        lblSurname.Text = "Surname";
        // 
        // lblNickname
        // 
        lblNickname.Location = new System.Drawing.Point(22, 85);
        lblNickname.Name = "lblNickname";
        lblNickname.Size = new System.Drawing.Size(67, 18);
        lblNickname.TabIndex = 2;
        lblNickname.Text = "Nickname";
        // 
        // txtBoxName
        // 
        txtBoxName.Location = new System.Drawing.Point(118, 11);
        txtBoxName.Name = "txtBoxName";
        txtBoxName.Size = new System.Drawing.Size(274, 23);
        txtBoxName.TabIndex = 3;
        // 
        // txtBoxSurname
        // 
        txtBoxSurname.Location = new System.Drawing.Point(118, 45);
        txtBoxSurname.Name = "txtBoxSurname";
        txtBoxSurname.Size = new System.Drawing.Size(274, 23);
        txtBoxSurname.TabIndex = 4;
        // 
        // txtBoxNickname
        // 
        txtBoxNickname.Location = new System.Drawing.Point(118, 80);
        txtBoxNickname.Name = "txtBoxNickname";
        txtBoxNickname.Size = new System.Drawing.Size(274, 23);
        txtBoxNickname.TabIndex = 5;
        // 
        // btnAddPerformer
        // 
        btnAddPerformer.Location = new System.Drawing.Point(290, 116);
        btnAddPerformer.Name = "btnAddPerformer";
        btnAddPerformer.Size = new System.Drawing.Size(101, 28);
        btnAddPerformer.TabIndex = 6;
        btnAddPerformer.Text = "Add";
        btnAddPerformer.UseVisualStyleBackColor = true;
        btnAddPerformer.Click += btnAddPerformer_Click;
        // 
        // btnCancelPerformer
        // 
        btnCancelPerformer.Location = new System.Drawing.Point(118, 116);
        btnCancelPerformer.Name = "btnCancelPerformer";
        btnCancelPerformer.Size = new System.Drawing.Size(101, 28);
        btnCancelPerformer.TabIndex = 8;
        btnCancelPerformer.Text = "Cancel";
        btnCancelPerformer.UseVisualStyleBackColor = true;
        btnCancelPerformer.Click += btnCancelPerformer_Click;
        // 
        // PerformerCreate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(399, 154);
        Controls.Add(btnCancelPerformer);
        Controls.Add(btnAddPerformer);
        Controls.Add(txtBoxNickname);
        Controls.Add(txtBoxSurname);
        Controls.Add(txtBoxName);
        Controls.Add(lblNickname);
        Controls.Add(lblSurname);
        Controls.Add(lblName);
        Text = "PerformerCUD";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtBoxName;
    private System.Windows.Forms.TextBox txtBoxSurname;
    private System.Windows.Forms.TextBox txtBoxNickname;
    private System.Windows.Forms.Button btnAddPerformer;
    private System.Windows.Forms.Button btnCancelPerformer;

    private System.Windows.Forms.Label lblSurname;
    private System.Windows.Forms.Label lblNickname;

    private System.Windows.Forms.Label lblName;

    #endregion
}