using UnityEngine;
using UnityEngine.UI;

namespace SpaceSystem.UIController
{
    public class UIController : MonoBehaviour
    {
        public InputField RadiusPlanetOfCenter { get { return radiusOfCenter; } }
        public InputField RotatPlaneteOfCenter { get { return rotateOfCenter; } }
        public InputField AxisPlanetRotate { get { return hisAxis; } }
        public Slider TimeScaleSlider { get { return timeScaleSlider; } }

        [SerializeField] private Text message0;
        [SerializeField] private Text message1;
        [SerializeField] private Text message2;
        [SerializeField] private Text message3;
        [SerializeField] private Slider timeScaleSlider;
        [SerializeField] private InputField radiusOfCenter;
        [SerializeField] private InputField rotateOfCenter;
        [SerializeField] private InputField hisAxis;
        [SerializeField] private GameObject infoAboutPlanetPanel;

        public void OpenInfo()
        {
            infoAboutPlanetPanel.SetActive(true);
        }

        public void ClearAllMessages()
        {
            message0.text = null;
            message1.text = null;
            message2.text = null;
            message3.text = null;

            radiusOfCenter.text = null;
            rotateOfCenter.text = null;
            hisAxis.text = null;
        }

        public void SetMessage0(string message)
        {
            message0.text = message;
        }

        public void SetMessage1(string message)
        {
            message1.text = message;
        }

        public void SetMessage2(string message)
        {
            message2.text = message;
        }

        public void SetMessage3(string message)
        {
            message3.text = message;
        }
    }
}
