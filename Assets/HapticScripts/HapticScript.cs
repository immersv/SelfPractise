using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HapticScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        
        
        button.onClick.AddListener(VibrationFunction);
    }

    public void VibrationFunction()
    {
        Debug.Log("Vibrate");
        
        Handheld.Vibrate();
        FindObjectOfType<AudioManager>().PlayAudio();
    }
}
