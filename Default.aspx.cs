using System;
using System.Threading;
using System.Web;
using System.Web.UI;

namespace threaddemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThreadStart childThreadStart = new ThreadStart(ChildThreadCall);
            Response.Write("Child Thread Started <br/>");

            Thread childThread = new Thread(childThreadStart);
            childThread.Start();

            Response.Write("Main sleeping for 2 seconds. <br/>");
            Thread.Sleep(2000);

            Response.Write("<br/>Main aborting child thread<br/>");
            childThread.Abort();
        }

        public void ChildThreadCall()
        {
            Response.Write("We are in");

            try
            {
                Response.Write("<br />Child thread started <br/>");
                Response.Write("Child Thread: Counting to 10");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Response.Write("<br/> in Child thread </br>");
                }

                Response.Write("<br/> child thread finished");
            }
            catch (ThreadAbortException e)
            {
                Response.Write("<br /> child thread - exception");
            }
            finally
            {
                Response.Write("<br /> child thread - unable to catch the exception");
            }
        }
    }
}
