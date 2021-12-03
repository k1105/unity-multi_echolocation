using UnityEngine;

/// description ///
/// エコロケーションの生成を行うスクリプト.
/// デフォルトでは, マウスパッドがクリックされた時にエコロケーションの生成を行う.
/// またその時の中心位置は, インスペクタ上で指定されたゲームオブジェクトのpositionを基準にする.

[RequireComponent(typeof(MultiEcholocationController))]
public class EcholocationTrigger : MonoBehaviour
{
    public GameObject Origin = null;
    private MultiEcholocationController controller;
    private AudioSource aud;

    private void Start()
    {
        this.controller = this.GetComponent<MultiEcholocationController>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 入力方法を変更したい場合はここの一行を修正する. default: クリックでEcholocationを生成.
        {
            if (Origin != null) {
                this.controller.EmitCall(Origin.transform.position);
            // this.controller.EmitCall(hitInfo.point);
            } else {
                Debug.Log("Error: no object exsist.");
                Debug.Log("インスペクタ上でCenterにエコロケーションシェーダーの発生源になるゲームオブジェクトを指定してください. ");
            }
            
        }
    }
}