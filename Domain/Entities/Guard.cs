using Domain.Enums;
using System;
using System.Collections.Generic;
namespace Domain.Entities
{
    public class Guard
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public GuardGender guardGender { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int YearOfBirth { get; set; }
        public GuardStatus Status { get; set; }
    }
}
