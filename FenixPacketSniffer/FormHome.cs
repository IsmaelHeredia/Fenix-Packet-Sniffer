// Fenix Packet Sniffer 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using Telerik.WinControls;
using Telerik.WinControls.UI;

using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Base;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Packets.Http;

namespace FenixPacketSniffer
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        public string title;

        IList<LivePacketDevice> allDevices;

        public Thread threadSniffing;
        public Thread threadSaveSniffing;

        public int packet_number = 0;

        public ArrayList detailsPacket = new ArrayList();

        public string pcap_file;

        public FormHome()
        {
            InitializeComponent();
            title = "Fenix Packet Sniffer 1.0";
            RadMessageBox.SetThemeName("TelerikMetro");

            try
            {
                allDevices = LivePacketDevice.AllLocalMachine;
            }
            catch(Exception e)
            {
                RadMessageBox.Show("Try running as administrator and install winpcap", title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Sniffing()
        {
            PacketDevice selectedDevice = allDevices[ddlNetworkAdapters.SelectedIndex];

            using (PacketCommunicator PkCommunicator = selectedDevice.Open(65536,
             PacketDeviceOpenAttributes.NoCaptureRemote | PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                if (txtFilters.Text != "")
                {
                    PkCommunicator.SetFilter(txtFilters.Text);
                }

                PkCommunicator.ReceivePackets(0, GetPacketInfo);
            }
        }

        private void SaveSniffing()
        {
            PacketDevice saveSelectedDevice = allDevices[ddlNetworkAdapters.SelectedIndex];

            using (PacketCommunicator PkCommunicator = saveSelectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                if (txtFilters.Text != "")
                {
                    PkCommunicator.SetFilter(txtFilters.Text);
                }

                using (PacketDumpFile PkDumpFile = PkCommunicator.OpenDump(pcap_file))
                {
                    PkCommunicator.ReceivePackets(0, PkDumpFile.Dump);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ddlNetworkAdapters.Text != "")
            {
                txtPacketInformation.Text = "";
                detailsPacket.Clear();
                packet_number = 0;

                if (cbSaveData.Checked)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    saveFileDialog.Title = "Save Pcap file";
                    saveFileDialog.DefaultExt = "pcap";
                    saveFileDialog.Filter = "Pcap File (.pcap)|*.pcap";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pcap_file = saveFileDialog.FileName;
                    }
                }

                lvPackets.Items.Clear();

                lblStatus.Text = "Sniffing ...";

                threadSniffing = new Thread(Sniffing);
                threadSniffing.Start();

                if (cbSaveData.Checked)
                {
                    if (pcap_file != "")
                    {
                        threadSaveSniffing = new Thread(SaveSniffing);
                        threadSaveSniffing.Start();
                    }
                }
            }
            else
            {
                RadMessageBox.Show("No adapter found", title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void GetPacketInfo(Packet packet)
        {
            IpV4Datagram ip = packet.Ethernet.IpV4;

            TcpDatagram tcp = ip.Tcp;
            UdpDatagram udp = ip.Udp;

            string source_ip = ip.Source.ToString();
            string destination_ip = ip.Destination.ToString();
            string protocol = ip.Protocol.ToString();

            packet_number = packet_number + 1;

            ListViewDataItem item = new ListViewDataItem();

            item.SubItems.Add(packet_number);
            item.SubItems.Add(packet.Timestamp.ToString("dd/MM/yyyy hh:mm:ss"));
            item.SubItems.Add(source_ip);
            item.SubItems.Add(destination_ip);
            item.SubItems.Add(protocol);
            item.SubItems.Add(packet.Length);

            string information = "";

            if (protocol == "Tcp")
            {
                string tcp_sourceport = tcp.SourcePort.ToString();
                string tcp_destinationport = tcp.DestinationPort.ToString();
                string tcp_acknowledgmentNumber = tcp.AcknowledgmentNumber.ToString();
                string tcp_sequenceNumber = tcp.SequenceNumber.ToString();
                string tcp_nextSequenceNumber = tcp.NextSequenceNumber.ToString();

                information = "[+] Source port : " + tcp_sourceport + "\n";
                information += "[+] Destination port : " + tcp_destinationport + "\n";
                information += "[+] Acknowledgment number : " + tcp_acknowledgmentNumber + "\n";
                information += "[+] Sequence number : " + tcp_sequenceNumber + "\n";
                information += "[+] Next sequence number : " + tcp_nextSequenceNumber + "\n";
            }
            else if (protocol == "Udp")
            {
                string udp_count = packet.Count.ToString();
                string udp_time = packet.Timestamp.ToString();
                string udp_source = ip.Source.ToString();
                string udp_destination = ip.Destination.ToString();
                string udp_length = ip.Length.ToString();
                string udp_protocol = ip.Protocol.ToString();
                string udp_sourceport = udp.SourcePort.ToString();
                string udp_destinationport = udp.DestinationPort.ToString();

                information = "[+] Count : " + udp_count + "\n";
                information += "[+] Time : " + udp_time + "\n";
                information += "[+] Source : " + udp_source + "\n";
                information += "[+] Destination : " + udp_destination + "\n";
                information += "[+] Length : " + udp_length + "\n";
                information += "[+] Protocol : " + udp_protocol + "\n";
                information += "[+] Source port : " + udp_sourceport + "\n";
                information += "[+] Destination port : " + udp_destinationport + "\n";
            }
            else
            {
                string other_count = packet.Count.ToString();
                string other_time = packet.Timestamp.ToString();
                string other_source = ip.Source.ToString();
                string other_destination = ip.Destination.ToString();
                string other_length = ip.Length.ToString();
                string other_protocol = ip.Protocol.ToString();

                information = "[+] Count : " + other_count + "\n";
                information += "[+] Time : " + other_time + "\n";
                information += "[+] Source : " + other_source + "\n";
                information += "[+] Destination : " + other_destination + "\n";
                information += "[+] Length : " + other_length + "\n";
                information += "[+] Protocol : " + other_protocol + "\n";
            }

            detailsPacket.Add(information);

            Action actionList = () => lvPackets.Items.Add(item);
            lvPackets.Invoke(actionList);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (ddlNetworkAdapters.Text != "")
            {
                lblStatus.Text = "Stopped";

                if (threadSniffing != null)
                {
                    threadSniffing.Abort();
                }
                if (threadSaveSniffing != null)
                {
                    threadSaveSniffing.Abort();
                }
            }
            else
            {
                RadMessageBox.Show("No adapter found", title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void lvPackets_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            if (lvPackets.SelectedItems.Count > 0)
            {
                int id_packet = Convert.ToInt32(lvPackets.SelectedItem[0]) - 1;
                string information = Convert.ToString(detailsPacket[id_packet]);
                txtPacketInformation.Text = information;
            }
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (allDevices.Count == 0)
            {
                RadMessageBox.Show("No adapters found", title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                for (int i = 0; i != allDevices.Count; ++i)
                {
                    LivePacketDevice device = allDevices[i];
                    if (device.Description != null)
                    {
                        RadListDataItem item = new RadListDataItem();
                        item.Text = device.Description;
                        ddlNetworkAdapters.Items.Add(item);
                    }
                    else
                    {
                        RadListDataItem item = new RadListDataItem();
                        item.Text = "Unknown";
                        ddlNetworkAdapters.Items.Add(item);
                    }
                }

                if (ddlNetworkAdapters.Items.Count > 0)
                {
                    ddlNetworkAdapters.SelectedIndex = 0;
                }
            }
        }
    }
}
