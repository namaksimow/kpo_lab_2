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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        btnLoad = new System.Windows.Forms.Button();
        tvData = new System.Windows.Forms.TreeView();
        performerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
        performerToolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
        performerToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
        performerToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
        imgListIcon = new System.Windows.Forms.ImageList(components);
        performerContextMenuStrip.SuspendLayout();
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
        btnLoad.Click += btnLoad_LoadData;
        // 
        // tvData
        // 
        tvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tvData.ContextMenuStrip = performerContextMenuStrip;
        tvData.ImageIndex = 0;
        tvData.ImageList = imgListIcon;
        tvData.Location = new System.Drawing.Point(14, 10);
        tvData.Name = "tvData";
        tvData.SelectedImageIndex = 0;
        tvData.Size = new System.Drawing.Size(647, 600);
        tvData.TabIndex = 1;
        // 
        // performerContextMenuStrip
        // 
        performerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] 
            { performerToolStripMenuItemCreate,  performerToolStripMenuItemUpdate, performerToolStripMenuItemDelete });
        performerContextMenuStrip.Name = "performerContextMenuStrip";
        performerContextMenuStrip.Size = new System.Drawing.Size(181, 48);
        // 
        // performerToolStripMenuItemCreate
        // 
        performerToolStripMenuItemCreate.Name = "performerToolStripMenuItemCreate";
        performerToolStripMenuItemCreate.Size = new System.Drawing.Size(180, 22);
        performerToolStripMenuItemCreate.Text = "Add performer";
        performerToolStripMenuItemCreate.Click += PerformerContextMenuItemCreate;
        //
        // performerToolStripMenuItemUpdate
        //
        performerToolStripMenuItemUpdate.Name = "performerToolStripMenuItemUpdate";
        performerToolStripMenuItemUpdate.Size = new System.Drawing.Size(180, 22);
        performerToolStripMenuItemUpdate.Text = "Update performer";
        performerToolStripMenuItemUpdate.Click += PerformerContextMenuItemUpdate;
        //
        // performerToolStripMenuItemDelete
        //
        performerToolStripMenuItemDelete.Name = "performerToolStripMenuItemDelete";
        performerToolStripMenuItemDelete.Size = new System.Drawing.Size(180, 22);
        performerToolStripMenuItemDelete.Text = "Delete performer";
        performerToolStripMenuItemDelete.Click += PerformerContextMenuItemDelete;
        // 
        // imgListIcon
        // 
        imgListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)resources.GetObject("imgListIcon.ImageStream"));
        imgListIcon.TransparentColor = System.Drawing.Color.Transparent;
        imgListIcon.Images.SetKeyName(0, "human.png");
        imgListIcon.Images.SetKeyName(1, "album.png");
        imgListIcon.Images.SetKeyName(2, "song.png");
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(685, 703);
        Controls.Add(tvData);
        Controls.Add(btnLoad);
        Text = "MusicBase";
        performerContextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }
    
    private System.Windows.Forms.ToolStripMenuItem performerToolStripMenuItemDelete;
    
    private System.Windows.Forms.ToolStripMenuItem performerToolStripMenuItemUpdate;
    
    private System.Windows.Forms.ToolStripMenuItem performerToolStripMenuItemCreate;

    public static System.Windows.Forms.ContextMenuStrip performerContextMenuStrip;

    private System.Windows.Forms.ImageList imgListIcon;

    public static System.Windows.Forms.TreeView tvData;

    private System.Windows.Forms.Button btnLoad;

    #endregion
}