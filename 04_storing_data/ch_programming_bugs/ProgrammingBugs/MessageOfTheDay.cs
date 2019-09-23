using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBugs
{
    public class MessageOfTheDay
    {
        public string ShowMessage()
        {
            string message = "If debugging is the process of removing software bugs, " +
                "then programming must be the process of putting them in.";

            string author = "Edsger Dijkstra";

            // TODO: Add quoted author to the message (on a new line), also prefix author with tab
            string authoredMessage = "";

            Console.WriteLine(authoredMessage);

            // Please dont change the code below (automatic unit tests)
            return authoredMessage;
        }
    }
}
