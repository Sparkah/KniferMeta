using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGameHarder : MonoBehaviour
{
    private int hardValue;
    [SerializeField] GameObject Stones;
    [SerializeField] GameObject[] StonePositions;

    void Start()
    {
        hardValue = Random.Range(1, PlayerPrefs.GetInt("KnifeAmount"));
        for (int i = 0; i < hardValue; i++)
        {
            GameObject Stone = Instantiate(Stones, new Vector3(0,0,0), Quaternion.identity, gameObject.transform);
            Stone.transform.localScale = new Vector3(0.25f, 0.25f, 1);
            Stone.transform.position = StonePositions[Random.Range(0, StonePositions.Length - 1)].transform.position;
        }
    }
}