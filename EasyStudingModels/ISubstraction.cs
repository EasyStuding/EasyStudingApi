using System;

namespace EasyStudingModels
{
    public interface ISubstraction
    {
        long Id { get; set; }
        bool? IsActive { get; set; }
        long CostId { get; set; }
        DateTime DateExpires { get; set; }
    }
}
