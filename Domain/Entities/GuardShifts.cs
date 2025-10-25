using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class GuardShifts
    {
        public int Id { get; set; }
        public int GuardId { get; set; }
        public int ZoneId { get; set; }
        public int ShiftId { get; set; }
        public DateTimeOffset ShiftDate { get; set; }
        public ShiftStatus Status { get; set; }
        // Navigation Properties
        public virtual Guard Guard { get; set; }
        public virtual Zone Zone { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
