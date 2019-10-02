using SpaceSystem.Planets.Intarfaces;
using UnityEngine;

namespace SpaceSystem.Planets
{
    public class Planet3DButton : MonoBehaviour
    {
        [SerializeField] private PlanetNames objectName;
        private UIController.UIController uiController;

        private bool showName;
        private Vector2 guiPosition;
        private Planet currentPlanet;

        private IEarthTypePlanet earthTypePlanet;
        private IGasGiantTypePlanet gasGiantTypePlanet;
        private IIceGiantTypePlanet iceGiantTypePlanet;
        private IDwarfTypePlanet dwarfTypePlanet;

        #region Monobehaviour
        void Start()
        {
            Manager.instance.OnGlobalUpdate += HandleUpdate;
            uiController = GameObject.FindObjectOfType<UIController.UIController>();
        }
        #endregion

        #region InitMethods
        public void Init(Planet planet, IEarthTypePlanet intarface)
        {
            currentPlanet = planet;
            earthTypePlanet = intarface;
        }

        public void Init(Planet planet, IGasGiantTypePlanet intarface)
        {
            currentPlanet = planet;
            gasGiantTypePlanet = intarface;
        }

        public void Init(Planet planet, IIceGiantTypePlanet intarface)
        {
            currentPlanet = planet;
            iceGiantTypePlanet = intarface;
        }

        public void Init(Planet planet, IDwarfTypePlanet intarface)
        {
            currentPlanet = planet;
            dwarfTypePlanet = intarface;
        }
        #endregion



        private void HandleUpdate()
        {
            if (showName)
            {
                Vector3 screenPosition = UnityEngine.Camera.main.WorldToScreenPoint(transform.position);
                guiPosition = new Vector2(screenPosition.x - 60f, Screen.height - screenPosition.y - 10f);
            }
        }

        private void OnMouseEnter()
        {
            showName = true;
        }

        private void OnMouseExit()
        {
            showName = false;
        }

        private void OnMouseDown()
        {
            switch (currentPlanet.PlanetName)
            {
                case PlanetNames.Ceres:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Earth:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Количество людей на планете : {earthTypePlanet.NumberOfInhabitants} шт");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Eris:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Haumea:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Jupiter:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Состав газа на планете составляет : {gasGiantTypePlanet.PlanetGasCompisition} едениц");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Makemake:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Mars:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Количество людей на планете : {earthTypePlanet.NumberOfInhabitants} шт");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Mercury:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Количество людей на планете : {earthTypePlanet.NumberOfInhabitants} шт");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Neptun:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Состав льда на планете составляет : {iceGiantTypePlanet.PlanetIceComposition} едениц");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Saturn:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Состав газа на планете составляет : {gasGiantTypePlanet.PlanetGasCompisition} едениц");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;


                case PlanetNames.Uranus:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Состав льда на планете составляет : {iceGiantTypePlanet.PlanetIceComposition} едениц");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;

                case PlanetNames.Venus:
                    uiController.OpenInfo();
                    uiController.SetMessage0($"Имя планеты : {currentPlanet.PlanetName.ToString()}");
                    uiController.SetMessage1($"Масса планеты : {currentPlanet.Mass} кг");
                    uiController.SetMessage2($"Температура планеты : {currentPlanet.Temperature} градусов");
                    uiController.SetMessage3($"Количество людей на планете : {earthTypePlanet.NumberOfInhabitants} шт");

                    Manager.instance.ChangeCurrentPlanet(currentPlanet);
                    break;
            }
        }

        private void OnGUI()
        {
            if (showName)
            {
                // считаем позицию
                Rect rect = new Rect(guiPosition.x, guiPosition.y, 120f, 20f);

                // создаем стиль с выравниванием по центру
                GUIStyle label = new GUIStyle(GUI.skin.label);
                label.alignment = TextAnchor.MiddleCenter;

                // выводим имя объекта с созданным стилем, чтобы имя было выведено по центру
                GUI.Label(rect, objectName.ToString(), label);
            }
        }
    }
}