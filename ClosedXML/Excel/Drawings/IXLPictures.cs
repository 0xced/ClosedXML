﻿using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

namespace ClosedXML.Excel.Drawings
{
    public interface IXLPictures : IEnumerable<IXLPicture>
    {
        int Count { get; }

        IXLPicture Add(Stream stream);

        IXLPicture Add(Stream stream, String name);

        IXLPicture Add(Stream stream, XLPictureFormat format);

        IXLPicture Add(Stream stream, XLPictureFormat format, String name);

        IXLPicture Add(Image image, IImageFormat imageFormat);

        IXLPicture Add(Image image, IImageFormat imageFormat, String name);

        IXLPicture Add(String imageFile);

        IXLPicture Add(String imageFile, String name);

        bool Contains(String pictureName);

        void Delete(String pictureName);

        void Delete(IXLPicture picture);

        IXLPicture Picture(String pictureName);

        bool TryGetPicture(String pictureName, out IXLPicture picture);
    }
}
