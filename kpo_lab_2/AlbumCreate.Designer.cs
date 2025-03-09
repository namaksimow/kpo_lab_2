using System.ComponentModel;

namespace kpo_lab_2;

partial class AlbumCreate
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
        lblAlbumCreateAlbumTitle = new System.Windows.Forms.Label();
        txtBoxAlbumCreateAlbumTitle = new System.Windows.Forms.TextBox();
        btnAlbumCreateAdd = new System.Windows.Forms.Button();
        btnAlbumCreateCancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblAlbumCreateAlbumTitle
        // 
        lblAlbumCreateAlbumTitle.Location = new System.Drawing.Point(12, 10);
        lblAlbumCreateAlbumTitle.Name = "lblAlbumCreateAlbumTitle";
        lblAlbumCreateAlbumTitle.Size = new System.Drawing.Size(70, 20);
        lblAlbumCreateAlbumTitle.TabIndex = 0;
        lblAlbumCreateAlbumTitle.Text = "Album Title";
        // 
        // txtBoxAlbumCreateAlbumTitle
        // 
        txtBoxAlbumCreateAlbumTitle.Location = new System.Drawing.Point(142, 7);
        txtBoxAlbumCreateAlbumTitle.Name = "txtBoxAlbumCreateAlbumTitle";
        txtBoxAlbumCreateAlbumTitle.Size = new System.Drawing.Size(197, 23);
        txtBoxAlbumCreateAlbumTitle.TabIndex = 2;
        // 
        // btnAlbumCreateAdd
        // 
        btnAlbumCreateAdd.Location = new System.Drawing.Point(249, 36);
        btnAlbumCreateAdd.Name = "btnAlbumCreateAdd";
        btnAlbumCreateAdd.Size = new System.Drawing.Size(90, 26);
        btnAlbumCreateAdd.TabIndex = 4;
        btnAlbumCreateAdd.Text = "Add";
        btnAlbumCreateAdd.UseVisualStyleBackColor = true;
        btnAlbumCreateAdd.Click += btnAlbumCreateAdd_Click;
        // 
        // btnAlbumCreateCancel
        // 
        btnAlbumCreateCancel.Location = new System.Drawing.Point(142, 36);
        btnAlbumCreateCancel.Name = "btnAlbumCreateCancel";
        btnAlbumCreateCancel.Size = new System.Drawing.Size(90, 26);
        btnAlbumCreateCancel.TabIndex = 5;
        btnAlbumCreateCancel.Text = "Cancel";
        btnAlbumCreateCancel.UseVisualStyleBackColor = true;
        btnAlbumCreateCancel.Click += btnAlbumCreateCancel_Click;
        // 
        // AlbumCreate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(343, 69);
        Controls.Add(btnAlbumCreateCancel);
        Controls.Add(btnAlbumCreateAdd);
        Controls.Add(txtBoxAlbumCreateAlbumTitle);
        Controls.Add(lblAlbumCreateAlbumTitle);
        Text = "AlbumCreate";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnAlbumCreateAdd;
    private System.Windows.Forms.Button btnAlbumCreateCancel;

    private System.Windows.Forms.TextBox txtBoxAlbumCreateAlbumTitle;

    private System.Windows.Forms.Label lblAlbumCreateAlbumTitle;

    #endregion
}