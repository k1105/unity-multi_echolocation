using UnityEngine;
using System.Collections.Generic;

public class MultiEcholocationController : MonoBehaviour
{
    //private static readonly int Center = Shader.PropertyToID("_Center");
    //private static readonly int Radius = Shader.PropertyToID("_Radius");

    // ここにインスペクター上でEcholocationマテリアルをセットしておく

    // 半径が大きくなるスピード
    [SerializeField][Min(0.0f)] private float speed = .01f;

    // 現在の半径
    private Vector4[] centers = new Vector4[50];
    private float[] radiuses = new float[50];
    private int circle_num = 0;
    private int tail = 0;

    // 毎フレーム半径のセットおよび拡張を行う
    private void Update()
    {
        Shader.SetGlobalFloatArray("GlobalRadiuses", this.radiuses);
        for(int i=0; i<this.circle_num; i++) {
            this.radiuses[i] += 1.0f * Time.deltaTime;
        }
        
    }

    // 他のスクリプトからEmitCallを実行することで
    // 中心点を設定し、半径を0にリセットする
    public void EmitCall(Vector3 position)
    {
        this.radiuses[this.tail] = 0.0f;
        this.tail = (this.tail + 1) % 50;
        this.centers[this.tail] = position;
        Shader.SetGlobalVectorArray("GlobalCenters", this.centers);
        if (this.circle_num < 50) {
            this.circle_num++;
        }
        Shader.SetGlobalInt("GlobalCircleNum", this.circle_num);
    }
}