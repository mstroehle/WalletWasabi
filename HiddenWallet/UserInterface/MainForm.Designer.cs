﻿namespace HiddenWallet.UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.labelBalance = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageReceive = new System.Windows.Forms.TabPage();
            this.buttonGenerateNewAddress = new System.Windows.Forms.Button();
            this.textBoxRecieveAddress = new System.Windows.Forms.TextBox();
            this.tabPageSend = new System.Windows.Forms.TabPage();
            this.labelUsd = new System.Windows.Forms.Label();
            this.labelBtc = new System.Windows.Forms.Label();
            this.textBoxUsd = new System.Windows.Forms.TextBox();
            this.buttonMax = new System.Windows.Forms.Button();
            this.textBoxBtc = new System.Windows.Forms.TextBox();
            this.textBoxSendAddress = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageReceive.SuspendLayout();
            this.tabPageSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.labelBalance);
            this.splitContainerMain.Panel1.Controls.Add(this.menuStripMain);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Size = new System.Drawing.Size(417, 223);
            this.splitContainerMain.SplitterDistance = 77;
            this.splitContainerMain.TabIndex = 0;
            // 
            // labelBalance
            // 
            this.labelBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.labelBalance.Location = new System.Drawing.Point(0, 24);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(417, 53);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "567.1234 BTC";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(417, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // addressesToolStripMenuItem
            // 
            this.addressesToolStripMenuItem.Name = "addressesToolStripMenuItem";
            this.addressesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addressesToolStripMenuItem.Text = "Addresses";
            this.addressesToolStripMenuItem.Click += new System.EventHandler(this.addressesToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageReceive);
            this.tabControlMain.Controls.Add(this.tabPageSend);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(417, 142);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageReceive
            // 
            this.tabPageReceive.Controls.Add(this.buttonGenerateNewAddress);
            this.tabPageReceive.Controls.Add(this.textBoxRecieveAddress);
            this.tabPageReceive.Location = new System.Drawing.Point(4, 22);
            this.tabPageReceive.Name = "tabPageReceive";
            this.tabPageReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReceive.Size = new System.Drawing.Size(409, 116);
            this.tabPageReceive.TabIndex = 0;
            this.tabPageReceive.Text = "Receive";
            this.tabPageReceive.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateNewAddress
            // 
            this.buttonGenerateNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateNewAddress.Location = new System.Drawing.Point(8, 60);
            this.buttonGenerateNewAddress.Name = "buttonGenerateNewAddress";
            this.buttonGenerateNewAddress.Size = new System.Drawing.Size(390, 50);
            this.buttonGenerateNewAddress.TabIndex = 1;
            this.buttonGenerateNewAddress.Text = "GENERATE NEW ADDRESS";
            this.buttonGenerateNewAddress.UseVisualStyleBackColor = true;
            // 
            // textBoxRecieveAddress
            // 
            this.textBoxRecieveAddress.Location = new System.Drawing.Point(9, 6);
            this.textBoxRecieveAddress.Name = "textBoxRecieveAddress";
            this.textBoxRecieveAddress.ReadOnly = true;
            this.textBoxRecieveAddress.Size = new System.Drawing.Size(390, 20);
            this.textBoxRecieveAddress.TabIndex = 0;
            this.textBoxRecieveAddress.Text = "1WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";
            this.textBoxRecieveAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageSend
            // 
            this.tabPageSend.Controls.Add(this.labelUsd);
            this.tabPageSend.Controls.Add(this.labelBtc);
            this.tabPageSend.Controls.Add(this.textBoxUsd);
            this.tabPageSend.Controls.Add(this.buttonMax);
            this.tabPageSend.Controls.Add(this.textBoxBtc);
            this.tabPageSend.Controls.Add(this.textBoxSendAddress);
            this.tabPageSend.Controls.Add(this.buttonSend);
            this.tabPageSend.Location = new System.Drawing.Point(4, 22);
            this.tabPageSend.Name = "tabPageSend";
            this.tabPageSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSend.Size = new System.Drawing.Size(409, 116);
            this.tabPageSend.TabIndex = 1;
            this.tabPageSend.Text = "Send";
            this.tabPageSend.UseVisualStyleBackColor = true;
            // 
            // labelUsd
            // 
            this.labelUsd.AutoSize = true;
            this.labelUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsd.Location = new System.Drawing.Point(293, 32);
            this.labelUsd.Name = "labelUsd";
            this.labelUsd.Size = new System.Drawing.Size(44, 20);
            this.labelUsd.TabIndex = 11;
            this.labelUsd.Text = "USD";
            // 
            // labelBtc
            // 
            this.labelBtc.AutoSize = true;
            this.labelBtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBtc.Location = new System.Drawing.Point(144, 32);
            this.labelBtc.Name = "labelBtc";
            this.labelBtc.Size = new System.Drawing.Size(53, 20);
            this.labelBtc.TabIndex = 10;
            this.labelBtc.Text = "BTC =";
            // 
            // textBoxUsd
            // 
            this.textBoxUsd.Location = new System.Drawing.Point(208, 32);
            this.textBoxUsd.Name = "textBoxUsd";
            this.textBoxUsd.Size = new System.Drawing.Size(85, 20);
            this.textBoxUsd.TabIndex = 9;
            this.textBoxUsd.Text = "200";
            this.textBoxUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(9, 32);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(44, 23);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "MAX";
            this.buttonMax.UseVisualStyleBackColor = true;
            // 
            // textBoxBtc
            // 
            this.textBoxBtc.Location = new System.Drawing.Point(59, 32);
            this.textBoxBtc.Name = "textBoxBtc";
            this.textBoxBtc.Size = new System.Drawing.Size(85, 20);
            this.textBoxBtc.TabIndex = 5;
            this.textBoxBtc.Text = "1.2345";
            this.textBoxBtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSendAddress
            // 
            this.textBoxSendAddress.Location = new System.Drawing.Point(9, 6);
            this.textBoxSendAddress.Name = "textBoxSendAddress";
            this.textBoxSendAddress.Size = new System.Drawing.Size(390, 20);
            this.textBoxSendAddress.TabIndex = 4;
            this.textBoxSendAddress.Text = "1WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";
            this.textBoxSendAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSend.Location = new System.Drawing.Point(8, 60);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(390, 50);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarMain.Location = new System.Drawing.Point(0, 225);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(413, 55);
            this.progressBarMain.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(413, 280);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.progressBarMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hidden Wallet";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageReceive.ResumeLayout(false);
            this.tabPageReceive.PerformLayout();
            this.tabPageSend.ResumeLayout(false);
            this.tabPageSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageReceive;
        private System.Windows.Forms.TabPage tabPageSend;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonGenerateNewAddress;
        private System.Windows.Forms.TextBox textBoxRecieveAddress;
        private System.Windows.Forms.TextBox textBoxSendAddress;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.TextBox textBoxUsd;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.TextBox textBoxBtc;
        private System.Windows.Forms.Label labelBtc;
        private System.Windows.Forms.Label labelUsd;
    }
}

