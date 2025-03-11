using System.ComponentModel;

namespace kpo_lab_2;

partial class SongCreate
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
        lblSongCreateTitle = new System.Windows.Forms.Label();
        txtBoxSongCreateTitle = new System.Windows.Forms.TextBox();
        lblSongCreateLyrics = new System.Windows.Forms.Label();
        txtBoxSongCreateLyrics = new System.Windows.Forms.TextBox();
        btnSongCreateAdd = new System.Windows.Forms.Button();
        btnSongCreateCancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblSongCreateTitle
        // 
        lblSongCreateTitle.Location = new System.Drawing.Point(12, 15);
        lblSongCreateTitle.Name = "lblSongCreateTitle";
        lblSongCreateTitle.Size = new System.Drawing.Size(35, 17);
        lblSongCreateTitle.TabIndex = 0;
        lblSongCreateTitle.Text = "Title";
        // 
        // txtBoxSongCreateTitle
        // 
        txtBoxSongCreateTitle.Location = new System.Drawing.Point(105, 12);
        txtBoxSongCreateTitle.Name = "txtBoxSongCreateTitle";
        txtBoxSongCreateTitle.Size = new System.Drawing.Size(177, 23);
        txtBoxSongCreateTitle.TabIndex = 1;
        // 
        // lblSongCreateLyrics
        // 
        lblSongCreateLyrics.Location = new System.Drawing.Point(12, 44);
        lblSongCreateLyrics.Name = "lblSongCreateLyrics";
        lblSongCreateLyrics.Size = new System.Drawing.Size(35, 17);
        lblSongCreateLyrics.TabIndex = 2;
        lblSongCreateLyrics.Text = "Lyrics";
        // 
        // txtBoxSongCreateLyrics
        // 
        txtBoxSongCreateLyrics.Location = new System.Drawing.Point(105, 41);
        txtBoxSongCreateLyrics.Name = "txtBoxSongCreateLyrics";
        txtBoxSongCreateLyrics.Size = new System.Drawing.Size(177, 23);
        txtBoxSongCreateLyrics.TabIndex = 3;
        // 
        // btnSongCreateAdd
        // 
        btnSongCreateAdd.Location = new System.Drawing.Point(225, 70);
        btnSongCreateAdd.Name = "btnSongCreateAdd";
        btnSongCreateAdd.Size = new System.Drawing.Size(57, 29);
        btnSongCreateAdd.TabIndex = 4;
        btnSongCreateAdd.Text = "Add";
        btnSongCreateAdd.UseVisualStyleBackColor = true;
        btnSongCreateAdd.Click += btnSongCreateAdd_Click;
        // 
        // btnSongCreateCancel
        // 
        btnSongCreateCancel.Location = new System.Drawing.Point(105, 70);
        btnSongCreateCancel.Name = "btnSongCreateCancel";
        btnSongCreateCancel.Size = new System.Drawing.Size(57, 29);
        btnSongCreateCancel.TabIndex = 5;
        btnSongCreateCancel.Text = "Cancel";
        btnSongCreateCancel.UseVisualStyleBackColor = true;
        btnSongCreateCancel.Click += btnSongCreateCancel_Click;
        // 
        // SongCreate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(290, 108);
        Controls.Add(btnSongCreateCancel);
        Controls.Add(btnSongCreateAdd);
        Controls.Add(txtBoxSongCreateLyrics);
        Controls.Add(lblSongCreateLyrics);
        Controls.Add(txtBoxSongCreateTitle);
        Controls.Add(lblSongCreateTitle);
        Text = "SongCreate";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnSongCreateAdd;
    private System.Windows.Forms.Button btnSongCreateCancel;

    private System.Windows.Forms.TextBox txtBoxSongCreateTitle;
    private System.Windows.Forms.Label lblSongCreateLyrics;
    private System.Windows.Forms.TextBox txtBoxSongCreateLyrics;

    private System.Windows.Forms.Label lblSongCreateTitle;

    #endregion
}