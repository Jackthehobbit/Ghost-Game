using UnityEngine;
using System.Collections;

public class Roller : BaseItem {
	public Texture Icon;
	public Sprite sprite;
	void Start () {
		base.setUp("Roller","A Roller",Icon,sprite);
	
		}
}