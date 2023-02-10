using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    void Start()
    {
        startButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
