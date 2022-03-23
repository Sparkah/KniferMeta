using UnityEngine;

public class KnifeDetector : MonoBehaviour
{
    [SerializeField] GameObject[] knife;
    private int knifeNum;
    private MainGameUIScript mainGameUIScript;
    private new AudioSource audio;

    private void Start()
    {
        knifeNum = PlayerPrefs.GetInt("knife");
        InstantiateKnife();
        mainGameUIScript = FindObjectOfType<MainGameUIScript>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<KnifeThrower>()!=null && other.GetComponent<KnifeThrower>().enabled==true)
        {
            mainGameUIScript.AddScore();
            InstantiateKnife();
            other.transform.SetParent(this.gameObject.transform);
            other.GetComponent<KnifeThrower>().enabled = false;
            audio.Play();
        }
    }

    private void InstantiateKnife()
    {
        Instantiate(knife[knifeNum], new Vector3(0, -4, 0), Quaternion.Euler(0, 90, 90));
    }
}