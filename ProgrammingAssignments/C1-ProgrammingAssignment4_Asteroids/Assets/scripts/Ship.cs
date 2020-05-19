using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public new Rigidbody2D rigidbody2D;
    public new CircleCollider2D collider;

    // Raduis of the circle collider
    public float radius;

    // movement support
    public Vector2 thrustDirection; 
    const float ThrustForce = 5;

    const float RotateDegreesPerSecond = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        thrustDirection = new Vector2(1, 0);

        collider = GetComponent<CircleCollider2D>();
        radius = collider.radius;
    }

    // Checks for the Trust input to move the ship
    void FixedUpdate()
    {
        if (Input.GetAxis("Trust") != 0)
        {
            rigidbody2D.AddForce(
            ThrustForce * thrustDirection, ForceMode2D.Force);
        }

        //RotateShip();
    }

    // Update is called once per frame
    void Update()
    {

        float rotationInput = Input.GetAxis("Rotate");
        //print("Rotation Input is : " + rotationInput);
        float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;

        Vector3 currentEulerAngle;

        if (rotationInput < 0)
        {
            rotationAmount *= -1;
            transform.Rotate(Vector3.forward, rotationAmount);
            currentEulerAngle = transform.eulerAngles;
            thrustDirection.x = Mathf.Cos(currentEulerAngle.z * Mathf.Deg2Rad);
            thrustDirection.y = Mathf.Sin(currentEulerAngle.z * Mathf.Deg2Rad);

        }
        else if (rotationInput > 0)
        {
            rotationAmount *= 1;
            transform.Rotate(Vector3.forward, rotationAmount);
            currentEulerAngle = transform.eulerAngles;
            thrustDirection.x = Mathf.Cos(currentEulerAngle.z * Mathf.Deg2Rad);
            thrustDirection.y = Mathf.Sin(currentEulerAngle.z * Mathf.Deg2Rad);
        }

    }

    // This function helps in screen wrapping when the ship exits on other side
    private void OnBecameInvisible()
    {
        print("Ship is invisible");
        Vector2 position = transform.position;
        if (position.x - radius < ScreenUtils.ScreenLeft || position.x + radius > ScreenUtils.ScreenRight)
        {
            //print("check1 passed");
            position.x = - position.x;
        }

        if (position.y + radius > ScreenUtils.ScreenTop || position.y - radius < ScreenUtils.ScreenBottom)
        {
            position.y = - position.y;
        }
        transform.position = position;
    }
}
