using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthSlider : MonoBehaviour
{
    [SerializeField]
    Slider slider;

    [SerializeField]
    Player player; 
	
	
	// Update is called once per frame
	void Update ()
    {
        //slider value must be inbetween zero and one
        slider.value = player.CurrentHitpointsAsPercentage;

	}
}
