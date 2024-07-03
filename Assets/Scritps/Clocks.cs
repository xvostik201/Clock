using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clocks : MonoBehaviour
{
    [SerializeField] private Transform _hours;
    [SerializeField] private Transform _minutes;
    [SerializeField] private Transform _seconds;

    [SerializeField] private TextMeshProUGUI _timeText;
    void Start()
    {
        UpdateClocks();
    }

    void Update()
    {
        UpdateClocks();
    }

    private void UpdateClocks()
    {
        System.DateTime currentTime = System.DateTime.Now;
        float hours = currentTime.Hour;
        float minutes = currentTime.Minute;
        float seconds = currentTime.Second;

        float hoursAngle = (hours % 12 + minutes / 60f) * 30f;
        float minutesAngle = (minutes + seconds / 60f) * 6f;
        float secondsAngle = seconds * 6f;

        _hours.rotation = Quaternion.Euler(0, 0, -hoursAngle);
        _minutes.rotation = Quaternion.Euler(0, 0, -minutesAngle);
        _seconds.rotation = Quaternion.Euler(0, 0, -secondsAngle);

        _timeText.text = $"{hours} : {minutes} : {seconds}";
    }
}
