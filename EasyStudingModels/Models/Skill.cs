using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EasyStudingModels.Models
{
    [DataContract]
    public partial class Skill: IEntity<Skill>
    {
        [Key]
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        //TOFIX: Shadow FK in query to DB.
        public long UserId { get; set; }

        public void Edit(Skill skill)
        {
            Name = skill.Name;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(Name);
        }
    }
}
