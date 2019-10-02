using SpaceSystem.Planets.Intarfaces;
using UnityEngine;

namespace SpaceSystem.Planets
{
    public class Jupiter : Planet, IGasGiantTypePlanet
    {
        public float PlanetGasCompisition { get { return planetGasCompisition; } }

        private float planetGasCompisition = 0.006f;

        public override void Init(Manager manager)
        {
            managerScript = manager;
            managerScript.OnGlobalUpdate += HandleUpdate;



            var planet = Instantiate(prefabPlanet, this.transform.position, this.transform.rotation, dayPivot);
            planet3DButton = GetComponentInChildren<Planet3DButton>();
            if (planet3DButton != null)
                planet3DButton.Init(this, this);

            distancePivot.localPosition = new Vector3(distanceToSun, 0, 0);
            yearPivot.localRotation = Quaternion.Euler(orbitPlace, 0, 0);
        }
    }
}
