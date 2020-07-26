using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
    public GameObject Parent;

    public void Die()
    {
        Parent.SetActive(false);
    }
}
