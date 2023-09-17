using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class reklam : MonoBehaviour
{
    private static reklam instance;
    private BannerView bannerView;
    private InterstitialAd Interstitial;
    

    void Start()
    {
        MobileAds.Initialize(InitStatus => { });
        this.RequestBanner();
        this.RequestInterstitial();
    }

    public async void reklamgosterAsync()
    {
        SceneManager.LoadScene("ins");
        await Task.Delay(100);
        this.Interstitial.Show();

    }
    private void Awake() {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Singleton nesneyi ayarla ve sahneler arasında yok etme
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void RequestBanner()
    {

        string reklamID = "ca-app-pub-1664062912484400/2812075916";

        this.bannerView = new BannerView(reklamID, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }

    void RequestInterstitial()
    {

        string reklamID = "ca-app-pub-1664062912484400/4513020451";

        this.Interstitial = new InterstitialAd(reklamID);
        AdRequest request = new AdRequest.Builder().Build();
        this.Interstitial.LoadAd(request);
    }
}
