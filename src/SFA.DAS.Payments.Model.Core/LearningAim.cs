using System;
using SFA.DAS.Payments.Model.Core.Entities;

namespace SFA.DAS.Payments.Model.Core
{
    public class LearningAim
    {
        public string Reference { get; set; }

        public int ProgrammeType { get; set; }

        public int StandardCode { get; set; }

        public string CourseCode { get; set; }

        public int FrameworkCode { get; set; }

        public int PathwayCode { get; set; }

        public string FundingLineType { get; set; }
        public long SequenceNumber { get; set; }

        public DateTime StartDate { get; set; }

        public LearningType LearningType { get; set; } = LearningType.Apprenticeship;

        public LearningAim Clone()
        {
            return (LearningAim)MemberwiseClone();
        }
    }
}
