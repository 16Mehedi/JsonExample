public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string UserType { get; set; }
}

public class AdminUser : User
{
    public string AdminLevel { get; set; }
}

public class RegularUser : User
{
    public string SubscriptionType { get; set; }
}
