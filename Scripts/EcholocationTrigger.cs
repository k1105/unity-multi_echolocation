using UnityEngine;

[RequireComponent(typeof(MultiEcholocationController))]
public class EcholocationTrigger : MonoBehaviour
{
    private MultiEcholocationController controller;
    private Camera mainCamera;
    private AudioSource aud;

    private void Start()
    {
        this.mainCamera = Camera.main;
        this.controller = this.GetComponent<MultiEcholocationController>();
    }

    private void Update()
    {

        // if (Input.GetMouseButtonDown(0) && Physics.Raycast(this.mainCamera.ScreenPointToRay(Input.mousePosition), out var hitInfo))
        if (Input.GetMouseButtonDown(0))
        {
            if (this.mainCamera != null) {
                this.controller.EmitCall(this.mainCamera.transform.position);
            // this.controller.EmitCall(hitInfo.point);
            } else {
                Debug.Log("Error: no camera exsist.");
                Debug.Log("上記のエラーはCamera.mainとして使用したいカメラのtagをMainCameraに設定すると解決(21/12/02)");
            }
            
        }
    }
}