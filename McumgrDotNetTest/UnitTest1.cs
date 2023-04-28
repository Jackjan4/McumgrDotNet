using JanRoslan.McumgrDotnet.Commands;
using JanRoslan.McumgrDotnet.Encoding;
using JanRoslan.McumgrDotnet.Packaging;
using JanRoslan.McumgrDotNet.Encoding;
using JanRoslan.McumgrDotNet.Packaging;
using JanRoslan.McumgrDotNet.Transport;

namespace McumgrDotNetTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SmpEncoder smpEncoder = new SmpEncoder();
            SerialPackager serialPackager = new SerialPackager();
            SerialTransport serialTransport = new SerialTransport();

            serialTransport.SetPortName("COM4");
            serialTransport.SetBaudRate(115200);
            serialTransport.SetParity(System.IO.Ports.Parity.None);
            serialTransport.SetDataBits(8);
            serialTransport.SetStopBits(System.IO.Ports.StopBits.One);

            EchoCommand echoCmd = new EchoCommand("hello");

            EncodedMcumgrCommand encCommand = smpEncoder.EncodeMcumgrCommand(echoCmd);

            McumgrPacket serialPacket = serialPackager.PackCommand(encCommand);

            serialTransport.SendPacket(serialPacket);
            
        }
    }
}