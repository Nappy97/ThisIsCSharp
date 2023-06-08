class MyClass
{
    static void Main(string[] args)
    {
        // int a = 7.3;
        // float b = 3.14;
        // double c = a * b;

        // 2. 값 형식 (value types) 참조형식(Reference Types)
        // Stack 공간에 데이터를 할당하며, 참조 형식은 Heap 공간에 데이터를 할당
        // Stack 공간은 정적으로 메모리에 할당. 선언된 한수를 빠져나가면 소멸.
        // Heap 공간은 동적으로 메로리에 할당. GC가 힙 영역에 사용되지 않는 데이터를 소멸

        // 3. 박싱과 언박싱
        // 박싱(Boxing)
        // 값 타입(value types)의 객체를 참조 타입(ReferenceType)으로 바꾸는 것
        /*int i = 123;
        object o = i; // 박싱
        Console.WriteLine(o.ToString());
        */

        // 언박싱(UnBoxing)
        // 참조 타입을 값 타입으로 변환하는 작업
        /*
        int j = 123;
        object o1 = j;
        int j1 = (int)o1;
        */
        
        // 4. 문제
        Console.WriteLine("사각형의 너비를 입력하세요. ");
        var width = Console.ReadLine();

        Console.WriteLine("사각형의 높이를 입력하세요. ");
        var height = Console.ReadLine();
        
        // 사각형이 넓이 계산 및 출력
        var area = Int32.Parse(width) * Int32.Parse(height);

        Console.WriteLine("사각형의 넓이는 {0} 입니다. ", area);
    }
}