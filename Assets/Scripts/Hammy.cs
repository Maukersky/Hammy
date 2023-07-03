using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammy : MonoBehaviour
{
    public GameEngine GE;
    public List<GameObject> FLegs;
    public List<GameObject> BLegs;
    float y;
    private void Start()
    {
        y = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        float amount = Mathf.Sin(Time.time * GE.HSpeed)/2;
        transform.position = new Vector3(transform.position.x, y - amount, transform.position.z);
        foreach (GameObject leg in FLegs)
        {
            leg.GetComponent<RectTransform>().transform.eulerAngles = new Vector3(0, 0, -amount * 90 + 90 / 4);
        }
        foreach (GameObject leg in BLegs)
        {
            leg.GetComponent<RectTransform>().transform.eulerAngles = new Vector3(0, 0, amount * 90 - 90 / 4);
        }
    }
}
