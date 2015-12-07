using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Drawing;

namespace Character
{
    [DataContract]
    public class CharacterSheet
    {
        [DataMember]
        Image portrait;
        [DataMember]
        Image sprite;
        [DataMember]
        String FirstName;
        [DataMember]
        String LastName;
        [DataMember]
        String Age;
        [DataMember]
        String Race;
        [DataMember]
        String gender;
        [DataMember]
        String Weight;
        [DataMember]
        String Height;


        public void SetPortrait(Image new_portrait)
        {
            portrait = new_portrait;
        }

        public Image GetPortrait()
        {
            return portrait;
        }

        public String getCharacterName()
        {
            return FirstName;
        }
    }
}
