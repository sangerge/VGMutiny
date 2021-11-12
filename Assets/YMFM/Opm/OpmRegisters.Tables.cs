﻿namespace Ymfm.Opm
{
    using uint32_t = System.UInt32;
    using int32_t = System.Int32;
    using uint8_t = System.Byte;
    using uint16_t = System.UInt16;
    using int16_t = System.Int16;
    using int8_t = System.SByte;

    public partial class OpmRegisters
    {
        // Note that the channel index order is 0,2,1,3, so we bitswap the index.
        //
        // This is because the order in the map is:
        //    carrier 1, carrier 2, modulator 1, modulator 2
        //
        // But when wiring up the connections, the more natural order is:
        //    carrier 1, modulator 1, carrier 2, modulator 2
        private static readonly uint[] FixedMap =
        {
            IFmRegisters<OpmOperatorMapping>.OperatorList(0,16,8,24), // Channel 0 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(1,17,9,25), // Channel 1 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(2,18,10,26), // Channel 2 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(3,19,11,27), // Channel 3 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(4,20,12,28), // Channel 4 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(5,21,13,29), // Channel 5 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(6,22,14,30), // Channel 6 operators
            IFmRegisters<OpmOperatorMapping>.OperatorList(7,23,15,31), // Channel 7 operators
        };

        // start with coarse detune delta; table uses cents value from
        // manual, converted into 1/64ths
        private static readonly short[] Detune2Delta =
        {
            0,
            (600 * 64 + 50) / 100,
            (781 * 64 + 50) / 100,
            (950 * 64 + 50) / 100,
        };

    }
}
