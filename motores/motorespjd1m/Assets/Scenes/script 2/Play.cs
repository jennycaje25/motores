using UnityEngine;

public class TesteSoma : MonoBehaviour
{
    private int A;
    private int B;
    private int C;

    void Start()
    {
        int A = 23;
        int B = 12;
        //C = A + B;
        C = Soma(A, B);
        
        Debug.Log(C);
    }

    int Soma(int a, int b)
    {
        return a + b;
    }
    
    } 
    
