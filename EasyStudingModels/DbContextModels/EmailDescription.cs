namespace EasyStudingModels.DbContextModels
{
    public partial class EmailDescription
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public bool? IsValidated { get; set; }
    }
}
