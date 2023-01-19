public class Job
{
    public string _jobTitle;
    public string _jobCompany;
    public int _jobStartYear;
    public int _jobEndYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobStartYear}-{_jobEndYear}");
    }
}