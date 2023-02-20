using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Banner : MonoBehaviour
{
    private BannerView bannerView;

    // Start is called before the first frame update
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        // Create a 320x50 banner ad at coordinate (0,50) on screen.
        this.RequestBanner();
    }

    private void RequestBanner()
    {

        string adUnitId = "ca-app-pub-9214006915655070/5838676429";

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
