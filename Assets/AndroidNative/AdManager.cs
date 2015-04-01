using UnityEngine;
using System.Collections;

public class AdManager : MonoBehaviour {


	public bool _isTestAd;


	private static AdManager _instance;
	public static AdManager instance{
		get{
			if(_instance == null){
				GameObject g = new GameObject("AdManager");
				_instance = g.AddComponent<AdManager>();
				DontDestroyOnLoad(g);
			}
			return _instance;
		}
	}

	private string _bannerID; 
	private string _interstitialID;
	public enum BannerPosition
	{
		TOP,
		BOTTOM
	}
	public BannerPosition bannerposition;

	// Interstitial : ca-app-pub-8802518900917873/9394266546
	// Banner : 

	public void Init(string bannerID,BannerPosition bannerPosition,bool isTestAd,string interstitialID = null){
		_bannerID = bannerID;
		bannerposition = bannerPosition;
		if(interstitialID != null)
			_interstitialID = interstitialID;
		_isTestAd = isTestAd;

		AndroidNative.hook.SetStatic<bool> ("isTestAd", _isTestAd);
	}

	/// <summary>
	/// Loads and shows the banner.
	/// </summary>
	public void LoadAndShowBanner(){

		AndroidNative.hook.CallStatic ("LoadBannerAd", new object[]{_bannerID,bannerposition.ToString()});
	}

	/// <summary>
	/// Hides the banner.
	/// </summary>
	public void HideBanner(){
		AndroidNative.hook.CallStatic ("HideBannerAd");
	}

	/// <summary>
	/// Shows the banner.
	/// Used after calling HideBanner() to show banner without loading again
	/// </summary>
	public void ShowBanner(){
		AndroidNative.hook.CallStatic ("ShowBannerAd");
	}

	/// <summary>
	/// Destroies the banner.
	/// </summary>
	public void DestroyBanner(){
		AndroidNative.hook.CallStatic ("DestroyBannerAd");
	}

	/// <summary>
	/// Loads the interstitial.
	/// </summary>
	public void LoadInterstitial(){
		
		AndroidNative.hook.CallStatic ("LoadInterstitial", new object[]{_interstitialID});
	}

	/// <summary>
	/// Shows the interstitial.
	/// </summary>
	public void ShowInterstitial(){
		
		AndroidNative.hook.CallStatic ("ShowInterstitial");
	}

	/// <summary>
	/// Interstitial loaded. Called from Native Android
	/// </summary>
	public void InterstitialLoaded(){
		if(onInterstitialLoaded != null){
			onInterstitialLoaded();
		}
	}

	public delegate void OnInterstitialLoaded();
	public OnInterstitialLoaded onInterstitialLoaded;

}
