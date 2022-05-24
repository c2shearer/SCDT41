using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public static List<Issue> IssueList = new List<Issue>();

        public Issue(string Description)
        {
            Id = Guid.NewGuid();
            this.Description = Description;
            Date = DateTime.Now;
        }

        public static void Raise()
        {
            Console.WriteLine("Issue Description");
            string descripton = Console.ReadLine();
            IssueList.Add(new Issue(descripton));
        }

        public static void IssueRaised()
        {
            int x = 0;
            foreach(Issue issue in IssueList)
            {
                Console.WriteLine(issue);
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Enter Issue GUID: ");
            string issueId = Console.ReadLine();
            var toRemove = IssueList.SingleOrDefault(r => Convert.ToString(r.Id) == issueId);
            if (toRemove != null)
                IssueList.Remove(toRemove);
            else
                Console.WriteLine("Issue Not Found");
        }

        public override string ToString()
        {
            return $"Issue - {Id}: {Description}\nRaised on: {Date}";
        }
    }
}
