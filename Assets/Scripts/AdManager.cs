using UnityEngine;
using System.Collections;

public class AdManager : MonoBehaviour {

	private static AdManager _instance;
	public static AdManager instance{
		get{
			if(_instance == null){
				GameObject g = new GameObject("AdManager");
				_instance = g.AddComponent<AdManager>();
			}
			return _instance;
		}
	}

	public void Init(){

	}
}
