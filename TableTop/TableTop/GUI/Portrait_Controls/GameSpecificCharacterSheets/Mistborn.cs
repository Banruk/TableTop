using Character;
using Character.GameSpecificCharacterSheets.Mistborn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTopServer.WCF_Service;

namespace CharacterTableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets
{

    public partial class Mistborn : Character_Form
    {
        public Mistborn()
            :base()
        {
            InitializeComponent();

            controller = new Mistborn_Handler(this);
            character_sheet = new Mistborn_CharacterSheet();
            initialize();
            buildPortraitPane();
            Visible = true;
            Hide();
        }

        public Mistborn(CharacterSheet sheet)
        {
            controller = new Mistborn_Handler(this);
            character_sheet = new Mistborn_CharacterSheet();
            initialize();
            buildPortraitPane();
            Visible = true;
            Hide();

            loadFromCharactersheet(sheet);
        }

        public class Mistborn_Handler : Character_Form.Character_Form_Controller
        {
            public Mistborn_Handler(Mistborn mistborn)
                : base(mistborn)
            {
                
            }
        }
    }
}
