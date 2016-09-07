
- Loading
```csharp
    XmlTextReader reader = new XmlTextReader(@"...");
```

- Clearing spaces
```csharp
    reader.WhitespaceHandling = WhitespaceHandling.None;
```

Reading data collection
```csharp
    while (reader.Read())
    {
        // ...
    }
```
- Type of node
```csharp
    XmlNodeType nodeType = reader.NodeType;
```

- Node name
```csharp
    string nodeName = reader.Name;
```
```csharp
    // Values of node
    string nodeValue = reader.Value;
```

- Attribute count
```csharp
    int nodeAtributeCount = reader.AttributeCount;
```

- Reading attribute collection
```csharp
    while (reader.MoveToNextAttribute())
    {
        // ...
    }
```    

- Closing the stream
```csharp
    reader.Close();
```