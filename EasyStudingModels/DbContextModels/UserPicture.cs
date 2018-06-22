namespace EasyStudingModels.DbContextModels
{
    public partial class UserPicture: IEntity<UserPicture>
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public string Ref { get; set; }

        public void Edit(UserPicture userPicture)
        {
            UserInformationId = userPicture.UserInformationId;
            Ref = userPicture.Ref;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserInformationId >= 0
                && !string.IsNullOrWhiteSpace(Ref);
        }
    }
}
