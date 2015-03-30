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
		RequestBanner ();
	}

	private void RequestBanner()
	{
		AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject hook = new AndroidJavaObject ("com.yash.ads.hook", new object[]{activity});
//		activity.Call("runOnUiThread",new object[]{initializer});

		hook.CallStatic("LoadBannerAd",new object[]{"ca-app-pub-8802518900917873/1068701346","TOP"});
	}

}
