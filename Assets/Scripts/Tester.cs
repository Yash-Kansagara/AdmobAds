using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {


	void Start () {
		AdManager.instance.Init ();
	}
	
	public void Update(){
		if(Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();
		}
	}
}

