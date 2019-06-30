using Lol_AutoRecorder.Enums;
using Lol_AutoRecorder.Interfaces;
using Lol_AutoRecorder.Wrappers;
using LolAutoRecorder.CommonLibrary.Enums;
using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Lol_AutoRecorder.Mappings
{
    public class ParticipantIdToInitializerMapper : IParticipantIdToInitializerMapper
    {
        private readonly ILogger _logger;

        public ParticipantIdToInitializerMapper(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        private readonly Dictionary<TeamChaosOrder, Dictionary<string, Initializer>> _mappings = new Dictionary<TeamChaosOrder, Dictionary<string, Initializer>>
        {
            {TeamChaosOrder.Order, new Dictionary<string, Initializer>
            {
                {"0", Initializer.One },
                {"1", Initializer.Two },
                {"2", Initializer.Three },
                {"3", Initializer.Four },
                {"4", Initializer.Five },
            }},
                {TeamChaosOrder.Chaos, new Dictionary<string, Initializer>
            {
                {"0", Initializer.Q },
                {"1", Initializer.W },
                {"2", Initializer.E },
                {"3", Initializer.R },
                {"4", Initializer.T },
            }}
        };


        public Initializer Map(PlayerIdProviderResult playerIdProviderResult)
        {
            _logger.Debug("Mapping the player champion.");
            if (playerIdProviderResult == null) throw new ArgumentNullException(nameof(playerIdProviderResult));

            if (!_mappings.TryGetValue(playerIdProviderResult.Team, out var teamMappings)) throw new ArgumentException($"Unsupported team: {playerIdProviderResult.Team}");
            if (!teamMappings.TryGetValue(playerIdProviderResult.Id, out var initializer)) throw new ArgumentException($"Unsuporrted id: {playerIdProviderResult.Id}");

            return initializer;
        }
    }
}
