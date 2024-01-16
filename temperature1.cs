using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temperature1 : MonoBehaviour
{
    public Temperature temperatureplaer;
    public TextMeshProUGUI temperatureText;

    public void UpdateTemperatureText()
    {
        float roundedTemperature = Mathf.Round(temperaturePkaer.temperatureCurrent * 10.0f) * 0.1f;
        string temperatureString = roundedTemperature.ToString();
        temperatureText.text = temperatureString;

    }
    private void Update()
    {
        UpdateTemperatureText();
    }
}