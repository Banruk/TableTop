using Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI;

namespace TableTop.DONOTUSE
{
    public partial class GMPortraits : Portraits_GUI
    {
        /*
        List<GM_Player_Control> players;

        public GMPortraits() : base() { InitializeComponent(); }

        public GMPortraits(MainGUI mainGUI) 
            : base(mainGUI)
        {
            InitializeComponent();
            controller = new GM_GUI_Controller(this);
            players = new List<GM_Player_Control>();
        }


        public class GM_GUI_Controller : Portraits_Controller
        {
            GMPortraits portrait;

            public GM_GUI_Controller(GMPortraits gui) 
            {
                portrait = gui;
            }
            override public void addPortrait(int client_id, CharacterSheet sheet)
            {
                portrait.BeginInvoke((MethodInvoker)delegate
                {
                    GM_Player_Control new_player = new GM_Player_Control(sheet, client_id);
                    portrait.players.Add(new_player);
                    portrait.PortraitPane.Controls.Add(new_player.getPortrait());
                    new_player.getPortrait().Show();
                    portrait.main.Controls.Add(new_player.character.getPortraitPane());
                    new_player.character.getPortraitPane().Hide();
                });
            }

            override public void updateCharacter(int client_id, CharacterSheet updateCharacter)
            {
                foreach (GM_Player_Control player in portrait.players)
                {
                    if (player.client_id == client_id)
                    {
                        portrait.BeginInvoke((MethodInvoker)delegate
                        {
                            player.updatePlayer(updateCharacter);
                        });
                        break;
                    }
                }
            }

            override public void removePortrait(int client_id)
            {
                foreach (GM_Player_Control player in portrait.players)
                {
                    if (player.client_id == client_id)
                    {
                        portrait.Invoke((MethodInvoker)delegate
                        {
                            player.getPortrait().Hide();
                            player.getPortrait().Dispose();
                            portrait.players.Remove(player);
                        });
                        break;
                    }
                }
            }
        }
         */
    }
}
