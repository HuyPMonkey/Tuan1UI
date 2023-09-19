using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    public Canvas canvasToActivate;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(SwitchCanvas);
    }

    void SwitchCanvas()
    {
        // Activate the target canvas
        canvasToActivate.enabled = true;
        // Deactivate the current canvas
        gameObject.GetComponentInParent<Canvas>().enabled = false;

        
    }
}
