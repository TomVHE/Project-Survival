//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	//health test related stuff
	public float maxHP;
	public float health;
	private float healthPercentage;
	public float dmg;
	public Image healthBar;


	//all menu items
	public List<RectTransform> allMenuItems = new List<RectTransform>();
	public RectTransform mainMenu, pauseMenu; //gonna add more to these 
	public enum UIState {MainMenu, Ingame};
	public UIState _UIState;
	public KeyCode key;


	//sets some things ready
	void Awake () 
	{	
		maxHP = 100;
		health = maxHP;
	}
	//for testing purposes
	void Update () 
	{
		if(Input.GetKeyDown(key))
		{
			health -= dmg;
		}
		CheckHealth();
	}
	void CheckUIState () 
	{
		switch (_UIState)
        {
        case UIState.MainMenu:

            
            break;

        case UIState.Ingame:

            
            break;
        }
	}
	void SetState (UIState state)
	{
		_UIState = state;
		CheckUIState();
	}
	//receives items and will make a list of them that will get send to another function
	 public void EnableMenuItems(RectTransform item)
    {
        List<RectTransform> items = new List<RectTransform>() { item };
        EnableMenuItems(items);
    }
    //gets a list that will in which the objects will get set true after everything is set false
    public void EnableMenuItems(List<RectTransform> items)
    {
        foreach (RectTransform rT in allMenuItems)
            rT.gameObject.SetActive(false);
        foreach (RectTransform rT in items)
            rT.gameObject.SetActive(true);
    }
	//checks health and updates ui
	public void CheckHealth () //needs overload so it can receive health or take damage
	{
		//get a percentage of health, because fillamount is between 1 and 0
		healthPercentage = health / maxHP;
		Debug.Log(healthPercentage);
		healthBar.fillAmount = healthPercentage;
	}
	//checks ammo and updates ui    	NOT MADE YET
	public void CheckAmmo () //needs overload so it can receive health or damage
	{

	}
}
