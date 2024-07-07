Step1: open visual studio code new terminal
Step2: run cmd  
>dotnet new winforms - o first
Step3: three file editors be created at place of first(editor)here first is a folder been created, With file names
form1.cs
form1designer.cs
program.cs
Step4: we can remove form1.cs and form1designer.cs by right clicking on the file and click delete
Step5: write the program below in program.cs
 
using System.Windows.Forms;  
using System.Drawing;  
namespace First
{
    public class MyForm : Form
    {
        public MyForm()
        {
            InitComponents();
        }
        private void InitComponents()
        {
            ColorDialog dlg = new ColorDialog();
            If(dlg.ShowDialog() == DialogResult.OK)
        {
                this.BackColor = dlg.Color;
            }
            dlg.ShowDialog();
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}
Final step: Save the above program and run command in terminal.
dotnet run --project first