using catnetcoreapi.Application.Interfaces;
using System;

namespace catnetcoreapi.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
