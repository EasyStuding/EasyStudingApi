using System.Collections.Generic;
using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiOrderDetailsModel : IValidatedEntity
    {
        public long Id { get; set; }
        public ApiUserDescriptionModel Customer { get; set; }
        public ApiUserDescriptionModel Executor { get; set; }
        public State State { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
        public IEnumerable<Skill> Skills { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && Customer.Validate()
                && Executor.Validate()
                && State.Validate()
                && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description);
        }
    }
}
