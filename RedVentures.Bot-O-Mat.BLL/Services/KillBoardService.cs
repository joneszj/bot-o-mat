using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class KillBoardService : IKillBoardService
    {
        #region ctor && private
        private readonly IActorRepository _actorRepository;
        public KillBoardService(IActorRepository actorRepository) => _actorRepository = actorRepository;
        #endregion

        public async Task<IEnumerable<KillBoardDTO>> GetKillCounts()
        {
            return await GetKillBoardRecords();
        }

        #region helpers
        private async Task<IEnumerable<KillBoardDTO>> GetKillBoardRecords()
        {
            var killerIds = _actorRepository.GetAll(ignorFilters: true).Where(e => e.DestroyedById != null).GroupBy(e => e.DestroyedById).ToList();
            return await _actorRepository.GetAll(true)
                .Where(killers => killerIds.Select(i => i.Key).Contains(killers.Id))
                .Select(e => new KillBoardDTO
                {
                    Id = e.Id,
                    Name = e.Name,
                    KillCount = killerIds.Where(i => i.Key.Value == e.Id).SelectMany(y => y).Count(),
                    ActorType = Enum.GetName(typeof(ActorType), e.ActorType)
                })
                .OrderByDescending(e => e.KillCount).Take(20)
                //TODO: remove dependancy on EF in BLL
                .ToListAsync();
        }
        #endregion
    }
}
