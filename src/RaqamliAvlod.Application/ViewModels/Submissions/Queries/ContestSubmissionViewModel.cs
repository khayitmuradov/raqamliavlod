﻿using RaqamliAvlod.Domain.Entities.Submissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Submissions.Queries
{
    public class ContestSubmissionViewModel
    {
        public string Result { get; set; } = String.Empty;
        public string Language { get; set; } = String.Empty;
        public int ExecutionTime { get; set; }
        public int MemoryUsage { get; set; }
        public int LengthOfCode { get; set; }
        public string Username { get; set; } = string.Empty;
        public long ProblemSetId { get; set; }
        public long? ContestId { get; set; }

        public static implicit operator ContestSubmissionViewModel(Submission submission)
        {
            return new ContestSubmissionViewModel()
            {
                Result = submission.Result,
                Language = submission.Language,
                ExecutionTime = submission.ExecutionTime,
                MemoryUsage = submission.MemoryUsage,
                LengthOfCode = submission.LengthOfCode,
                ProblemSetId = submission.ProblemSetId,
                ContestId = submission.ContestId
            };
        }
    }
}
