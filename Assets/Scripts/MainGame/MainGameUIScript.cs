using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainGameUIScript : MonoBehaviour
{
    //0=Menu
    //1=MainGame
    //2=Store
    //3=MetaGame

    [SerializeField] Image pauseImg;
    [SerializeField] Button pauseBtn;
    [SerializeField] TextMeshProUGUI score;
    private int scoreCounter =0;

    //
    private int knifesTillNextLevel = 3;
    [SerializeField] TextMeshProUGUI knifesLeftToWin;


    private void Start()
    {
        knifesTillNextLevel = 3 + PlayerPrefs.GetInt("KnifeAmount");
        GetKnifesTillNextLevelCount();
    }

    public void MainMenu()
    {
        int oldScore = PlayerPrefs.GetInt("score");
        if (scoreCounter > oldScore)
            PlayerPrefs.SetInt("score", scoreCounter);

        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        pauseBtn.gameObject.SetActive(false);
        pauseImg.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseBtn.gameObject.SetActive(true);
        pauseImg.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void AddScore()
    {
        scoreCounter += 1;
        score.text = "Счет: " + scoreCounter.ToString();
        ReduceKnifesTillNextLevel();
    }

    //Усложнение геймплея
    public void NextLevel()
    {
        PlayerPrefs.SetInt("KnifeAmount", PlayerPrefs.GetInt("KnifeAmount")+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GetKnifesTillNextLevelCount()
    {
        knifesLeftToWin.text = "Осталось воткнуть до следующего уровня: " + knifesTillNextLevel;
        if(knifesTillNextLevel==0)
        {
            NextLevel();
        }
    }

    public void ReduceKnifesTillNextLevel()
    {
        --knifesTillNextLevel;
        GetKnifesTillNextLevelCount();
    }
}