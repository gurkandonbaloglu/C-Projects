using NAudio.Wave;
using System;

namespace AtYarısı
{
    internal class WaveStream
    {
        public static implicit operator WaveStream(WaveFileReader v)
        {
            throw new NotImplementedException();
        }
    }
}