using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIScript : MonoBehaviour
{
    //0=Menu
    //1=MainGame
    //2=Store
    //3=MetaGame
    [SerializeField] TextMeshProUGUI highScore;

    private void Start()
    {
        highScore.text = "Ваш рекорд: " + PlayerPrefs.GetInt("score").ToString();
    }

    public void StartMainGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Store()
    {
        SceneManager.LoadScene(2);
    }

    public void StartMetaGame()
    {
        SceneManager.LoadScene(3);
    }
}