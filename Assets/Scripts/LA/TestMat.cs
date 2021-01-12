using UnityEngine;
using UnityEngine.UI;

public class TestMat : MonoBehaviour
{
    public Text det;
    public InputField i1, i2, i3, i4;
    public Matrix4x4 mat;
    void Start()
    {
        mat = Matrix4x4.identity;
        i1.text = "1";
        i2.text = "0";
        i3.text = "0";
        i4.text = "1";

        det.text = mat.determinant.ToString();
    }

    public void TransformMat()
    {
        mat.SetRow(0, new Vector4(int.Parse(i1.text), int.Parse(i2.text), 0, 0));
        mat.SetRow(1, new Vector4(int.Parse(i3.text), int.Parse(i4.text), 0, 0));

        transform.position = mat.ExtractPosition();
        transform.localScale = mat.ExtractScale();
        float x = Vector3.Angle(new Vector3(), new Vector3());
        det.text = mat.determinant.ToString();
    }

    public void ResetG()
    {
        i1.text = "1";
        i2.text = "0";
        i3.text = "0";
        i4.text = "1";
        mat.SetRow(0, new Vector4(1, 0, 0, 0));
        mat.SetRow(1, new Vector4(0, 1, 0, 0));
        transform.position = mat.ExtractPosition();
        //transform.rotation = mat.ExtractRotation();
        transform.localScale = mat.ExtractScale();
    }
}
