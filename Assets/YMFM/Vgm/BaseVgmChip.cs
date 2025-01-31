﻿using System;
using JetBrains.Annotations;
using Unity.Mathematics.FixedPoint;

namespace Ymfm.Vgm
{
    public abstract class BaseVgmChip
    {
        public abstract uint SampleRate
        {
            [Pure]
            get;
        }

        public abstract ChipType Type
        {
            [Pure]
            get;
        }

        public abstract void Write(uint reg, byte data);
        public abstract void Generate(long outputStart, long outputStep, Span<int> outputBuffer);
        public abstract void WriteData(AccessClass type, uint @base, ReadOnlySpan<byte> src);
        public abstract void SeekPcm(uint pos);
        public abstract byte ReadPcm();
    }
}
