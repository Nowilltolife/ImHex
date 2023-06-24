﻿#pragma warning disable SYSLIB1054

using System.Drawing;
using System.Runtime.InteropServices;

namespace ImHex
{
    public class Bookmarks
    {
        [DllImport(Library.Name)]
        private static extern void createBookmarkV1(UInt64 address, UInt64 size, UInt32 color, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string description);

        public static void CreateBookmark(UInt64 address, UInt64 size, Color color, string name = "", string description = "")
        {
            unsafe
            {
                createBookmarkV1(address, size, (UInt32)((color.ToArgb() << 8) | 0xA0), name, description);
            }
        }

    }
}
