using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public GameEngine GE;
    void Update()
    {
        float amount = Time.time * GE.HSpeed / 4;
        transform.eulerAngles = new Vector3(0, 0, amount * 90);
    }
}
