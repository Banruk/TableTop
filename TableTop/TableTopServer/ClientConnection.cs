using Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopServer.WCF_Service;

namespace TableTopServer
{
    public class ClientConnection
    {
        static int last_used_id = 0;

        Client_WCF_Interface client_connection;
        CharacterSheet characterSheet;
        public byte[] portrait
        {
            get;
            set;
        }
        public byte[] sprite
        {
            get;
            set;
        }

        public int client_id
        {
            get;
            private set;
        }

        public ClientConnection(Client_WCF_Interface connection)
        {
            client_connection = connection;
            client_id = last_used_id++;
            portrait = null;
            sprite = null;
        }

        public Client_WCF_Interface getConnection()
        {
            return client_connection;
        }

        public void setCharacterSheet(CharacterSheet characterSheet)
        {
            this.characterSheet = characterSheet;
        }

        public CharacterSheet getCharacterSheet()
        {
            return characterSheet;
        }
    }
}
