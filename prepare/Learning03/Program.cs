using System;

class Program
{
    public class Job {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display() {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    public class Resume {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void Display() {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");
            foreach (Job job in _jobs) {
                job.Display();
            }
        }
    }

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Seth Chen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}