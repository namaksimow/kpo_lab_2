namespace kpo_lab_2;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        btnLoad = new System.Windows.Forms.Button();
        tvData = new System.Windows.Forms.TreeView();
        SuspendLayout();
        // 
        // btnLoad
        // 
        btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnLoad.Location = new System.Drawing.Point(480, 626);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new System.Drawing.Size(182, 59);
        btnLoad.TabIndex = 0;
        btnLoad.Text = "Load";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        // 
        // tvData
        // 
        tvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tvData.Location = new System.Drawing.Point(14, 10);
        tvData.Name = "tvData";
        tvData.Size = new System.Drawing.Size(647, 600);
        tvData.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(685, 703);
        Controls.Add(tvData);
        Controls.Add(btnLoad);
        Text = "MusicBase";
        ResumeLayout(false);
    }

    private System.Windows.Forms.TreeView tvData;

    private System.Windows.Forms.Button btnLoad;

    #endregion
}