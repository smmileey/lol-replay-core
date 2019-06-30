using LolAutoRecorder.CommonLibrary.Enums;
using System;
using System.Collections.Generic;

namespace LolAutoRecorder.CommonLibrary.Mappers
{
    public class InitializerToUShortMapper : IInitializerToUShortMapper
    {
        private static readonly Dictionary<Initializer, ushort> RegularMappings = new Dictionary<Initializer, ushort>
        {
            {Initializer.One, 0x02 },
            {Initializer.Two, 0x03 },
            {Initializer.Three, 0x04 },
            {Initializer.Four, 0x05 },
            {Initializer.Five, 0x06 },
            {Initializer.Q, 0x10},
            {Initializer.W, 0x11 },
            {Initializer.E, 0x12 },
            {Initializer.R, 0x13 },
            {Initializer.T, 0x14 },
            {Initializer.P, 0x19 },
            {Initializer.Alt, 0x38 },
            {Initializer.Enter, 0x1C },
            {Initializer.Space, 0x39 }
        };

        public ushort Map(Initializer initialzer)
        {
            if (RegularMappings.TryGetValue(initialzer, out var mappedValue)) return mappedValue;

            throw new ArgumentOutOfRangeException(nameof(mappedValue));
        }
    }
}
