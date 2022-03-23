using System.Collections;
using UnityEngine;

public class KnifeKnifeCollisionDetector : MonoBehaviour
{
    //0=Menu
    //1=MainGame
    //2=Store
    //3=MetaGame

    private MainGameUIScript mainGameUIScript;
    private new AudioSource audio;
    private bool hasPlayed = false;

    private void Start()
    {
        mainGameUIScript = FindObjectOfType<MainGameUIScript>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<KnifeThrower>()!=null)
        {
            this.GetComponentInParent<KnifeThrower>().enabled = false;
            if (!hasPlayed)
            {
                audio.Play();
            }
            hasPlayed = true;
            EndGame();
        }
    }

    IEnumerator EndGameCoroutine()
    {
        yield return new WaitForSeconds(1f);
        mainGameUIScript.MainMenu();
    }
    private void EndGame()
    {
        StartCoroutine(EndGameCoroutine());
    }
}