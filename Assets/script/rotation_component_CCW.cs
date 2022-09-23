using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_component_CCW : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -120f * Time.deltaTime);
    }
}
