using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public   class Inventory : BaseItem{


	public List<BaseItemProperties> Inv = new List<BaseItemProperties>();

	Rect Backpack = new Rect(0,0,500,500);
	Rect Display = new Rect(20,20,200,200);
	Rect NameLabel = new Rect(230,40,200,50);
	Rect DescLabel = new Rect(230,60,200,50);
	Rect Equip = new Rect(20,230,100,50);
	Rect Trash = new Rect(140,230,100,50);
	string CurrentName;
	string CurrentDesc;
	Texture DisplayIcon;
	Rect[] InvButtons = new Rect[24];
	public GUISkin testing;
	SpriteRenderer arm;
	int maxSize = 24;
	int xval;
	int yval;
	int index;
	bool itemSelected;
	BaseItemProperties  equipped;


	// Use this for initialization
	void Start () {
		setButtons();
		arm = GameObject.Find("Arm").GetComponent<SpriteRenderer>();


	}
	void Update(){
		if(!PlayerInput.Inventory)
		{
			DisplayIcon = null;
			CurrentDesc= null;
			CurrentName = null;
			itemSelected = false;
		}
	
		

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
		GUI.Box(Display,DisplayIcon);
			
			GUI.Label(NameLabel,"Name: "+CurrentName);
			GUI.Label(DescLabel,"Description: "+CurrentDesc);
			if(GUI.Button(Equip,"Equip"))
		{
			if(itemSelected)
			{
				arm.sprite = Inv[index].mainSprite;
				equipped = Inv[index];

			}
		}
			
		if(GUI.Button (Trash,"Trash"))
		{
			
			if(itemSelected)
			{
				if(equipped == Inv[index])
					arm.sprite = null;
				Inv.RemoveAt(index);
				DisplayIcon = null;
				CurrentDesc= null;
				CurrentName = null;
				itemSelected = false;

				
				
			}
		}	
		for(int i = 0; i < maxSize;i++)
		{	
		
			if(i+1 > Inv.Count)
			{
				GUI.Button(InvButtons[i],i.ToString());
			}
			else
			{
			if(GUI.Button(InvButtons[i],Inv[i].Icon))
			   {
				
					DisplayIcon = Inv[i].Icon;
					CurrentName = Inv[i].itemname;
					CurrentDesc = Inv[i].desc;
					index = i;
					itemSelected = true;

				}
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

		
		InvButtons[0] = new Rect(10,290,50,50);
		InvButtons[1] = new Rect(70,290,50,50);
		InvButtons[2] = new Rect(130,290,50,50);
		InvButtons[3] = new Rect(190,290,50,50);
		InvButtons[4] = new Rect(250,290,50,50);
		InvButtons[5] = new Rect(310,290,50,50);
		InvButtons[6] = new Rect(370,290,50,50);
		InvButtons[7]= new Rect(430,290,50,50);
		InvButtons[8] = new Rect(10,350,50,50);
		InvButtons[9] = new Rect(70,350,50,50);
		InvButtons[10] = new Rect(130,350,50,50);
		InvButtons[11] = new Rect(190,350,50,50);
		InvButtons[12] = new Rect(250,350,50,50);
		InvButtons[13] = new Rect(310,350,50,50);
		InvButtons[14] = new Rect(370,350,50,50);
		InvButtons[15]= new Rect(430,350,50,50);
		InvButtons[16] = new Rect(10,410,50,50);
		InvButtons[17] = new Rect(70,410,50,50);
		InvButtons[18] = new Rect(130,410,50,50);
		InvButtons[19] = new Rect(190,410,50,50);
		InvButtons[20] = new Rect(250,410,50,50);
		InvButtons[21] = new Rect(310,410,50,50);
		InvButtons[22] = new Rect(370,410,50,50);
		InvButtons[23]= new Rect(430,410,50,50);




	}

}
