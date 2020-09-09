using System;
using System.Collections.Generic;
using System.Text;

namespace programming_guide_classes_and_structs
{
    public class WorkItem
    {
        private static int currentID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan JobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Default Title";
            Description = "Default Description";
            JobLength = new TimeSpan();
        }

        public WorkItem(string title, string description, TimeSpan joblength)
        {
            this.ID = GetNext();
            this.Title = title;
            this.Description = description;
            this.JobLength = joblength;
        }

        static WorkItem() => currentID = 0;

        protected int GetNext() => ++currentID;
        /*
        protected int GetNext()
        {
            return ++currentID;
        }
        */

        public void Update(string title, TimeSpan joblength)
        {
            this.Title = title;
            this.JobLength = joblength;
        }

        public override string ToString() => $"{this.ID}-{this.Title}-{this.JobLength}";


    }

    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        public ChangeRequest()
        { 
        }

        public ChangeRequest(string title, string description, TimeSpan joblength,int originalID)
        {
            this.ID = GetNext();
            this.Title = title;
            this.Description = description;
            this.JobLength = joblength;

            this.originalItemID = originalID;
        }
    }

    public class Program04
    {
        static void Main()
        {
            WorkItem item = new WorkItem("Fix Bugs", "Fix all bugs in my code branch", new TimeSpan(3, 4, 0, 0));
            ChangeRequest change = new ChangeRequest("Change Base Class Design", "Add members to the class",new TimeSpan(4, 0, 0), 1);

            Console.WriteLine(item.ToString());

            change.Update("Change the Design of the Base Class", new TimeSpan(3, 0, 0));
            Console.WriteLine(change.ToString());

        }
    }

}
