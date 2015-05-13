using System;
using System.Collections.Generic;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class RoleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public decimal? SalaryPerHour { get; set; }
        public int? TimeQuota { get; set; }
        public IEnumerable<Guid> StoresId { get; set; }
        public int? BreaksAllowed { get; set; }
        public decimal? MinutesPerBreak { get; set; }
        public decimal? OvertimeHourlyRate { get; set; }
        public decimal? HoursSheduled { get; set; }
        public decimal? MaxCashAllowed { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
        public int? EmployeesReferences { get; set; }
    }
}
