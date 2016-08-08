## Cвойства классов

> **Свойство** - специальный метод, предназначеный для представления доступа к конкретному закрытому полю класса.

```csharp
class A
{
	int data1;
    string data2;

	public int Data1
	{
		get { return data1; }
		set { data1 = value; }
	}

	public string Data2
	{
		get { return data2; }
		set { data2 = value; }
	}
}
```

> **Автоматически реализуемые свойства** - аксессоры, для которых явно не определяется базовая переменная.

```csharp
class A
{
	public int data1 { get; set; }
	public string data2 { get; set; }
}
```