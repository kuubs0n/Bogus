namespace BogusExample;

public record User
{
    public Guid Id { get; set; }
    public string FirstName  { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public bool IsActivated { get; set; }
}