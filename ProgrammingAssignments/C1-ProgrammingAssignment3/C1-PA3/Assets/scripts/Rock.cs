using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{

    // Rock Destroy support
    const float RockLifespanSeconds = 3;
    Timer destroyTimer;

    // Start is called before the first frame update
    void Start()
    {
        // apply impulse force to get rock moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

        // create and start timer
        destroyTimer = gameObject.AddComponent<Timer>();
        destroyTimer.Duration = RockLifespanSeconds;
        destroyTimer.Run();

    }

    //// Update is called once per frame
    //void Update()
    //{
    //    //if (destroyTimer.Finished)
    //    //{
    //    //    Destroy(gameObject);
    //    //    print("Object destroyed as the time expired");
    //    //}

    //}

    // Destroys the object when it gets invisible
    private void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
        print("Object destroyed");
    }
}
