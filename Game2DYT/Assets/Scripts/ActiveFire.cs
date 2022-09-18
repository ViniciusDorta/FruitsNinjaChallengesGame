using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFire : MonoBehaviour
{
    public float active;
    public float repeat;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("fire_on", active, repeat);
    }

    void fire_on()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        anim.SetBool("fire_on", true);
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("fire_on", false);
    }
}
