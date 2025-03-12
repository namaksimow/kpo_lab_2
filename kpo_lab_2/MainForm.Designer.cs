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
        contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
        toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItemAddIn = new System.Windows.Forms.ToolStripMenuItem();
        imgListIcon = new System.Windows.Forms.ImageList(components);
        contextMenuStrip.SuspendLayout();
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
        tvData.AllowDrop = true;
        tvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tvData.ContextMenuStrip = contextMenuStrip;
        tvData.ImageIndex = 0;
        tvData.ImageList = imgListIcon;
        tvData.Location = new System.Drawing.Point(14, 10);
        tvData.Name = "tvData";
        tvData.SelectedImageIndex = 0;
        tvData.Size = new System.Drawing.Size(647, 600);
        tvData.TabIndex = 1;
        tvData.ItemDrag += new ItemDragEventHandler(tvData_ItemDrag);
        tvData.DragEnter += new DragEventHandler(tvData_DragEnter);
        tvData.DragOver += new DragEventHandler(tvData_DragOver);
        tvData.DragDrop += new DragEventHandler(tvData_DragDrop);
        // 
        // contextMenuStrip
        // 
        contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemAdd, toolStripMenuItemUpdate, toolStripMenuItemDelete, toolStripMenuItemAddIn });
        contextMenuStrip.Name = "contextMenuStrip";
        contextMenuStrip.Size = new System.Drawing.Size(113, 92);
        // 
        // toolStripMenuItemAdd
        // 
        toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
        toolStripMenuItemAdd.Size = new System.Drawing.Size(112, 22);
        toolStripMenuItemAdd.Text = "Add";
        toolStripMenuItemAdd.Click += ContextMenuItemAdd;
        // 
        // toolStripMenuItemUpdate
        // 
        toolStripMenuItemUpdate.Name = "toolStripMenuItemUpdate";
        toolStripMenuItemUpdate.Size = new System.Drawing.Size(112, 22);
        toolStripMenuItemUpdate.Text = "Update";
        toolStripMenuItemUpdate.Click += ContextMenuItemUpdate;
        // 
        // toolStripMenuItemDelete
        // 
        toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
        toolStripMenuItemDelete.Size = new System.Drawing.Size(112, 22);
        toolStripMenuItemDelete.Text = "Delete";
        toolStripMenuItemDelete.Click += ContextMenuItemDelete;
        // 
        // toolStripMenuItemAddIn
        // 
        toolStripMenuItemAddIn.Name = "toolStripMenuItemAddIn";
        toolStripMenuItemAddIn.Size = new System.Drawing.Size(112, 22);
        toolStripMenuItemAddIn.Text = "Add In";
        toolStripMenuItemAddIn.Click += ContextMenuItemAddIn;
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
        contextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddIn;
    
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
    
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdate;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;

    public static System.Windows.Forms.ContextMenuStrip contextMenuStrip;

    private System.Windows.Forms.ImageList imgListIcon;

    public static System.Windows.Forms.TreeView tvData;

    private System.Windows.Forms.Button btnLoad;

    #endregion
}