namespace roomchat
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtroomcode = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnjoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter chat room";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(226, 89);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(281, 41);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "RoomCode";
            // 
            // txtroomcode
            // 
            this.txtroomcode.Location = new System.Drawing.Point(226, 185);
            this.txtroomcode.Multiline = true;
            this.txtroomcode.Name = "txtroomcode";
            this.txtroomcode.Size = new System.Drawing.Size(281, 41);
            this.txtroomcode.TabIndex = 4;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(282, 284);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(156, 86);
            this.btncreate.TabIndex = 5;
            this.btncreate.Text = "Create Room";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnjoin
            // 
            this.btnjoin.Location = new System.Drawing.Point(569, 115);
            this.btnjoin.Name = "btnjoin";
            this.btnjoin.Size = new System.Drawing.Size(151, 65);
            this.btnjoin.TabIndex = 6;
            this.btnjoin.Text = "Join Room";
            this.btnjoin.UseVisualStyleBackColor = true;
            this.btnjoin.Click += new System.EventHandler(this.btnjoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(779, 467);
            this.Controls.Add(this.btnjoin);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtroomcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtroomcode;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnjoin;
    }
}

