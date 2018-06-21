namespace EasyStudingModels.DbContextModels
{
    public partial class Attachment: IEntity<Attachment>
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Ref { get; set; }

        public void Edit(Attachment attachment)
        {
            Type = attachment.Type;
            Ref = attachment.Ref;
        }
    }
}
