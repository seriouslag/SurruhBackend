﻿namespace SurruhBackend.Models
{
    public class Image
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string ContentType { get; set; }

        public ImageData ImageData { get; set; }    
    }
}