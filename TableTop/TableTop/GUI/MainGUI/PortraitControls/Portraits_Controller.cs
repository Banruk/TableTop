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
        /// <summary>
        /// Delegate to add a portrait panel to the UI
        /// </summary>
        public takes_panel add_portrait;
        /// <summary>
        /// Delegate to remove a portrait from the UI
        /// </summary>
        public takes_panel remove_portrait;

        protected List<Base_Other_Players> portraits;

        public Portraits_Controller()
        {
            portraits = new List<Base_Other_Players>();
        }

        /// <summary>
        /// Method to add a new portrait panel to the Portrait's UI
        /// </summary>
        /// <param name="client_id">Client ID for the new portrait</param>
        abstract public void addPortrait(int client_id);

        /// <summary>
        /// Method to update the portrait panel for the given Client ID
        /// </summary>
        /// <param name="client_id">Client ID of the portrait to update</param>
        /// <param name="updateCharacter">Character Sheet of the player to update</param>
        virtual public void updateCharacter(int client_id, CharacterSheet updateCharacter)
        {
            foreach (Base_Other_Players tmp in portraits)
            {
                if (tmp.client_id == client_id)
                {
                    if (updateCharacter == null)
                    {
                        updateCharacter = new CharacterSheet();
                    }
                    tmp.updatePortrait(updateCharacter.portrait);
                    break;
                }
            }
        }

        /// <summary>
        /// Method to delete the portrait panel for the given client ID
        /// </summary>
        /// <param name="client_id">Client ID of the portrait to remove</param>
        virtual public void removePortrait(int client_id)
        {
            foreach (Base_Other_Players tmp in portraits)
            {
                if (tmp.client_id == client_id)
                {
                    remove_portrait(tmp.getPortrait());
                    break;
                }
            }
        } // End removePortrait
    }
}
