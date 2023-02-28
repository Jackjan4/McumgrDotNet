using JanRoslan.McumgrDotnet.Packaging;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace JanRoslan.McumgrDotNet.Transport
{
    internal class SerialTransport : ITransportLayer
    {
        private SerialPort serialPort;

        public SerialTransport()
        {
            serialPort = new SerialPort();
        }

        public SerialTransport(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            serialPort = new SerialPort(portName,baudRate,parity,dataBits,stopBits);
        }

        public McumgrPacket ReceivePacket()
        {
            throw new NotImplementedException();
        }

        public void SendPacket(McumgrPacket packet)
        {
            throw new NotImplementedException();
        }

        public void SendPackets(McumgrPacket[] packets)
        {
            throw new NotImplementedException();
        }

        public void SetPortName(string portName)
        {
            serialPort.PortName = portName;
        }

        public void SetBaudRate(int baudRate)
        {
            serialPort.BaudRate = baudRate;
        }

        public void SetParity(Parity parity) {
            serialPort.Parity = parity;
        }

        public void SetDataBits(int dataBits)
        {
            serialPort.DataBits = dataBits;
        }

        public void SetStopBits(StopBits stopBits)
        {
            serialPort.StopBits = stopBits;
        }

        public McumgrPacket SendReceivePacket(McumgrPacket packet)
        {
            throw new NotImplementedException();
        }

        public McumgrPacket SendPacketsReceive(McumgrPacket[] packets)
        {
            throw new NotImplementedException();
        }
    }
}
