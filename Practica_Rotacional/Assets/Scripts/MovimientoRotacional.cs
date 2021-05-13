using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoRotacional : MonoBehaviour
{
    float time = 0;
    public Text timeText;
    public Text anguloText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        float a = Angulo(time);

        timeText.text = "T: " + time.ToString();
        anguloText.text = "Angulo: " + a.ToString();

        transform.rotation = Quaternion.Euler(0, 0, a);

    }

    float Angulo(float t) {
        float a;
        a = -1 - (0.6f * t) + (0.25f * Mathf.Pow(t, 2));
        a = a * ( 180/ Mathf.PI );
        return a;
    }
}
