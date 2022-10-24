using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Template;

    private void Start()
    {
        Instantiate(Template, new Vector3(37.5f, -2.37f, 0), Quaternion.identity);
        Instantiate(Template, new Vector3(39, -2.37f, 0), Quaternion.identity);
        Instantiate(Template, new Vector3(40f, -2.37f, 0), Quaternion.identity);
        Instantiate(Template, new Vector3(39.7f, -0.6f, 0), Quaternion.identity);
    }
}
