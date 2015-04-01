using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tester : MonoBehaviour {

	public Text text;
	public bool isTestAd;
	public void Init () {
		Debug.Log ("Initializing Admanager with keys\t");
		AdManager.instance.Init ("ca-app-pub-8802518900917873/1068701346",AdManager.BannerPosition.TOP,isTestAd,"ca-app-pub-8802518900917873/9394266546");

	}

	public void loadBanner(){
		AdManager.instance.LoadAndShowBanner ();
	}

	public void showBanner(){
		AdManager.instance.ShowBanner ();
	}

	public void hideBanner(){
		AdManager.instance.HideBanner ();
	}

	public void LoadInterstitial(){
		AdManager.instance.LoadInterstitial ();
		text.text = "Loading...";
		AdManager.instance.onInterstitialLoaded = delegate {
			text.text = "Interstitial Loaded";
		};
	}

	public void ShowInterstitial(){
		AdManager.instance.ShowInterstitial ();
	}
	public void Update(){
		if(Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();
		}
	}
}

