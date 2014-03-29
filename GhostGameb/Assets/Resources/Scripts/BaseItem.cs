using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {
	public string itemname; 
		public string desc;
	protected int 	 count;
	protected bool isStackable;
	protected string type;
	protected Sprite mainSprite;
	protected Sprite inGameSprite;
	public Texture2D Icon;
	protected int damage;
	protected GameObject Projectile;
	protected int range;
	protected int cooldown;
	//protected Inventory inv;
	BaseItem test;
	// Use this for initialization


		 

		

	void Update()
	{

	}
	void Attack()
	{

	}
	void	Fire()
	{

	}

	void Use()
	{

	}

	 protected void pickUp()
	{

		Destroy(gameObject);
		print(itemname);
			print (desc);

	}
}
