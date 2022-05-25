using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Issue
    {
        // Properties of Issue
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        // List to hold all Issues
        public static List<Issue> IssueList = new List<Issue>();

        // Constructor to initiate new Issue
        public Issue(string Description)
        {
            Id = Guid.NewGuid();
            this.Description = Description;
            Date = DateTime.Now;
        }

        // Get details of Issue to be documented
        public static void Raise()
        {
            Console.WriteLine("Issue Description");
            string descripton = Console.ReadLine();
            IssueList.Add(new Issue(descripton));
        }

        // Loop through entire Issue List
        public static void IssueRaised()
        {
            int x = 0;
            foreach(Issue issue in IssueList)
            {
                Console.WriteLine(issue);
            }
        }

        // Remove Issue from List
        public static void Delete()
        {
            Console.WriteLine("Enter Issue GUID: ");
            string issueId = Console.ReadLine();
            // Filter List to find ID of Issue
            var toRemove = IssueList.SingleOrDefault(r => Convert.ToString(r.Id) == issueId);
            if (toRemove != null)
                IssueList.Remove(toRemove);
            else
                Console.WriteLine("Issue Not Found");
        }

        // Custom Output
        public override string ToString()
        {
            return $"Issue - {Id}: {Description}\nRaised on: {Date}";
        }
    }
}
