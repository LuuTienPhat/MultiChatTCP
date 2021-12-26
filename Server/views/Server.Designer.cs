
using System;

namespace Server
{
    partial class Server
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
                Environment.Exit(Environment.ExitCode);
            }
            base.Dispose(disposing);
            Environment.Exit(Environment.ExitCode);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.connectPanel = new DevExpress.XtraEditors.PanelControl();
            this.LbStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnStop = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnStart = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.BtnRestart = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.LbDetail = new DevExpress.XtraBars.BarStaticItem();
            //this.progressBar = new DevExpress.XtraBars.BarEditItem();
            //this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.OnlineList = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            //this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.connectPanel)).BeginInit();
            this.connectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineList)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // connectPanel
            // 
            this.connectPanel.Controls.Add(this.LbStatus);
            this.connectPanel.Controls.Add(this.labelControl3);
            this.connectPanel.Controls.Add(this.BtnStop);
            this.connectPanel.Controls.Add(this.TxtPort);
            this.connectPanel.Controls.Add(this.labelControl2);
            this.connectPanel.Controls.Add(this.TxtAddress);
            this.connectPanel.Controls.Add(this.labelControl1);
            this.connectPanel.Controls.Add(this.BtnStart);
            this.connectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectPanel.Location = new System.Drawing.Point(0, 34);
            this.connectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(381, 362);
            this.connectPanel.TabIndex = 1;
            // 
            // LbStatus
            // 
            this.LbStatus.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.Appearance.Options.UseFont = true;
            this.LbStatus.Appearance.Options.UseTextOptions = true;
            this.LbStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LbStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LbStatus.Location = new System.Drawing.Point(114, 23);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(210, 22);
            this.LbStatus.TabIndex = 7;
            this.LbStatus.Text = "Not Activated";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Status";
            // 
            // BtnStop
            // 
            this.BtnStop.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnStop.ImageOptions.ImageToTextIndent = 5;
            this.BtnStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStop.ImageOptions.SvgImage")));
            this.BtnStop.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnStop.Location = new System.Drawing.Point(230, 152);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnStop.Size = new System.Drawing.Size(94, 32);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // TxtPort
            // 
            this.TxtPort.EditValue = "7777";
            this.TxtPort.Location = new System.Drawing.Point(114, 113);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.Properties.Appearance.Options.UseFont = true;
            this.TxtPort.Size = new System.Drawing.Size(210, 24);
            this.TxtPort.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 116);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Port";
            // 
            // TxtAddress
            // 
            this.TxtAddress.EditValue = "127.0.0.1";
            this.TxtAddress.Location = new System.Drawing.Point(114, 83);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Properties.Appearance.Options.UseFont = true;
            this.TxtAddress.Size = new System.Drawing.Size(210, 24);
            this.TxtAddress.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Address";
            // 
            // BtnStart
            // 
            this.BtnStart.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnStart.ImageOptions.ImageToTextIndent = 5;
            this.BtnStart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStart.ImageOptions.SvgImage")));
            this.BtnStart.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnStart.Location = new System.Drawing.Point(114, 152);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnStart.Size = new System.Drawing.Size(94, 32);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnRestart,
            this.BtnExit,
            this.LbDetail,
            //this.progressBar,
            this.BtnAbout,
            this.barEditItem1});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 18;
            //this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            ////this.repositoryItemProgressBar1,
            ////this.repositoryItemProgressBar2
            //});
            this.barManager1.StatusBar = this.bar2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnRestart),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAbout)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // BtnRestart
            // 
            this.BtnRestart.Caption = "Restart";
            this.BtnRestart.Id = 0;
            this.BtnRestart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRestart.ImageOptions.SvgImage")));
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestart_ItemClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Caption = "Exit";
            this.BtnExit.Id = 1;
            this.BtnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Caption = "About";
            this.BtnAbout.Id = 16;
            this.BtnAbout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAbout.ImageOptions.SvgImage")));
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LbDetail),
            //new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.progressBar, "", false, true, true, 57),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // LbDetail
            // 
            this.LbDetail.AccessibleDescription = "";
            this.LbDetail.Id = 3;
            this.LbDetail.Name = "LbDetail";
            this.LbDetail.Size = new System.Drawing.Size(200, 0);
            this.LbDetail.Width = 200;
            // 
            // progressBar
            // 
            //this.progressBar.Caption = "barEditItem1";
            //this.progressBar.Edit = this.repositoryItemProgressBar1;
            //this.progressBar.Id = 15;
            //this.progressBar.Name = "progressBar";
            // 
            // repositoryItemProgressBar1
            // 
            //this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(381, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(381, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(381, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.OnlineList);
            this.clientPanel.Controls.Add(this.labelControl4);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientPanel.Location = new System.Drawing.Point(0, 243);
            this.clientPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(381, 153);
            this.clientPanel.TabIndex = 6;
            // 
            // OnlineList
            // 
            this.OnlineList.Location = new System.Drawing.Point(117, 24);
            this.OnlineList.Name = "OnlineList";
            this.OnlineList.Size = new System.Drawing.Size(207, 104);
            this.OnlineList.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(51, 24);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Client";
            // 
            // barEditItem1
            // 
            //this.barEditItem1.Caption = "barEditItem1";
            //this.barEditItem1.Edit = this.repositoryItemProgressBar2;
            //this.barEditItem1.Id = 17;
            //this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemProgressBar2
            // 
            //this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
            // 
            // Server
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 424);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.connectPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Server.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.connectPanel)).EndInit();
            this.connectPanel.ResumeLayout(false);
            this.connectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineList)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl connectPanel;
        private DevExpress.XtraEditors.TextEdit TxtPort;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem BtnRestart;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LbStatus;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem LbDetail;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraEditors.ListBoxControl OnlineList;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        //private DevExpress.XtraBars.BarEditItem progressBar;
        //private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.SimpleButton BtnStop;
        private DevExpress.XtraEditors.SimpleButton BtnStart;
        private DevExpress.XtraBars.BarButtonItem BtnAbout;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        //private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
    }
}