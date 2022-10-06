using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubeScale
{
    public class CubeScale : MonoBehaviour
    {
        private Slider scaleSlider;

        public float scaleMinVal;
        public float scaleMaxVal;

        void Start()
        {
            scaleSlider = GameObject.Find("Scale").GetComponent<Slider>();
            scaleSlider.minValue = scaleMinVal;
            scaleSlider.maxValue = scaleMaxVal;

            scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        }

        void ScaleSliderUpdate(float value)
        {
            transform.localScale = new Vector3(value, value, value);
        }
    }
}

