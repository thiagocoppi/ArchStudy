using Domain.Base;
using System;

namespace Domain
{
    public abstract class BaseEntity : ValidatorDomain
    {
        public Guid Id { get; set; }
    }
}