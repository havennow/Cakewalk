﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Cakewalk.Shared.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct AuthResponse : IPacketBase
    {
        private short m_opCode;
        private int m_worldID;

        public PacketCode OpCode
        {
            get { return (PacketCode)m_opCode; }
            set { m_opCode = (short)value; }
        }

        public int WorldID
        {
            get { return m_worldID; }
            set { m_worldID = value; }
        }
    }
}