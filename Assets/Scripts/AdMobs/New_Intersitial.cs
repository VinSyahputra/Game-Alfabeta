using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class New_Intersitial : MonoBehaviour
{
    int scene;
    private InterstitialAd interstitial;
    

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => {});
    }

    public void showInterstitial(){
        RequestInterstitial();
    }

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-9214006915655070/4537488459";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    void Update(){
        if (this.interstitial.IsLoaded()) {
            this.interstitial.Show();
        }
    }

}
