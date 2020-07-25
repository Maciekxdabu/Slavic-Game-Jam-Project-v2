using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float Radius_Range;
    private Vector3 offset;
    [Space]
    public float speed;

    private Vector3 newPosition;

    void Start()
    {
        offset.x = Random.Range(-1, 1);
        offset.y = Random.Range(-1, 1);
        offset.z = 0;
        newPosition = new Vector3(0, 0, 1) + offset;
        newPosition.Normalize();
        newPosition *= Radius_Range;
    }

    void Update()
    {
        Vector3 change = Vector3.MoveTowards(transform.localPosition, newPosition, speed * Time.deltaTime);
        transform.localPosition = change;

        if (Vector3.Distance(transform.localPosition, newPosition) <= 0.2f)
        {
            offset.x = Random.Range(-1, 1);
            offset.y = Random.Range(-1, 1);
            newPosition = new Vector3(0, 0, 1) + offset;
            newPosition.Normalize();
            newPosition *= Radius_Range;
        }
    }
}
