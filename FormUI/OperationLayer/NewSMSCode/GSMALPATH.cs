﻿/* ----------------------------------------------------------
文件名称：GSMALPHABET.cs

作者：秦建辉

MSN：splashcn@msn.com
QQ：36748897

博客：http://blog.csdn.net/jhqin

开发环境：
    Visual Studio V2010
    .NET Framework 4 Client Profile

版本历史：    
    V1.0	2011年08月19日
			GSM编码和Unicode编码对照字典
------------------------------------------------------------ */

using System;
using System.Collections.Generic;

namespace FormUI.OperationLayer.NewSMSCode
{
    /// <summary>
    ///     GSM编码和Unicode编码对照字典
    /// </summary>
    public partial class SMS
    {
        /// <summary>
        ///     Unicode编码到GSM编码转换
        /// </summary>
        private static readonly SortedDictionary<UInt16, UInt16> UCS2ToBIT7 = new SortedDictionary<UInt16, UInt16>
            {
                {0x000C, 0x1B0A},
                {0x0024, 0x0002},
                {0x0040, 0x0000},
                {0x005B, 0x1B3C},
                {0x005C, 0x1B2F},
                {0x005D, 0x1B3E},
                {0x005E, 0x1B14},
                {0x005F, 0x0011},
                {0x007B, 0x1B28},
                {0x007C, 0x1B40},
                {0x007D, 0x1B29},
                {0x007E, 0x1B3D},
                {0x00A0, 0x001B},
                {0x00A1, 0x0040},
                {0x00A3, 0x0001},
                {0x00A4, 0x0024},
                {0x00A5, 0x0003},
                {0x00A7, 0x005F},
                {0x00BF, 0x0060},
                {0x00C4, 0x005B},
                {0x00C5, 0x000E},
                {0x00C6, 0x001C},
                {0x00C9, 0x001F},
                {0x00D1, 0x005D},
                {0x00D6, 0x005C},
                {0x00D8, 0x000B},
                {0x00DC, 0x005E},
                {0x00DF, 0x001E},
                {0x00E0, 0x007F},
                {0x00E4, 0x007B},
                {0x00E5, 0x000F},
                {0x00E6, 0x001D},
                {0x00E7, 0x0009},
                {0x00E8, 0x0004},
                {0x00E9, 0x0005},
                {0x00EC, 0x0007},
                {0x00F1, 0x007D},
                {0x00F2, 0x0008},
                {0x00F6, 0x007C},
                {0x00F8, 0x000C},
                {0x00F9, 0x0006},
                {0x00FC, 0x007E},
                {0x0393, 0x0013},
                {0x0394, 0x0010},
                {0x0398, 0x0019},
                {0x039B, 0x0014},
                {0x039E, 0x001A},
                {0x03A0, 0x0016},
                {0x03A3, 0x0018},
                {0x03A6, 0x0012},
                {0x03A8, 0x0017},
                {0x03A9, 0x0015},
                {0x20AC, 0x1B65}
            };

        /// <summary>
        ///     GSM编码到Unicode编码转换
        /// </summary>
        private static readonly SortedDictionary<UInt16, UInt16> BIT7ToUCS2 = new SortedDictionary<UInt16, UInt16>
            {
                {0x0000, 0x0040},
                {0x0001, 0x00A3},
                {0x0002, 0x0024},
                {0x0003, 0x00A5},
                {0x0004, 0x00E8},
                {0x0005, 0x00E9},
                {0x0006, 0x00F9},
                {0x0007, 0x00EC},
                {0x0008, 0x00F2},
                {0x0009, 0x00E7},
                {0x000B, 0x00D8},
                {0x000C, 0x00F8},
                {0x000E, 0x00C5},
                {0x000F, 0x00E5},
                {0x0010, 0x0394},
                {0x0011, 0x005F},
                {0x0012, 0x03A6},
                {0x0013, 0x0393},
                {0x0014, 0x039B},
                {0x0015, 0x03A9},
                {0x0016, 0x03A0},
                {0x0017, 0x03A8},
                {0x0018, 0x03A3},
                {0x0019, 0x0398},
                {0x001A, 0x039E},
                {0x001B, 0x00A0},
                {0x001C, 0x00C6},
                {0x001D, 0x00E6},
                {0x001E, 0x00DF},
                {0x001F, 0x00C9},
                {0x0024, 0x00A4},
                {0x0040, 0x00A1},
                {0x005B, 0x00C4},
                {0x005C, 0x00D6},
                {0x005D, 0x00D1},
                {0x005E, 0x00DC},
                {0x005F, 0x00A7},
                {0x0060, 0x00BF},
                {0x007B, 0x00E4},
                {0x007C, 0x00F6},
                {0x007D, 0x00F1},
                {0x007E, 0x00FC},
                {0x007F, 0x00E0}
            };

        /// <summary>
        ///     GSM编码转义序列到Unicode编码转换
        /// </summary>
        private static readonly SortedDictionary<UInt16, UInt16> BIT7EToUCS2 = new SortedDictionary<UInt16, UInt16>
            {
                {0x000A, 0x000C},
                {0x0014, 0x005E},
                {0x0028, 0x007B},
                {0x0029, 0x007D},
                {0x002F, 0x005C},
                {0x003C, 0x005B},
                {0x003D, 0x007E},
                {0x003E, 0x005D},
                {0x0040, 0x007C},
                {0x0065, 0x20AC}
            };
    }
}