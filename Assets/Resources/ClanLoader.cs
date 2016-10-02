using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClanLoader : MonoBehaviour {

    public const string path = "Clans";

    public Dropdown drop;

    public Text text;

    public UnityEvent onSelect;
  
	// Use this for initialization
	void Start () {

        ClanContainer cc = ClanContainer.Load(path);

        foreach (Clan c in cc.clans){
            Dropdown.OptionData list = new Dropdown.OptionData(c.label);
            drop.options.Add(list);
            
        }

        text.text = cc.clans[0].label;
	}



}
