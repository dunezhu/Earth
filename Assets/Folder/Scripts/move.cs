using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class move : MonoBehaviour
{
    public Slider mySlider;

    [SerializeField] float movementSpeed = 100f;
    [SerializeField] float turnSpeed = 30f;

    Transform myT;

    float sliderValue;

    void Awake()
    {
        myT = transform;
    }

    void Update()
    {
        Turn();
        Thrust();
    }

    void Turn()
    {
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Yaw");

        myT.Rotate(-pitch, yaw, 0);
    }

    void Thrust()
    {
        myT.position += myT.forward * Time.deltaTime * (movementSpeed * sliderValue);

        mySlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

    }
    public void ValueChangeCheck()
    {
        Debug.Log(mySlider.value);

        sliderValue = mySlider.value;
    }
}
