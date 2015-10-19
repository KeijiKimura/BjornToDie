using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleFader : MonoBehaviour {
	
	
	public Text titleText;
	public float fadeSpeed = 5f;
	public bool entrance;
	
	public GameObject titleObject;
	
	void Awake () 
		
	{
		
		titleText = titleObject.GetComponentInChildren<Text> ();
		titleText.color = Color.clear;
		
	}
	
	void Update () 
		
	{
		ColorChange();
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			entrance = true;
		} 
		
	}
	
	void OnTriggerExit2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			entrance = false;                       
			
		} 
		
	}
	
	void ColorChange () 
		
	{
		
		if (entrance)
		{
			titleText.color = Color.Lerp (titleText.color, Color.black, fadeSpeed * Time.deltaTime);
			
		}
		
		if (!entrance)
		{
			titleText.color = Color.Lerp (titleText.color, Color.clear, fadeSpeed * Time.deltaTime);
		}
		
	}
	
}