using SpaceSystem.Planets;
using SpaceSystem.UIController;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Manager : MonoBehaviour
{
    public static Manager instance;

    public event Action OnGlobalUpdate;

    [SerializeField] private UIController uIController;
    [SerializeField] private List<GameObject> planets = new List<GameObject>();
    [SerializeField] private Transform sun;

    private Planet planet;

    #region Monobehaviuor
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }


        for (int i = 0; i < planets.Count; i++)
        {
            var planet = Instantiate(planets[i], sun);
            planet.GetComponent<Planet>().Init(this);
        }
    }

    void Update()
    {
        OnGlobalUpdate?.Invoke();
    }
    #endregion

    public void ChangeCurrentPlanet(Planet currentPlanet)
    {
        planet = currentPlanet;
    }

    public void ChangeValueRadiusOfCenter()
    {
        var radiusValue = string.IsNullOrEmpty(uIController.RadiusPlanetOfCenter.text) ? 0 : Convert.ToSingle(uIController.RadiusPlanetOfCenter.text);
        planet.ChangeDistanceToSun(radiusValue);
        planet.ReInit();
    }

    public void ChangeValueRotateOfCenter()
    {
        var rotateValue = string.IsNullOrEmpty(uIController.RotatPlaneteOfCenter.text) ? 0 : Convert.ToSingle(uIController.RotatPlaneteOfCenter.text);
        planet.ChangeRotateAroundCenterSystem(rotateValue);
        planet.ReInit();
    }

    public void ChangeValuePlanetAxis()
    {
        var planetAxisRotate = string.IsNullOrEmpty(uIController.AxisPlanetRotate.text) ? 0 : Convert.ToSingle(uIController.AxisPlanetRotate.text);
        planet.ChangeAroundHisAxis(planetAxisRotate);
        planet.ReInit();
    }

    public void ChangeTimeScale()
    {
        Time.timeScale = uIController.TimeScaleSlider.value;
    }
}
