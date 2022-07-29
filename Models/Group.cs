namespace RecipeApi.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
