using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Drawing;
using System.Xml.Serialization;
using Character.GameSpecificCharacterSheets.Mistborn;

namespace Character
{
    [DataContract]
    [KnownType(typeof(Mistborn_CharacterSheet))]
    public class CharacterSheet
    {
        [DataMember]
        public byte[] portrait_bytes
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(portrait, typeof(byte[]));
            }
            set
            {
                ImageConverter converter = new ImageConverter();
                portrait = (Image)converter.ConvertFrom(value);
            }
        }
        [XmlIgnore]
        public Image portrait;

        [DataMember]
        public byte[] sprite_bytes
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(sprite, typeof(byte[]));
            }
            set
            {
                if (value != null && value.Count() > 1)
                {
                    ImageConverter converter = new ImageConverter();
                    sprite = (Image)converter.ConvertFrom(value);
                }
            }
        }
        [XmlIgnore]
        public Image sprite;

        [DataMember]
        public String FirstName;
        [DataMember]
        public String LastName;
        [DataMember]
        public String Age;
        [DataMember]
        public String Race;
        [DataMember]
        public String Gender;
        [DataMember]
        public String Weight;
        [DataMember]
        public String Height;
        [DataMember]
        public String Description;


        public String getFirstName()
        {
            return FirstName;
        }
    }
}
