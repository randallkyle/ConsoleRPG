using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Views
{
    class PlayerViewer : ConsoleViewer
    {
        public static void View()
        {
            PlayerViewer.View("Player Name: " + Player.ThePlayer.Name + "; Player Level: " + Player.ThePlayer.Level);
        }
    }
}
