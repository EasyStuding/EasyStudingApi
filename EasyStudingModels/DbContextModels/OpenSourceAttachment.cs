namespace EasyStudingModels.DbContextModels
{
    public partial class OpenSourceAttachment: IEntity<OpenSourceAttachment>
    {
        public long Id { get; set; }
        public long OpenSourceId { get; set; }
        public long AttachmentId { get; set; }

        public void Edit(OpenSourceAttachment openSourceAttachment)
        {
            OpenSourceId = openSourceAttachment.OpenSourceId;
            AttachmentId = openSourceAttachment.AttachmentId;
        }
    }
}
