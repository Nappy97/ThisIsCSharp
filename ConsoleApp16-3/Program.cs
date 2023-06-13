
using System.Reflection;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        // AppDomain.CurrentDomain -> AssemblyBuilder로 대체됨 
        AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(
            new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

        ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

        TypeBuilder newType = newModule.DefineType("Sum1To100");

        MethodBuilder newMethod = newType.DefineMethod(
            "Calculate",
            MethodAttributes.Public,
            typeof(int), // 반환 형식
            new Type[0]); // 매개 변수

        ILGenerator generator = newMethod.GetILGenerator();
        generator.Emit(OpCodes.Ldc_I4, 1); // 32비트 정수 1을 계산 스택에 넣음

        for (int i = 2; i <= 100; i++)
        {
            generator.Emit(OpCodes.Ldc_I4, i); // 32비트 정수 i를 계산 스택에 넣음
            generator.Emit(OpCodes.Add); // 계산 후 계산 스택에 있는 두 개의 값을 
            // 꺼내 더한 후 그 결과를 계산 스택에 넣음
        }

        generator.Emit(OpCodes.Ret); // 계산 스택에 담긴 값을 반환

        newType.CreateType();

        object sum1To100 = Activator.CreateInstance(newType);
        MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
        Console.WriteLine(Calculate.Invoke(sum1To100, null));
    }
}