# xUnit Extensions

## xAsserts
- DoesNotThrow
- DoesNotThrowAsync

## Sintaxe

```csharp
XAssert.DoesNotThrow(() => MyClass.MyMethod(myArgs));
```

```csharp
await XAssert.DoesNotThrowAsync(async () => await MyClass.MyMethodAsync(myArgs));
```

## NuGet Package
<https://www.nuget.org/packages/ArchSoft.XUnit.Extensions>