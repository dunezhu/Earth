using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    public Transform world;
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // rotate the earth

        world.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0), Space.World);
    }
}