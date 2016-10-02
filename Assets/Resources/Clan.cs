using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;



public class Clan {

    [XmlElement("Label")]
    public string label;

    [XmlAttribute("Id")]
    public string id;

}
