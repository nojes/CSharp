# Делегаты

> **Делегат (Delegate)** - объект, предназначеный для хранения ссылок на определенные методы классов, а также управление вызовами этих методов.

```csharp
public delegate void Del();

public class A
{
	public void DoSomething()
    {
    	// ...
    }
}

public class B
{
	public void Method1()
    {
    	Del x = new Del(A.DoSomething)
        x.Start();
    }
}
```

### Стандартные делегаты

**Базовые классы делегатов:**
1. ```System.Delegate```
2. ```System.MulticastDelegate```
3. ```System.Threading.ThreadStart```
4. ```System.Threading.ParametrizedThreadStart```
5. ```System.AsyncCallback```
6. ```System.EventHandler```