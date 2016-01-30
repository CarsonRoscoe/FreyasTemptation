﻿using UnityEngine;
using System.Collections;

public class DayNight : MonoBehaviour {
    float hour = 0;

    void Start()
    {
        transform.localScale += new Vector3(18, 18, 0);
    }
	
	// Update is called once per frame
	void Update () {
        float alpha = 1- Mathf.Abs((hour % 24) - 12)/12;
        if (alpha > .7f)
            alpha = .7f;
        else if (alpha < .1f)
            alpha = .1f;
        hour += .01f;
        GetComponent<SpriteRenderer>().color =  new Color(1f, 1f, 1f, alpha);
    }
}