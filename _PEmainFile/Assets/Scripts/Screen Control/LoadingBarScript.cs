using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadingBarScript : MonoBehaviour
{
    public Slider slider;

    public float loadingDone = 0.0005f;
    private float loadProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IncreaseLoading(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value < loadProgress)
            slider.value += loadingDone * (Time.deltaTime / 3);
          
    }

    // loading progress
    public void IncreaseLoading (float newProgress)
    {
       //loadProgress = slider.value + newProgress;
       loadProgress = Mathf.Clamp(slider.value + newProgress, 0f, 1f);
    }
    public void CompleteLoading()
{
    slider.value = 1f;
}

    public void ResetBar()
{
    slider.value = 0;
    //loadProgress = 0;
}

}
