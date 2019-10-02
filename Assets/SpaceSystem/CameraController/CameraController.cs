
using UnityEngine;

namespace SpaceSystem.CameraControllers
{
    public class CameraController : MonoBehaviour
    {

        [SerializeField] private Transform cameraTarget;
        private UnityEngine.Camera mainCamera;

        private Vector3 cameraOffset;

        [Range(0.01f, 1.0f)]
        [SerializeField] float SmoothFactor = 0.5f;

        private bool LookAtSpace = false;
        private bool RotateAroundSpace = true;
        private float RotationsSpeed = 5.0f;

        private float minZoom = 10f;
        private float maxZoom = 60f;
        private float sensitivity = 10f;

        #region Monobehaviour
        void Start()
        {
            cameraOffset = transform.position - cameraTarget.position;
            mainCamera = GetComponent<UnityEngine.Camera>();
        }

        void LateUpdate()
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                if (RotateAroundSpace)
                {
                    Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);
                    Quaternion camTurnUp = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationsSpeed, Vector3.forward);

                    cameraOffset = camTurnAngle * cameraOffset;
                    cameraOffset = camTurnUp * cameraOffset;
                }

                Vector3 newPos = cameraTarget.position + cameraOffset;

                transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

                if (LookAtSpace || RotateAroundSpace)
                    transform.LookAt(cameraTarget);
            }

            float zoom = mainCamera.fieldOfView;
            zoom -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
            mainCamera.fieldOfView = zoom;
        }
    }
    #endregion
}
