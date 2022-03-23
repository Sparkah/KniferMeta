using UnityEngine;

public class KnifeThrower : MonoBehaviour
{
    private bool canThrow = true;
    private Rigidbody knife;
    private Vector3 throwDirection;
    [SerializeField] float throwForce = 700f;

    private void Start()
    {
        knife = GetComponent<Rigidbody>();
        throwDirection = new Vector3(0, 1, 0);
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.touchCount > 0) && canThrow == true && IsPointerOverUI.IsPointerOverUIObject()==false)
        {
            ThrowKnife();
        }

        //Почистить сохранения PlayerPrefs
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.DeleteAll();
        }
        //Почистить сохранения PlayerPrefs
    }

    public void ThrowKnife()
    {
        canThrow = false;
        knife.AddForce(throwDirection * throwForce);
    }
}