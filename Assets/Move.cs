using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float HS = 0.005f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float HSAmount = Input.GetAxis("Horizontal") * HS;

        transform.Translate(HSAmount, 0 ,0);
    }
}
