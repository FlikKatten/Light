using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCycle : MonoBehaviour
{
    public float duration = 60f;
    public Gradient lightColor;

    private Light _sunLight;
    private float _time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _sunLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        float timePercent = (_time % duration) / duration;

        float rotationX = Mathf.Lerp(-90f, 270f, timePercent);

        transform.rotation = Quaternion.Euler(rotationX, 0f, 0f);

        _sunLight.color = lightColor.Evaluate(timePercent);
    }
}
