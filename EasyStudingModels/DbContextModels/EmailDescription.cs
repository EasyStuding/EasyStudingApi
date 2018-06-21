namespace EasyStudingModels.DbContextModels
{
    public partial class EmailDescription: IEntity<EmailDescription>
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public bool? IsValidated { get; set; }

        public void Edit(EmailDescription emailDescription)
        {
            Email = emailDescription.Email;
            IsValidated = emailDescription.IsValidated;
        }
    }
}
