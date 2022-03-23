using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MetaUI : MonoBehaviour
{
    //0=Menu
    //1=MainGame
    //2=Store
    //3=MetaGame
    [SerializeField] Image StopGameImg;

    public void PauseGame()
    {
        Time.timeScale = 0;
        StopGameImg.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        StopGameImg.gameObject.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
