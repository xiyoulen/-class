using UnityEngine;

public class Script_Exp0210 : MonoBehaviour
{
    public float lineLength=5f; 
    public Vector3 cubeSize=Vector3.one;
    void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.red;
        // 画Y轴线
        Vector3 yEndPosition=transform.position+transform.up*lineLength;
        Gizmos.DrawLine(transform.position,yEndPosition);
        // 绘制Y轴末端的立方体
        Gizmos.DrawCube(yEndPosition,cubeSize);

        Gizmos.color=Color.blue;
        // 画X轴线
        Vector3 xEndPosition=transform.position+transform.right*lineLength;
        Gizmos.DrawLine(transform.position,xEndPosition);
        // 绘制X轴末端的立方体
        Gizmos.DrawCube(xEndPosition,cubeSize);

        Gizmos.color=Color.green;
        // 画Z轴线
        Vector3 zEndPosition=transform.position+transform.forward*lineLength;
        Gizmos.DrawLine(transform.position,zEndPosition);
        // 绘制Z轴末端的立方体
        Gizmos.DrawCube(zEndPosition,cubeSize);
    }

	void OnDrawGizmos()         //始终绘制Gizmo
	{
		Gizmos.DrawSphere(transform.position,1);
	}

}
