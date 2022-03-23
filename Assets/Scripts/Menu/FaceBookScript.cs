/*using Facebook.Unity;
using UnityEngine;

//FaceBook

    public class FaceBookScript : MonoBehaviour
    {
    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
                {
                    if (FB.IsInitialized)
                        FB.ActivateApp();
                    else
                        Debug.Log("Could not initialize");
                },
                isGameShown =>
                {
                    if (!isGameShown)
                        Time.timeScale = 0;
                    else
                        Time.timeScale = 1;
                });
        }
        else
            FB.ActivateApp();
    }
    public void FaceBookShareLink()
        {

        FB.ShareLink(new System.Uri("https://timapie.ru/games"), "Tim's games", "Game time, all the time",
            new System.Uri("https://www.google.com"));
        }
    }*/