namespace EasyStudingModels.Models
{
    public class UserPassword: IEntity<UserPassword>
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Password { get; set; }

        public void Edit(UserPassword userPassword)
        {
            Password = userPassword.Password;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserId >= 0
                && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
