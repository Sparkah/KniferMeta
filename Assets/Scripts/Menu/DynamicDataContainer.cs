using UnityEngine;
using UnityEngine.SceneManagement;

public class DynamicDataContainer : MonoBehaviour
{
    private AudioSource audioMainGameTheme;
    static DynamicDataContainer instance;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        if (FindObjectsOfType<DynamicDataContainer>().Length<=0)
        {
            audioMainGameTheme = GetComponent<AudioSource>();
            audioMainGameTheme.Play();
        }
    }
}