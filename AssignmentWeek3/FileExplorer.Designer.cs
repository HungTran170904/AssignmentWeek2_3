namespace SimpleFileExplorer
{
    partial class FileExplorerForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerForm));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Item 1" }, 0, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Bold));
            ListViewItem listViewItem2 = new ListViewItem("Item 2", 1);
            tableLayoutPanel = new TableLayoutPanel();
            treeView = new TreeView();
            SmallIcons = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            pathLabel = new Label();
            pathTextbox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            undoButton = new Button();
            redoButton = new Button();
            listView = new ListView();
            LargeIcons = new ImageList(components);
            contextMenuStrip = new ContextMenuStrip(components);
            copyMenuItem = new ToolStripMenuItem();
            pasteMenuItem = new ToolStripMenuItem();
            deleteMenuItem = new ToolStripMenuItem();
            tableLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel.Controls.Add(treeView, 0, 1);
            tableLayoutPanel.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel.Controls.Add(listView, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(1120, 578);
            tableLayoutPanel.TabIndex = 0;
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Fill;
            treeView.ImageIndex = 0;
            treeView.ImageList = SmallIcons;
            treeView.Location = new Point(3, 48);
            treeView.Name = "treeView";
            treeView.SelectedImageIndex = 0;
            treeView.Size = new Size(218, 532);
            treeView.TabIndex = 0;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            // 
            // SmallIcons
            // 
            SmallIcons.ColorDepth = ColorDepth.Depth32Bit;
            SmallIcons.ImageStream = (ImageListStreamer)resources.GetObject("SmallIcons.ImageStream");
            SmallIcons.TransparentColor = Color.Transparent;
            SmallIcons.Images.SetKeyName(0, "FolderIcon.png");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pathLabel);
            flowLayoutPanel1.Controls.Add(pathTextbox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(227, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(890, 39);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // pathLabel
            // 
            pathLabel.Anchor = AnchorStyles.None;
            pathLabel.AutoSize = true;
            pathLabel.BorderStyle = BorderStyle.Fixed3D;
            pathLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            pathLabel.Location = new Point(3, 7);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(62, 30);
            pathLabel.TabIndex = 2;
            pathLabel.Text = "Path:";
            // 
            // pathTextbox
            // 
            pathTextbox.Anchor = AnchorStyles.None;
            pathTextbox.BorderStyle = BorderStyle.FixedSingle;
            pathTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            pathTextbox.Location = new Point(78, 5);
            pathTextbox.Margin = new Padding(10, 5, 3, 5);
            pathTextbox.Name = "pathTextbox";
            pathTextbox.ReadOnly = true;
            pathTextbox.Size = new Size(768, 34);
            pathTextbox.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(undoButton);
            flowLayoutPanel2.Controls.Add(redoButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(30, 3);
            flowLayoutPanel2.Margin = new Padding(30, 3, 30, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(164, 39);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.Left;
            undoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            undoButton.Location = new Point(3, 3);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(58, 29);
            undoButton.TabIndex = 5;
            undoButton.Text = "<<";
            undoButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            redoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            redoButton.Location = new Point(67, 3);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(58, 29);
            redoButton.TabIndex = 6;
            redoButton.Text = ">>";
            redoButton.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.Dock = DockStyle.Fill;
            listViewItem2.Tag = "Hello";
            listView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView.LargeImageList = LargeIcons;
            listView.Location = new Point(227, 48);
            listView.Name = "listView";
            listView.Size = new Size(890, 532);
            listView.TabIndex = 7;
            listView.UseCompatibleStateImageBehavior = false;
            listView.MouseDoubleClick += listView_MouseDoubleClick;
            listView.MouseDown += listView_MouseDown;
            // 
            // LargeIcons
            // 
            LargeIcons.ColorDepth = ColorDepth.Depth32Bit;
            LargeIcons.ImageStream = (ImageListStreamer)resources.GetObject("LargeIcons.ImageStream");
            LargeIcons.TransparentColor = Color.Transparent;
            LargeIcons.Images.SetKeyName(0, "FolderIcon2.png");
            LargeIcons.Images.SetKeyName(1, "FileIcon.png");
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { copyMenuItem, pasteMenuItem, deleteMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(132, 88);
            // 
            // copyMenuItem
            // 
            copyMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            copyMenuItem.Name = "copyMenuItem";
            copyMenuItem.Size = new Size(131, 28);
            copyMenuItem.Text = "Copy";
            copyMenuItem.Click += copyMenuItem_Click;
            // 
            // pasteMenuItem
            // 
            pasteMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pasteMenuItem.Name = "pasteMenuItem";
            pasteMenuItem.Size = new Size(131, 28);
            pasteMenuItem.Text = "Paste";
            pasteMenuItem.Click += pasteMenuItem_Click;
            // 
            // deleteMenuItem
            // 
            deleteMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deleteMenuItem.Name = "deleteMenuItem";
            deleteMenuItem.Size = new Size(131, 28);
            deleteMenuItem.Text = "Delete";
            deleteMenuItem.Click += deleteMenuItem_Click;
            // 
            // FileExplorerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 578);
            Controls.Add(tableLayoutPanel);
            Name = "FileExplorerForm";
            Text = "File Explorer";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TreeView treeView;
        private TextBox pathTextbox;
        private Label pathLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button undoButton;
        private Button redoButton;
        private ListView listView;
        private ImageList LargeIcons;
        private ImageList SmallIcons;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem pasteMenuItem;
        private ToolStripMenuItem deleteMenuItem;
    }
}
