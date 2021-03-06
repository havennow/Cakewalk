﻿using System.Runtime.InteropServices;

namespace Cakewalk.Shared.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RequestZoneTransfer : IPacketBase
    {
        private PacketHeader m_header;
        private int m_zoneID;

        public PacketHeader Header
        {
            get { return m_header; }
        }

        public int ZoneID
        {
            get { return m_zoneID; }
            set { m_zoneID = value; }
        }

        public void SetupHeader()
        {
            m_header = new PacketHeader()
            {
                OpCode = PacketCode.RequestZoneTransfer,
                SizeInBytes = (short)Marshal.SizeOf(this)
            };
        }
    }
}
