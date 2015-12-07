using CharacterTableTop.GUI.Portrait_Controls;
using CharacterTableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets;
using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI.Portrait_Controls;
using TableTopServer.WCF_Service;

namespace TableTop.GUI
{
    public partial class Portraits : Form
    {
        List<Base_Other_Players> portraits;
        Portraits_Controller controller;
        Character_Form character; // must be changed later
        MainGUI main;

        public Portraits(MainGUI mainGUI)
        {
            InitializeComponent();
            main = mainGUI;
            controller = new Portraits_Controller(this);

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            portraits = new List<Base_Other_Players>();

            if (!main.is_gm)
            {
                character = new Mistborn(); // must be changed later
                PortraitPane.AutoScroll = true;
                PortraitPane.WrapContents = false;

                mainGUI.Controls.Add(character);

                PortraitPane.Controls.Add(character.controller.getPortraitPane());
            }

            character.controller.getPortraitPane().Show();
        }

        public Portraits_Controller getController()
        {
            return controller;
        }

        public class Portraits_Controller
        {
            Portraits portrait;

            public Portraits_Controller(Portraits gui)
            {
                portrait = gui;
            }

            public void addPortrait(int client_id, byte[] new_portrait)
            {
                Other_Player_Portraits new_player = new Other_Player_Portraits(client_id);
                portrait.portraits.Add(new_player);
                portrait.BeginInvoke((MethodInvoker)delegate
                {
                    if (new_portrait != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        new_player.getPortrait().BackColor = Color.Transparent;
                        new_player.getPortrait().BackgroundImage = (Image)converter.ConvertFrom(new_portrait);
                    }
                    portrait.PortraitPane.Controls.Add(new_player.getPortrait());
                    new_player.getPortrait().Show();
                });
            }

            public void updatePortrait(int client_id, byte[] new_portrait)
            {
                portrait.BeginInvoke((MethodInvoker)delegate
                {
                     for(int i =0; i < portrait.portraits.Count; ++i)//Other_Player_Portraits player in portrait.portraits)
                    {
                        if (portrait.portraits[i].client_id == client_id)
                        {
                            ImageConverter converter = new ImageConverter();
                            portrait.portraits[i].getPortrait().BackColor = Color.Transparent;
                            portrait.portraits[i].getPortrait().BackgroundImage = (Image)converter.ConvertFrom(new_portrait);
                        }
                    }
                });
            }

            public void removePortrait(int client_id)
            {
                foreach(Other_Player_Portraits to_remove in portrait.portraits)
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
        } // End Portraits_Controller
    } // End Portraits
}
