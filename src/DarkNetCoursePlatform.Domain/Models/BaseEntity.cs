
using System;

namespace DarkNetCoursePlatform.Domain.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}