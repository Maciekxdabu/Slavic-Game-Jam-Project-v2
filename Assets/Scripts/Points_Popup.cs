using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points_Popup : MonoBehaviour
{
    public float lifetime = 3;
    public float floatSpeed = 3;

    private float lived = 0;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
        GetComponent<Text>().CrossFadeAlpha(0, lifetime, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(0, floatSpeed * Time.fixedDeltaTime, 0));
        lived += Time.fixedDeltaTime;
    }
}
