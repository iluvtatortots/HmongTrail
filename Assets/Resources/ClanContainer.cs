using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Collections.Generic;

[XmlRoot("ClanCollection")]
public class ClanContainer {

    [XmlArray("Clans")]
    [XmlArrayItem("Clan")]
    public List<Clan> clans = new List<Clan>();

    public static ClanContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serilizer = new XmlSerializer(typeof(ClanContainer));

        StringReader reader = new StringReader(_xml.text);

        ClanContainer clans = serilizer.Deserialize(reader) as ClanContainer;

        reader.Close();

        return clans;
    }

	
}
