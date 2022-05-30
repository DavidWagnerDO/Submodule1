using Submodule2;

namespace Submodule1;
public static class Calculator1
{
 public static int Add(int summand1, int summand2){
     return summand1 + summand2;
 }

public static int Subtract(int minuend, int subtrahend ){
    return Calculator2.Subtract(minuend, subtrahend);
}

}
