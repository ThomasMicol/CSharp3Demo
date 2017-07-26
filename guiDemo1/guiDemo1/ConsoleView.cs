
using System.Windows.Forms;

namespace guiDemo1
{
    internal class ConsoleView : IView
    {
        public ConsoleView()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}