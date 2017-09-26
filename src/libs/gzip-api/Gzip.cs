/*
    A security toolkit for windows    

    Copyright(C) 2016-2017 Guido Lucassen

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.libs.gzip_api
{
    class Gzip
    {

        private static Gzip g;

        private Gzip() { }

        public string Decompress(string input)
        {
            byte[] compressed = Convert.FromBase64String(input);
            byte[] decompressed = Decompress(compressed);
            return Encoding.UTF8.GetString(decompressed);
        }

        public string Compress(string input)
        {
            byte[] encoded = Encoding.UTF8.GetBytes(input);
            byte[] compressed = Compress(encoded);
            return Convert.ToBase64String(compressed);
        }

        public byte[] Decompress(byte[] input)
        {
            using (var source = new MemoryStream(input))
            {
                byte[] lengthBytes = new byte[4];
                source.Read(lengthBytes, 0, 4);

                var length = BitConverter.ToInt32(lengthBytes, 0);
                using (var decompressionStream = new GZipStream(source,
                    CompressionMode.Decompress))
                {
                    var result = new byte[length];
                    decompressionStream.Read(result, 0, length);
                    return result;
                }
            }
        }

        public byte[] Compress(byte[] input)
        {
            using (var result = new MemoryStream())
            {
                var lengthBytes = BitConverter.GetBytes(input.Length);
                result.Write(lengthBytes, 0, 4);

                using (var compressionStream = new GZipStream(result,
                    CompressionMode.Compress))
                {
                    compressionStream.Write(input, 0, input.Length);
                    compressionStream.Flush();

                }
                return result.ToArray();
            }
        }

        public static Gzip GetGzipApi()
        {
            if (g == null)
            {
                g = new Gzip();
            }
            return g;
        }

    }
}
