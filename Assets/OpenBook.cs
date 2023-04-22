using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenBook : MonoBehaviour
{
    [SerializeField]
    HingeJoint hinge;
    // Start is called before the first frame update


    public void OpenSesame()
    {
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        hinge.useSpring = true;
        yield return new WaitForSeconds(1);
        hinge.useSpring = false;
        yield return null;

    }
}
