using UnityEngine;
using System.Collections;

public class AndroidNative : MonoBehaviour {

	public static readonly string className = "com.yash.ads.hook";

	/// <summary>
	/// Cached Native activity of unity android player
	/// </summary>
	public static AndroidJavaObject activity{
		get{
			if(_activity == null){
				AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
				_activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
			}
			return _activity;
		}
	}
	private static AndroidJavaObject _activity;

	/// <summary>
	/// Cached Native java Object to call other functions on ui thread
	/// </summary>
	public static AndroidJavaObject hook{
		get{
			if(_osHook == null){	
				_osHook = new AndroidJavaObject (className, new object[]{activity});
			}
			return _osHook;
		}
	}
	private static AndroidJavaObject _osHook;
}
