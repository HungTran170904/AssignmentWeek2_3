namespace roomchat
{
    partial class gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtsend = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.listviewonline = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(29, 572);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(690, 91);
            this.txtsend.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(853, 572);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(127, 91);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(29, 88);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(690, 440);
            this.txtChat.TabIndex = 3;
            this.txtChat.Text = "";
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // listviewonline
            // 
            this.listviewonline.HideSelection = false;
            this.listviewonline.Location = new System.Drawing.Point(769, 88);
            this.listviewonline.Name = "listviewonline";
            this.listviewonline.Size = new System.Drawing.Size(264, 440);
            this.listviewonline.TabIndex = 4;
            this.listviewonline.UseCompatibleStateImageBehavior = false;
            this.listviewonline.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1068, 705);
            this.Controls.Add(this.listviewonline);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtsend);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "gui";
            this.Text = "gui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gui_FormClosing);
            this.Click += new System.EventHandler(this.HandleServerMessage);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.ListView listviewonline;
    }
}