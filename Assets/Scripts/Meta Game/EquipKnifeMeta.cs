using UnityEngine;

public class EquipKnifeMeta : MonoBehaviour
{
    [SerializeField] GameObject[] knifes;
    [SerializeField] GameObject rightHand;

    private void Start()
    {
        int knifeToEquip = PlayerPrefs.GetInt("knife");
        GameObject knife = Instantiate(knifes[knifeToEquip], transform.position + rightHand.transform.position, Quaternion.identity, rightHand.transform);
        knife.transform.rotation = Quaternion.Euler(new Vector3(0,-90,0));
        knife.GetComponent<KnifeThrower>().enabled = false;
        knife.GetComponent<Rigidbody>().isKinematic = true;
    }
}