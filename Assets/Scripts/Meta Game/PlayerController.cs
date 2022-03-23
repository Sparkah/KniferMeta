using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody player;
    public float speed = 25;
    //Передвижение реализовано без библиотеки джойстика.
    //Джостик оставил для вида; возможно будет удобнее его физически видеть и ощущать
    public DynamicJoystick dynamicJoystick;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        if (Input.touchCount > 0)
        {
            player.AddForce(/*direction*/transform.forward * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
            Vector2 touchOnScreen = Camera.main.ScreenToViewportPoint(Input.GetTouch(0).position);
            //Get the angle between the points
            float angle = AngleBetweenTwoPoints(positionOnScreen, touchOnScreen);
            transform.rotation = Quaternion.Euler(new Vector3(0f, -angle -90, 0f));
        }
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}