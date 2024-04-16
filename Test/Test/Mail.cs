using System.Collections.Generic;

public interface IEmailList
{
    bool Contains(string email);
    void Add(string email);
}

public class EmailList : IEmailList
{
    private List<string> _emails = new List<string>();

    public bool Contains(string email)
    {
        return _emails.Contains(email);
    }

    public void Add(string email)
    {
        _emails.Add(email);
    }
}
