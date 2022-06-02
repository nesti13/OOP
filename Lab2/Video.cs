using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class VideoMemory
    {
        // сколько памяти
        public int Memory { get; set; }
        public VideoMemory(int x)
        {
            Memory = x;
        }
    }
    public class Video
    {
        public VideoMemory VideoMemory { get; set; }
        public string VideoName { get; set; }
        public string DirectX { get; set; }

        public override string ToString()
        {
            return VideoName + VideoMemory + DirectX;
        }
        public Video(string videoName, string directX, VideoMemory videoMemory)
        {
            VideoName = videoName;
            DirectX = directX;
            VideoMemory = videoMemory;
        }
        public Video() { }
    }
}
