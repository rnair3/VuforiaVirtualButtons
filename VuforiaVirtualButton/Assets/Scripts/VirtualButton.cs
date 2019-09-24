using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject cube;

    VirtualButtonBehaviour vrb;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sphere.SetActive(true);
        cube.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
        sphere.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);

        cube.SetActive(true);
        sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
