# Serialization

- **Binary** [ `BinaryFormatter` ]
- **SOAP** (simple object access protocol) [ `SoapFormatter` ]
- **XML** [ `XmlSerializer` ]
- **JSON** [ `DataContractJsonSerializer` ]

```csharp
    [Serializable]
    public class A
    {
        int a;
        double b;
        
        public int A { get; set }
        public double B { get; set }
        
        [NonSerialized]
        public string B { get; set }
    }
```
```csharp
    public class C
    {
        [DataMember]
        int a;
    }
```