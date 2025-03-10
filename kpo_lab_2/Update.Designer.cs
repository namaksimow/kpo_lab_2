using System.ComponentModel;

namespace kpo_lab_2;

partial class Update
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
        lblNewData = new System.Windows.Forms.Label();
        txtBoxNewData = new System.Windows.Forms.TextBox();
        btnPerformerNewDataUpdate = new System.Windows.Forms.Button();
        btnPerformerNewDataCancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblNewData
        // 
        lblNewData.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
        lblNewData.Location = new System.Drawing.Point(12, 9);
        lblNewData.Name = "lblNewData";
        lblNewData.Size = new System.Drawing.Size(94, 21);
        lblNewData.TabIndex = 2;
        lblNewData.Text = "New Data";
        // 
        // txtBoxPerformerNewNickname
        // 
        txtBoxNewData.Location = new System.Drawing.Point(104, 9);
        txtBoxNewData.Name = "txtBoxNewData";
        txtBoxNewData.Size = new System.Drawing.Size(217, 23);
        txtBoxNewData.TabIndex = 5;
        // 
        // btnPerformerNewDataUpdate
        // 
        btnPerformerNewDataUpdate.Location = new System.Drawing.Point(237, 38);
        btnPerformerNewDataUpdate.Name = "btnPerformerNewDataUpdate";
        btnPerformerNewDataUpdate.Size = new System.Drawing.Size(84, 28);
        btnPerformerNewDataUpdate.TabIndex = 6;
        btnPerformerNewDataUpdate.Text = "Update";
        btnPerformerNewDataUpdate.UseVisualStyleBackColor = true;
        btnPerformerNewDataUpdate.Click += btnNewDataUpdate_Click;
        // 
        // btnPerformerNewDataCancel
        // 
        btnPerformerNewDataCancel.Location = new System.Drawing.Point(104, 38);
        btnPerformerNewDataCancel.Name = "btnPerformerNewDataCancel";
        btnPerformerNewDataCancel.Size = new System.Drawing.Size(84, 28);
        btnPerformerNewDataCancel.TabIndex = 8;
        btnPerformerNewDataCancel.Text = "Cancel";
        btnPerformerNewDataCancel.UseVisualStyleBackColor = true;
        btnPerformerNewDataCancel.Click += btnNewDataCancel_Click;
        // 
        // Update
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(333, 79);
        Controls.Add(btnPerformerNewDataCancel);
        Controls.Add(btnPerformerNewDataUpdate);
        Controls.Add(txtBoxNewData);
        Controls.Add(lblNewData);
        Text = "DataUpdate";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtBoxNewData;
    private System.Windows.Forms.Button btnPerformerNewDataUpdate;
    private System.Windows.Forms.Button btnPerformerNewDataCancel;

    private System.Windows.Forms.Label lblNewData;

    #endregion
}