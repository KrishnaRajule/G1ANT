using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.MyAddon2
{
    [Command(Name = "show", Tooltip = "This is a demo command")]
    class MyCommand : Command
    {
        public MyCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : CommandArguments
        {
            [Argument(Name = "text", Required = true, Tooltip = "Type text to display")]
            public TextStructure text { get; set; } = new TextStructure();
        }
        public void Execute(Arguments argument)
        {
            RobotMessageBox.Show(argument.text.Value);
        }
    }
}
