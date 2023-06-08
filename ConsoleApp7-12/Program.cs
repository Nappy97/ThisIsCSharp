class Base
{
    public virtual void SealMe()
    {
    }
}

class Derived : Base
{
    public sealed override void SealMe()
    {
    }
}

class WantToOverride : Derived
{
    // public override void SealMe() -> 컴파일 에러 오버라이드 불가
    // {
        
    // }
}

class MainApp
{
    static void Main(string[] args)
    {
        
    }
}