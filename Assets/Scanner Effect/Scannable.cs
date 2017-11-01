using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scannable : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Animator UIAnim;
    public bool IsScaned = false;
    private Renderer rend;

    public void Start()
    {
        rend = this.GetComponent<Renderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IsScaned = false;
        }
    }

    public void Ping()
    {
        IsScaned = true;
        rend.material = mat2;
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        while (IsScaned)
        {
            yield return new WaitForSeconds(2);
            Debug.Log("Nielsiscool");
            IsScaned = false;
            rend.material = mat1;
        }
    }

}
