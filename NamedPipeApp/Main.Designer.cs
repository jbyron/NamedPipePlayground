namespace SixthImpulse.NamedPipeApp {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandomName = new System.Windows.Forms.Button();
            this.cboPipeName = new System.Windows.Forms.ComboBox();
            this.txtPipeAddr = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPipeServerStatus = new System.Windows.Forms.ComboBox();
            this.txtCurStatus = new System.Windows.Forms.TextBox();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpServer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpClient);
            this.splitContainer1.Size = new System.Drawing.Size(780, 390);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.groupBox3);
            this.grpServer.Controls.Add(this.txtPipeAddr);
            this.grpServer.Controls.Add(this.groupBox2);
            this.grpServer.Controls.Add(this.groupBox1);
            this.grpServer.Controls.Add(this.label1);
            this.grpServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServer.Location = new System.Drawing.Point(0, 0);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(780, 206);
            this.grpServer.TabIndex = 0;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server";
            // 
            // grpClient
            // 
            this.grpClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClient.Location = new System.Drawing.Point(0, 0);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(780, 180);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Named Pipe Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboServerName);
            this.groupBox1.Location = new System.Drawing.Point(121, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // cboServerName
            // 
            this.cboServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(7, 20);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(187, 21);
            this.cboServerName.TabIndex = 0;
            this.cboServerName.SelectedIndexChanged += new System.EventHandler(this.cboServerName_SelectedIndexChanged);
            this.cboServerName.TextUpdate += new System.EventHandler(this.cboServerName_TextUpdate);
            this.cboServerName.Leave += new System.EventHandler(this.cboServerName_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboPipeName);
            this.groupBox2.Controls.Add(this.btnRandomName);
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Named Pipe Name";
            // 
            // btnRandomName
            // 
            this.btnRandomName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRandomName.Location = new System.Drawing.Point(419, 21);
            this.btnRandomName.Name = "btnRandomName";
            this.btnRandomName.Size = new System.Drawing.Size(16, 17);
            this.btnRandomName.TabIndex = 1;
            this.btnRandomName.Text = "...";
            this.btnRandomName.UseVisualStyleBackColor = true;
            this.btnRandomName.Click += new System.EventHandler(this.btnRandomName_Click);
            // 
            // cboPipeName
            // 
            this.cboPipeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPipeName.FormattingEnabled = true;
            this.cboPipeName.Location = new System.Drawing.Point(6, 19);
            this.cboPipeName.Name = "cboPipeName";
            this.cboPipeName.Size = new System.Drawing.Size(407, 21);
            this.cboPipeName.TabIndex = 2;
            this.cboPipeName.SelectedIndexChanged += new System.EventHandler(this.cboPipeName_SelectedIndexChanged);
            this.cboPipeName.TextUpdate += new System.EventHandler(this.cboPipeName_TextUpdate);
            this.cboPipeName.Leave += new System.EventHandler(this.cboPipeName_Leave);
            // 
            // txtPipeAddr
            // 
            this.txtPipeAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPipeAddr.Location = new System.Drawing.Point(121, 68);
            this.txtPipeAddr.Name = "txtPipeAddr";
            this.txtPipeAddr.ReadOnly = true;
            this.txtPipeAddr.Size = new System.Drawing.Size(647, 20);
            this.txtPipeAddr.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSetStatus);
            this.groupBox3.Controls.Add(this.txtCurStatus);
            this.groupBox3.Controls.Add(this.cboPipeServerStatus);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(121, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Status";
            // 
            // cboPipeServerStatus
            // 
            this.cboPipeServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPipeServerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPipeServerStatus.FormattingEnabled = true;
            this.cboPipeServerStatus.Location = new System.Drawing.Point(7, 36);
            this.cboPipeServerStatus.Name = "cboPipeServerStatus";
            this.cboPipeServerStatus.Size = new System.Drawing.Size(187, 21);
            this.cboPipeServerStatus.TabIndex = 1;
            // 
            // txtCurStatus
            // 
            this.txtCurStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurStatus.Location = new System.Drawing.Point(320, 36);
            this.txtCurStatus.Name = "txtCurStatus";
            this.txtCurStatus.ReadOnly = true;
            this.txtCurStatus.Size = new System.Drawing.Size(321, 20);
            this.txtCurStatus.TabIndex = 2;
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.Location = new System.Drawing.Point(212, 36);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.Size = new System.Drawing.Size(91, 21);
            this.btnSetStatus.TabIndex = 3;
            this.btnSetStatus.Text = "Set Status ->";
            this.btnSetStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Status";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Named Pipe Playground";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandomName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPipeName;
        private System.Windows.Forms.TextBox txtPipeAddr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.TextBox txtCurStatus;
        private System.Windows.Forms.ComboBox cboPipeServerStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

