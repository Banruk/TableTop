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
        String name;
        [DataMember]
        Image portrait;
        [DataMember]
        String race;
        [DataMember]
        String gender;

    }
}
