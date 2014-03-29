using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public   class Inventory : BaseItem{


	public List<BaseItemProperties> Inv = new List<BaseItemProperties>();

	Rect Backpack = new Rect(0,0,500,500);
	Rect[] InvButtons = new Rect[4];
	public GUISkin testing;
	SpriteRenderer arm;



	// Use this for initialization
	void Start () {
		setButtons();
		arm = GameObject.Find("Arm").GetComponent<SpriteRenderer>();


	}
	void Update(){

	
		

	}
	// Update is called once per frame
	void OnGUI()
	{
		GUI.skin = testing;
		if(PlayerInput.Inventory)
		{

			Backpack= ClamptoScreen(GUI.Window(0,Backpack,invBox,"Inventory"));
		
		}

	}
	void invBox(int windowID)
	{		

		for(int i = 0; i < Inv.Count;i++)
		{	
			if(GUI.Button(InvButtons[i],Inv[i].Icon))
			   {
				arm.sprite = Inv[i].mainSprite;
				}
			}

		GUI.DragWindow();

	}
	Rect ClamptoScreen(Rect R)
	{
		R.x = Mathf.Clamp(R.x,0,Screen.width-R.width);
			R.y = Mathf.Clamp(R.y,0,Screen.height-R.height);
		return R;
	}
	void setButtons()
	{
		InvButtons[0] = new Rect(10,10,50,50);
		InvButtons[1] = new Rect(10,70,50,50);
		InvButtons[2] = new Rect(10,130,50,50);
		InvButtons[3] = new Rect(10,190,50,50);

	}

}
