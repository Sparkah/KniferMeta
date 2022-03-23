using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeStoneCollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<KnifeThrower>()!=null)
        {
            MainGameUIScript uI = FindObjectOfType<MainGameUIScript>();
            uI.MainMenu();
        }
    }
}
