using UnityEngine;
using System.Collections;

public class BaseItem: MonoBehaviour
{
	BaseItemProperties t;
	Inventory inv;

public class BaseItemProperties {
	public string itemname; 
		public string desc;
	protected int 	 count;
	protected bool isStackable;
	protected string type;
	public Sprite mainSprite;
	protected Sprite inGameSprite;
	public Texture Icon;
	protected int damage;
	protected GameObject Projectile;
	protected int range;
	protected int cooldown;
	
	
	public BaseItemProperties(string name, string de,Texture ic,Sprite sp)
		{
			itemname = name;
			desc = de;
			Icon = ic;
			mainSprite = sp;
		}
	
}
	void Start()
	{


	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.name == "Player")
		{
			Destroy(gameObject);
			inv.Inv.Add(t);

			
			
		}
	}
	public void setUp(string name, string desc,Texture icon,Sprite sprite)
	{
	t = new BaseItemProperties(name,desc,icon,sprite);
		inv = GameObject.Find("Player").GetComponent<Inventory>();

	
	}

			
}
