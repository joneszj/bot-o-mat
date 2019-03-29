using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    //TODO: calculate weighted augmentation preferences on robot type
    public class ErrandService : IErrandService
    {
        #region ctor && private
        private readonly IErrandRepository _errandRepository;
        private readonly IBattleService _battleService;
        private readonly Random _random;
        private readonly Stopwatch _stopwatch;

        public ErrandService(IErrandRepository errandRepository, IBattleService battleService)
        {
            _errandRepository = errandRepository;
            _battleService = battleService;
            _random = new Random();
            _stopwatch = new Stopwatch();
        } 
        #endregion

        public async Task<ErrandDTO> PerformErrand(ICanPerformErrand actor, ErrandType errandType)
        {
            var errandDTO = new ErrandDTO(actor, errandType, _stopwatch, _random) { Status = ErrandStatus.In_Progress };

            errandDTO.AttemptToCompleteErrand();
            if (errandDTO.ErrandDidNotFail()) errandDTO.SetErrandCompletedSuccessfully();
            else
            {
                errandDTO.SetErrandFailed();
                errandDTO.TerminatedActor = await _battleService.DestroyAnotherActor(actor);
            }

            return errandDTO;
        }
    }
}
