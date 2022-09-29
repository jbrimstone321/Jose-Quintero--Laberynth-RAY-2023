using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_walls : MonoBehaviour
{
    public float wMovementZ = 40f;
    public float wMovementSpeedZ = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.0f, 0.0f, -wMovementZ * wMovementSpeedZ * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            wMovementZ *= -1;
        }
    }

}
