using UnityEngine;

public class GraphData_1 : MonoBehaviour
{   
    public Graph3D Graph3D;

    private Graph3D.Surface surf;   

    private void Awake()
    {   
        surf = new Graph3D.Surface(Graph3D);

        //surf.data.typeFunc = Graph3D.TypeFunc.Y_XZ;
        //surf.data.typeFunc = Graph3D.TypeFunc.Y_ZX;
        //surf.data.typeFunc = Graph3D.TypeFunc.Z_YX;
        //surf.data.typeFunc = Graph3D.TypeFunc.Z_XY;
        surf.data.typeFunc = Graph3D.TypeFunc.X_YZ;
        //surf.data.typeFunc = Graph3D.TypeFunc.X_ZY;

        surf.data.typeGraph = Graph3D.TypeGraph.Surface;
        surf.data.func = func_7;

        surf.data.Z.scale.L = -50;
        surf.data.Z.scale.H = 50;
        surf.data.Z.segments = 100;        
        surf.data.Z.curves = 20;

        surf.data.Y.scale.L = -50;
        surf.data.Y.scale.H = 50;
        surf.data.Y.segments = 100;       
        surf.data.Y.curves = 20;

        surf.data.X.scale.L = -50;
        surf.data.X.scale.H = 50;
        surf.data.X.segments = 100;         
        surf.data.X.curves = 20;

        surf.data.autoScaleAxeFunc = true;
             
    }

    private void OnEnable()
    {              
        surf.DataSet();
        surf.Show(Color.blue);
    }

    private float func_7(float x, float z)
    {
        return 0.02f * (x * x + z * z);
    }

    

    private float func_5(float x, float z)
    {
        return (0.5f * x * x) / (1 + z * z);
    }

    private float func_4(float x, float z)
    {
        return 0.2f * Mathf.Sin(x * z) * Mathf.Cos(x * z);
    }

    private float func_3(float x, float z)
    {
        return 0.02f * Mathf.Sin((x * x * 5) / (1 + z * z * 0.5f));
    }

    private float func_2(float x, float z)
    {
        return Mathf.Sin(x * x + z * z) / (0.1f + x * x + z * z) - Mathf.Cos(x * x + z * z) / (1 + x * x + z * z);
    }
}
