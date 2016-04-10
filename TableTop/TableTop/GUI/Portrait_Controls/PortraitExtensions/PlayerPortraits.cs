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
using TableTop.GUI.CharacterForms;

namespace TableTop.GUI.Portrait_Controls.PortraitExtensions
{
    public partial class PlayerPortraits : Portraits
    {
        protected List<Base_Other_Players> portraits;
        protected Character_Form_Driver character_driver; 

        public PlayerPortraits()
            :base()
        {
            InitializeComponent();
        }

        public PlayerPortraits(MainGUI mainGUI)
            : base(mainGUI)
        {
            InitializeComponent();
            controller = new Player_GUI_Controller(this);
            portraits = new List<Base_Other_Players>();

            //character_driver = CharacterFormFactory.formFactory(MainGUI.gameMode);
            character_driver = new Character_Form_Driver(MainGUI.gameMode);

            mainGUI.Controls.Add(character_driver.getCharacterForm());

            PortraitPane.Controls.Add(character_driver.getPortraitPane());
            character_driver.getPortraitPane().Show();
        }


        public class Player_GUI_Controller : Portraits_Controller
        {
            private PlayerPortraits portrait;

            public Player_GUI_Controller(PlayerPortraits gui)
            {
                portrait = gui;
            }

            override public void addPortrait(int client_id, CharacterSheet sheet)
            {
                Other_Player_Portraits new_player = new Other_Player_Portraits(client_id);
                portrait.portraits.Add(new_player);
                portrait.BeginInvoke((MethodInvoker)delegate
                {
                    if (sheet != null && sheet.portrait != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        new_player.getPortrait().BackColor = Color.Transparent;
                        new_player.getPortrait().BackgroundImage = sheet.portrait;
                    }
                    portrait.PortraitPane.Controls.Add(new_player.getPortrait());
                    new_player.getPortrait().Show();
                });
            }

            override public void updateCharacter(int client_id, CharacterSheet updateCharacter)
            {
                portrait.BeginInvoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < portrait.portraits.Count; ++i)//Other_Player_Portraits player in portrait.portraits)
                    {
                        if (portrait.portraits[i].client_id == client_id)
                        {
                            ImageConverter converter = new ImageConverter();
                            portrait.portraits[i].getPortrait().BackColor = Color.Transparent;
                            portrait.portraits[i].getPortrait().BackgroundImage = updateCharacter.portrait;
                            break;
                        }
                    }
                });
            }

            override public void removePortrait(int client_id)
            {
                foreach (Other_Player_Portraits to_remove in portrait.portraits)
                {
                    if (to_remove.client_id == client_id)
                    {
                        portrait.Invoke((MethodInvoker)delegate
                        {
                            to_remove.getPortrait().Hide();
                            to_remove.getPortrait().Dispose();
                            portrait.portraits.Remove(to_remove);
                        });
                        break;
                    }
                }
            } // End removePortrait
        }
    }
}
