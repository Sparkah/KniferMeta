using UnityEngine;

public class ChooseRandomMaterial : MonoBehaviour
{
    [SerializeField] Material[] sphereMaterials;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material = sphereMaterials[Random.Range(0,sphereMaterials.Length-1)];
    }
}