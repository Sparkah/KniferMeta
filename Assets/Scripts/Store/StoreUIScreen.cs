using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class StoreUIScreen : MonoBehaviour
{
    //0=Menu
    //1=MainGame
    //2=Store
    //3=MetaGame

    [SerializeField] TextMeshProUGUI[] knifes;
    private int knifeNum;

    private void Start()
    {
        EquipKnife();
    }

    private void EquipKnife()
    {
        knifeNum = PlayerPrefs.GetInt("knife");
        knifes[knifeNum].text = "Надето";
    }

    public void ChooseKnife(int knife)
    {
        knifes[knifeNum].text = "Надеть";
        knifeNum = knife;
        PlayerPrefs.SetInt("knife", knifeNum);
        EquipKnife();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
