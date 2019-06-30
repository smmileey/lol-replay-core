using Lol_AutoRecorder.Enums;
using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Lol_AutoRecorder.Mappings
{
    public class StringToScreenModeMapper : IStringToScreenModeMapper
    {
        private readonly ILogger _logger;

        public StringToScreenModeMapper(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        private readonly Dictionary<string, string> _mappings = new Dictionary<string, string>
        {
            {"Full Screen", "FullScreen" },
            {"Window Mode", "WindowMode" }
        };


        public ScreenMode Map(string value)
        {
            _logger.Debug($"Mapping value: {value} to ScreenMode.");

            if (!_mappings.TryGetValue(value, out var mapping)) throw new StringToScreenModeMapperException($"No mapping found for value: {value}. ");
            if (!Enum.TryParse(mapping, out ScreenMode result)) throw new StringToScreenModeMapperException($"Unable to parse value: {mapping} to ScreenMode enum. ");

            return result;
        }
    }
}
