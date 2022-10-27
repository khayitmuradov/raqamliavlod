﻿using CodePower.DataAccess.Common;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Interfaces.Contests
{
    public interface IContestStandingsRepository
        : IRepository<ContestStandings>
    {
        public Task<PagedList<ContestStandings>> GetAllByContestIdAsync(long contestId);
    }
}
