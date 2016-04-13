namespace TableTop.GUI.Portrait_Controls
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Portraits_Controller
    {
        public takes_panel add_portrait;
        public takes_panel remove_portrait;

        abstract public void addPortrait(int client_id);

        abstract public void updateCharacter(int client_id, CharacterSheet updateCharacter);

        abstract public void removePortrait(int client_id);
    }
}
