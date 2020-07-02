namespace FenixPacketSniffer
{
    partial class FormHome
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Number");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "DateTime");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Source");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Destination");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Protocol");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Length");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.gbSelectInterface = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlNetworkAdapters = new Telerik.WinControls.UI.RadDropDownList();
            this.gbEnterFilters = new Telerik.WinControls.UI.RadGroupBox();
            this.txtFilters = new Telerik.WinControls.UI.RadTextBox();
            this.gbPackets = new Telerik.WinControls.UI.RadGroupBox();
            this.lvPackets = new Telerik.WinControls.UI.RadListView();
            this.gbPacketInformation = new Telerik.WinControls.UI.RadGroupBox();
            this.txtPacketInformation = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            this.cbSaveData = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbSelectInterface)).BeginInit();
            this.gbSelectInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNetworkAdapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEnterFilters)).BeginInit();
            this.gbEnterFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPackets)).BeginInit();
            this.gbPackets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPackets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPacketInformation)).BeginInit();
            this.gbPacketInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacketInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSaveData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelectInterface
            // 
            this.gbSelectInterface.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbSelectInterface.Controls.Add(this.ddlNetworkAdapters);
            this.gbSelectInterface.HeaderText = "Select network adapter";
            this.gbSelectInterface.Location = new System.Drawing.Point(12, 12);
            this.gbSelectInterface.Name = "gbSelectInterface";
            this.gbSelectInterface.Size = new System.Drawing.Size(604, 67);
            this.gbSelectInterface.TabIndex = 0;
            this.gbSelectInterface.Text = "Select network adapter";
            this.gbSelectInterface.ThemeName = "TelerikMetro";
            // 
            // ddlNetworkAdapters
            // 
            this.ddlNetworkAdapters.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlNetworkAdapters.Location = new System.Drawing.Point(27, 30);
            this.ddlNetworkAdapters.Name = "ddlNetworkAdapters";
            this.ddlNetworkAdapters.Size = new System.Drawing.Size(560, 24);
            this.ddlNetworkAdapters.TabIndex = 0;
            this.ddlNetworkAdapters.ThemeName = "TelerikMetro";
            // 
            // gbEnterFilters
            // 
            this.gbEnterFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbEnterFilters.Controls.Add(this.txtFilters);
            this.gbEnterFilters.HeaderText = "Enter filters";
            this.gbEnterFilters.Location = new System.Drawing.Point(12, 95);
            this.gbEnterFilters.Name = "gbEnterFilters";
            this.gbEnterFilters.Size = new System.Drawing.Size(604, 64);
            this.gbEnterFilters.TabIndex = 1;
            this.gbEnterFilters.Text = "Enter filters";
            this.gbEnterFilters.ThemeName = "TelerikMetro";
            // 
            // txtFilters
            // 
            this.txtFilters.Location = new System.Drawing.Point(17, 30);
            this.txtFilters.Name = "txtFilters";
            this.txtFilters.Size = new System.Drawing.Size(570, 24);
            this.txtFilters.TabIndex = 0;
            this.txtFilters.Text = "tcp port 443";
            this.txtFilters.ThemeName = "TelerikMetro";
            // 
            // gbPackets
            // 
            this.gbPackets.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbPackets.Controls.Add(this.lvPackets);
            this.gbPackets.HeaderText = "Packets";
            this.gbPackets.Location = new System.Drawing.Point(12, 175);
            this.gbPackets.Name = "gbPackets";
            this.gbPackets.Size = new System.Drawing.Size(604, 284);
            this.gbPackets.TabIndex = 2;
            this.gbPackets.Text = "Packets";
            this.gbPackets.ThemeName = "TelerikMetro";
            // 
            // lvPackets
            // 
            listViewDetailColumn1.HeaderText = "Number";
            listViewDetailColumn2.HeaderText = "DateTime";
            listViewDetailColumn3.HeaderText = "Source";
            listViewDetailColumn4.HeaderText = "Destination";
            listViewDetailColumn5.HeaderText = "Protocol";
            listViewDetailColumn6.HeaderText = "Length";
            this.lvPackets.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lvPackets.ItemSpacing = -1;
            this.lvPackets.Location = new System.Drawing.Point(27, 36);
            this.lvPackets.Name = "lvPackets";
            this.lvPackets.Size = new System.Drawing.Size(548, 229);
            this.lvPackets.TabIndex = 0;
            this.lvPackets.Text = "radListView1";
            this.lvPackets.ThemeName = "TelerikMetro";
            this.lvPackets.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvPackets.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lvPackets_ItemMouseClick);
            // 
            // gbPacketInformation
            // 
            this.gbPacketInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbPacketInformation.Controls.Add(this.txtPacketInformation);
            this.gbPacketInformation.HeaderText = "Packet information";
            this.gbPacketInformation.Location = new System.Drawing.Point(12, 474);
            this.gbPacketInformation.Name = "gbPacketInformation";
            this.gbPacketInformation.Size = new System.Drawing.Size(303, 185);
            this.gbPacketInformation.TabIndex = 3;
            this.gbPacketInformation.Text = "Packet information";
            this.gbPacketInformation.ThemeName = "TelerikMetro";
            // 
            // txtPacketInformation
            // 
            this.txtPacketInformation.IsReadOnly = true;
            this.txtPacketInformation.Location = new System.Drawing.Point(17, 32);
            this.txtPacketInformation.Multiline = true;
            this.txtPacketInformation.Name = "txtPacketInformation";
            this.txtPacketInformation.Size = new System.Drawing.Size(269, 134);
            this.txtPacketInformation.TabIndex = 0;
            this.txtPacketInformation.ThemeName = "TelerikMetro";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 680);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(628, 25);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "TelerikMetro";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextWrap = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(344, 474);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(255, 24);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.ThemeName = "TelerikMetro";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(344, 506);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(255, 24);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.ThemeName = "TelerikMetro";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbSaveData
            // 
            this.cbSaveData.Location = new System.Drawing.Point(344, 547);
            this.cbSaveData.Name = "cbSaveData";
            this.cbSaveData.Size = new System.Drawing.Size(76, 19);
            this.cbSaveData.TabIndex = 7;
            this.cbSaveData.Text = "Save data";
            this.cbSaveData.ThemeName = "TelerikMetro";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 705);
            this.Controls.Add(this.cbSaveData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.gbPacketInformation);
            this.Controls.Add(this.gbPackets);
            this.Controls.Add(this.gbEnterFilters);
            this.Controls.Add(this.gbSelectInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fenix Packet Sniffer 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbSelectInterface)).EndInit();
            this.gbSelectInterface.ResumeLayout(false);
            this.gbSelectInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNetworkAdapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEnterFilters)).EndInit();
            this.gbEnterFilters.ResumeLayout(false);
            this.gbEnterFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPackets)).EndInit();
            this.gbPackets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvPackets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPacketInformation)).EndInit();
            this.gbPacketInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPacketInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSaveData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadGroupBox gbSelectInterface;
        private Telerik.WinControls.UI.RadDropDownList ddlNetworkAdapters;
        private Telerik.WinControls.UI.RadGroupBox gbEnterFilters;
        private Telerik.WinControls.UI.RadGroupBox gbPackets;
        private Telerik.WinControls.UI.RadGroupBox gbPacketInformation;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadListView lvPackets;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadButton btnStop;
        private Telerik.WinControls.UI.RadCheckBox cbSaveData;
        private Telerik.WinControls.UI.RadTextBoxControl txtPacketInformation;
        private Telerik.WinControls.UI.RadTextBox txtFilters;
    }
}