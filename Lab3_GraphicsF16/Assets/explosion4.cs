using UnityEngine;
using System.Collections;

public class explosion4 : MonoBehaviour {

    public ParticleSystem exp;
    public void OnCollisionEnter(Collision collision)
    {
        exp = GetComponentInChildren<ParticleSystem>();
        exp.Play();
        Destroy(gameObject);
    }
}
