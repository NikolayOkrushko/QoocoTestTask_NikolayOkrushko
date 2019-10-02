
using System;
using UnityEngine;
using SpaceSystem.Planets.Intarfaces;

namespace SpaceSystem.Planets
{
    public class Planet : MonoBehaviour
    {
        public PlanetNames PlanetName { get { return planetName; } }
        public float Mass { get { return mass; } }
        public float Temperature { get { return temperature; } }

        [SerializeField] protected PlanetNames planetName;
        [SerializeField] protected GameObject prefabPlanet;
        [SerializeField] protected Transform distancePivot;
        [SerializeField] protected Transform dayPivot;
        [SerializeField] protected Transform yearPivot;
        [SerializeField] protected float distanceToSun;
        [SerializeField] protected float rotateAroundCenterSystem;
        [SerializeField] protected float rotateAroundHisAxis;
        [SerializeField] protected float orbitPlace;
        [SerializeField] protected float mass;
        [SerializeField] protected float temperature;

        protected Planet3DButton planet3DButton;

        protected Manager managerScript;




        public virtual void Init(Manager manager) { }


        public void ReInit()
        {
            distancePivot.localPosition = new Vector3(distanceToSun, 0, 0);
            yearPivot.localRotation = Quaternion.Euler(orbitPlace, 0, 0);
        }


        public void ChangeDistanceToSun(float distance)
        {
            distanceToSun = distance;
        }

        public void ChangeRotateAroundCenterSystem(float value)
        {
            rotateAroundCenterSystem = value;
        }

        public void ChangeAroundHisAxis(float value)
        {
            rotateAroundHisAxis = value;
        }

        public void ChangeOrbitPlace(float value)
        {
            orbitPlace = value;
        }

        protected void HandleUpdate()
        {
            yearPivot.transform.Rotate(0, rotateAroundCenterSystem * Time.deltaTime, 0);
            dayPivot.transform.Rotate(0, rotateAroundHisAxis * Time.deltaTime, 0);
        }
    }
}
