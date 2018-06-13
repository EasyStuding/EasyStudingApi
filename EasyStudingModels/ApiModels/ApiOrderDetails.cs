using System.Collections.Generic;
using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiOrderDetails
    {
        public long Id { get; set; }
        public ApiUserInformation Customer { get; set; }
        public ApiUserInformation Executor { get; set; }
        public State State { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
