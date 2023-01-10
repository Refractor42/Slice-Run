using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class AdmobScript : MonoBehaviour
{
    private BannerView bannerView;
    GameObject BannerFrame;
    public ObjectSelector objSelector;
    public UIControls UIController;
    public Score ScoreScript;

    public GameObject Audio0;
    public GameObject Audio1;
    public GameObject Audio2;
    public GameObject Audio3;

    private RewardBasedVideoAd adReward;

    private string idApp, idReward;

    [SerializeField] Button BtnReward;
    


   // private RewardedAd rewardedAd;

    public void Start()
    {

        DontDestroyOnLoad(this);

        // string appId = "ca-app-pub-7947214955841762~8239654384";

       // idApp = "ca-app-pub-7947214955841762~8239654384";
        idReward = "ca-app-pub-3940256099942544/5224354917";

        adReward = RewardBasedVideoAd.Instance;
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => {});

       // this.RequestBanner();

        //this.rewardedAd = new RewardedAd("ca - app - pub - 3940256099942544 / 5224354917");
        // this.RequestInterstitial();
        // Create an empty ad request.
       // AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
       // this.rewardedAd.LoadAd(request);

     
    }

  /*  private void RequestBanner()
    {

        string bannerAd = "ca-app-pub-3940256099942544/6300978111";

        BannerView bannerView = new BannerView(bannerAd, AdSize.Banner, 430, 324 );
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);


    }
    */
    private InterstitialAd interstitial;

    private void RequestInterstitial()
    {


        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

        //You can't have 2 ads at the same time ma man
        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);



    }
    public void ShowInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        else
        {
            MonoBehaviour.print("Interstitial is not ready yet");
        }
    }


   
 

    public void RewardIt()
    {
        /* string type = args.Type;
         double amount = args.Amount;
         MonoBehaviour.print(
             "HandleRewardedAdRewarded event received for "
                         + amount.ToString() + " " + type);*/
        Debug.Log("GiveTheReward");
        UIController.Invoke("HideRevive", 0f);
        ScoreScript.Invoke("ReviveScore", 0f);

        objSelector.Invoke("Revive", 0f);
    }

  
   
    
    
    public void OnRewardedAdClicked()
    {
        Debug.Log("TextIsChanging");
        BtnReward.interactable = false;
        BtnReward.GetComponentInChildren<TextMeshProUGUI>().text = "Loading...";
        
        Debug.Log("TextChanged");
    }
 
}