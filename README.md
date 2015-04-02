### Installing
Download [UnityPackage](https://github.com/Yash-Kansagara/AdmobUnityPackage/archive/master.zip) and import the package.

### Demo Unity Project
A demo unity project can be found [HERE](https://github.com/Yash-Kansagara/AdmobAds)

### Documantation

**AdManager.instance.Init ( bannerID, position, isTestAd, interstitialID )**  
bannerID : banner ad id  
position : TOP / BOTTOM  
isTestAd : if true, loads test ads.  
interstitialID : interstitial ad id  
`AdManager.instance.Init ( "bannerID", AdManager.BannerPosition.TOP, true, "interstitialID" );`  


**AdManager.instance.LoadAndShowBanner ()**  
Loads and shows the banner Ad at position defined in Init function.  
`AdManager.instance.LoadAndShowBanner ();`  


**AdManager.instance.HideBanner()**  
Hides the banner ad.  Useful when you want to hide ad during some area of game.  
`AdManager.instance.HideBanner();`  


**AdManager.instance.ShowBanner()**  
Use it after calling `HideBanner()` function.  
Used to show it again on screen if hidden.  
`AdManager.instance.ShowBanner();`  
_This function do not **Load** the ad, to show banner initially call `LoadAndShowBanner();`._  


**AdManager.instance.LoadInterstitial ();**
Loads the interstitialAd  
to show  use `ShowInterstitial();`  
`AdManager.instance.LoadInterstitial ();`  


**AdManager.instance.ShowInterstitial ();**
Shows the interstitialAd.    
`AdManager.instance.ShowInterstitial ();`  
_interstitial must be loaded first to show proper ad  
use `LoadInterstitial ();` to load the ad.  


**AdManager.instance.onInterstitialLoaded**  
This delegate is called when interstitial is loaded successfully.  
`AdManager.instance.onInterstitialLoaded = delegate { Debug.Log("Interstitial Loaded");	};`  

### Eclipse project
Ecliplse project of this plugin is [here](https://github.com/Yash-Kansagara/AdmobAdsEclipseProject)