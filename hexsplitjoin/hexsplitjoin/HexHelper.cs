using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hexsplitjoin
{
    static class HexHelper
    {
        public static void Copy(string SrcPath, string DstPath, int SrcStartAddress, int SrcEndAddress, int DstStartAddress)
        {
            if (!File.Exists(SrcPath))
                return;

            using (FileStream infs = new FileStream(SrcPath, FileMode.Open))
            using (FileStream outfs = new FileStream(DstPath, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[SrcEndAddress - SrcStartAddress + 1];
                infs.Seek(SrcStartAddress, SeekOrigin.Begin);
                infs.Read(buffer, 0, buffer.Length);
                outfs.Seek(DstStartAddress, SeekOrigin.Begin);
                outfs.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
