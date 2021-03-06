using UnityEngine;
using UnityEngine.UI;
public class Calculate : MonoBehaviour
{
    public Text[] texts ;

    private static Text inputA;
    private static Text inputB;
    private static Text inputR;
    private static Text inputQ;
    private static Text inputK;
    private static Text inputK2;

    private static float A;
    private static float B;
    private static float R;
    private static float Q;
    private static float K;
    private static float K2;

    // x = 0 A Value  x = 1 B Value  
    // x = 2 R Value  x = 3 Q Value   
    public int x;

    public bool startControl = true;
    // Start is called before the first frame update
    void Start()
    {
        if(startControl){
            startControl = !startControl;
            inputA = GameObject.FindGameObjectWithTag("InputA").GetComponent<Text>();
            inputB = GameObject.FindGameObjectWithTag("InputB").GetComponent<Text>();
            inputR = GameObject.FindGameObjectWithTag("InputR").GetComponent<Text>();
            inputQ = GameObject.FindGameObjectWithTag("InputQ").GetComponent<Text>();
            inputK = GameObject.FindGameObjectWithTag("InputK").GetComponent<Text>();
            inputK2 = GameObject.FindGameObjectWithTag("InputK2").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            A = 0;  B = 0;  R = 0;
            Q = 0;  K = 0;  K2 = 0;
            Application.LoadLevel(0);
        }
    }

    public void RectangularCalculate(){
        float.TryParse( inputA.text, out A);
        float.TryParse( inputB.text, out B);
        float.TryParse( inputK.text, out K);

        texts[0].text = "Rectangular Form; " + A + " + " + B + "J" + "\n" + "\n" + "Values : Reel A = " + A + " Imaginer B = " + B;
        texts[1].text = A + "^2 + " + B + "^2";
        texts[2].text = (A*A).ToString("F2") + " + " + (B*B).ToString("F2");
        texts[3].text = Mathf.Sqrt((A*A + B*B)).ToString("F2");
        texts[4].text = "tan^-1 ( " + B + " / " + A + " )";
        texts[5].text = (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2") + "°";
        texts[6].text = "Z = " + Mathf.Sqrt((A*A + B*B)).ToString("F2") + "        " + (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2") + "°";
        texts[7].text = "Z = " + Mathf.Sqrt((A*A + B*B)).ToString("F2") + ". e^j" + (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2") + "°";
        texts[8].text = "Z = " + Mathf.Sqrt((A*A + B*B)).ToString("F2") + ". e^j" + (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2") + "°";
        texts[9].text = "Z = " + Mathf.Sqrt((A*A + B*B)).ToString("F2") + ".(cos(" + (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2") + "°" + ") + j.sin(" + (Mathf.Atan2(B,A)*180/Mathf.PI).ToString("F2")  + "°"+ ")";
        texts[10].text = "Z = " + (Mathf.Sqrt((A*A + B*B))*(Mathf.Cos(Mathf.Atan2(B,A)))).ToString("F2") + " + j" + (Mathf.Sqrt((A*A + B*B))*(Mathf.Sin(Mathf.Atan2(B,A)))).ToString("F2");
        texts[11].text = "Z = k.(" + (Mathf.Sqrt((A*A + B*B))*(Mathf.Cos(Mathf.Atan2(B,A)))).ToString("F2") + " + j" + (Mathf.Sqrt((A*A + B*B))*(Mathf.Sin(Mathf.Atan2(B,A)))).ToString("F2") + ")";
        texts[12].text = "Z = " + (K*(Mathf.Sqrt((A*A + B*B))*(Mathf.Cos(Mathf.Atan2(B,A))))).ToString("F2") + " + j" + (K*(Mathf.Sqrt((A*A + B*B))*(Mathf.Sin(Mathf.Atan2(B,A))))).ToString("F2");
    }

    public void PolarCalculate(){
        float.TryParse( inputR.text, out R);
        float.TryParse( inputQ.text, out Q);
        float.TryParse( inputK2.text, out K2);
        
        float a = (R*(Mathf.Cos(Q*Mathf.PI/180)));
        float b = (R*(Mathf.Sin(Q*Mathf.PI/180)));
        texts[0].text = "Rectangular Form; " + a.ToString("F2") + " + " + b.ToString("F2") + "J" + "\n" + "\n" + "Values : Reel A = " + a.ToString("F2") + " Imaginer B = " + b.ToString("F2");
        texts[1].text = a.ToString("F2") + "^2 + " + b.ToString("F2") + "^2";
        texts[2].text = (a*a).ToString("F2") + " + " + (b*b).ToString("F2");
        texts[3].text = Mathf.Sqrt((a*a + b*b)).ToString("F2");
        texts[4].text = "tan^-1 ( " + b.ToString("F2") + " / " + a.ToString("F2") + " )";
        texts[5].text = (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2") + "°";
        texts[6].text = "Z = " + Mathf.Sqrt((a*a + b*b)).ToString("F2") + "        " + (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2") + "°";
        texts[7].text = "Z = " + Mathf.Sqrt((a*a + b*b)).ToString("F2") + ". e^j" + (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2") + "°";
        texts[8].text = "Z = " + Mathf.Sqrt((a*a + b*b)).ToString("F2") + ". e^j" + (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2") + "°";
        texts[9].text = "Z = " + Mathf.Sqrt((a*a + b*b)).ToString("F2") + ".(cos(" + (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2")  + "°"+ ") + j.sin(" + (Mathf.Atan2(b,a)*180/Mathf.PI).ToString("F2") + "°" + ")";
        texts[10].text = "Z = " + (Mathf.Sqrt((a*a + b*b))*(Mathf.Cos(Mathf.Atan2(b,a)))).ToString("F2") + " + j" + (Mathf.Sqrt((a*a + b*b))*(Mathf.Sin(Mathf.Atan2(b,a)))).ToString("F2");
        texts[11].text = "Z = k.(" + (Mathf.Sqrt((a*a + b*b))*(Mathf.Cos(Mathf.Atan2(b,a)))).ToString("F2") + " + j" + (Mathf.Sqrt((a*a + b*b))*(Mathf.Sin(Mathf.Atan2(b,a)))).ToString("F2") + ")";
        texts[12].text = "Z = " + (K*(Mathf.Sqrt((a*a + b*b))*(Mathf.Cos(Mathf.Atan2(b,a))))).ToString("F2") + " + j" + (K*(Mathf.Sqrt((a*a + b*b))*(Mathf.Sin(Mathf.Atan2(b,a))))).ToString("F2");
    }

}
