using System.Collections;
using System.Reflection;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Outgoing phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    //typeof(CallIncomingToCallFlowLogic),
    //typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN)
)]
public abstract partial class CallOutgoing : Call
{
    ///// <summary>    
    /////     Contact to whom we are calling
    ///// </summary>
    //[AllowUpdate(false)]
    //[References(typeof(Contact))]
    //public override string? IdContact { get; set; }

    /// <summary>
    ///     Line that started phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Line))]
    [UbluxValidationIsRequired]
    public required string IdLineThatInitiatedCall { get; set; } = string.Empty;
}


public class MyClass1
{
    public BaseA Base { get; set; }

    public string? MyString { get; set; }

    public List<MyClass2>? MyList { get; set; }

    public List<string>? List2 { get; set; }

    public MyClass2? NewProp { get; set; }

    public int Foooo { get; set; }
}

public class MyClass2
{
    public string? NameClass2 { get; set; }

    public List<string>? List3 { get; set; }

    public int Foooo { get; set; }
}

public class BaseA
{
    public virtual string FooA { get; set; }
}

public class ImplementC : BaseA
{
    public override string FooA { get; set; }
    public string FooB { get; set; }
}
public class ImplementD : ImplementC
{
    public override string FooA { get; set; }
    public string FooC { get; set; }
}
public class MyValidator
{
    public void Validate(MyClass1 c)
    {
        if (c.Base is null)
            throw new Exception();
        else
        {
            // Base class should be any of these types:
            if (c.Base is ImplementD x0)
            {
                if (x0.FooA == null)
                    throw new Exception();
                if (x0.FooA != null && x0.FooA.Length > 100)
                    throw new Exception();
                if (x0.FooC == null)
                    throw new Exception();
                if (x0.FooC != null && x0.FooC.Length > 100)
                    throw new Exception();
                if (x0.FooB == null)
                    throw new Exception();
                if (x0.FooB != null && x0.FooB.Length > 100)
                    throw new Exception();
            }
            if (c.Base is ImplementC x1)
            {
                if (x1.FooA == null)
                    throw new Exception();
                if (x1.FooA != null && x1.FooA.Length > 100)
                    throw new Exception();
                if (x1.FooB == null)
                    throw new Exception();
                if (x1.FooB != null && x1.FooB.Length > 100)
                    throw new Exception();
            }
            if (c.Base is BaseA x2)
            {
                if (x2.FooA == null)
                    throw new Exception();
                if (x2.FooA != null && x2.FooA.Length > 100)
                    throw new Exception();
            }
            else
            {
                if (Debugger.IsAttached) Debugger.Break(); // we should never be here checking agains base class. How come there is not any implementation?
                if (c.Base.FooA == null)
                    throw new Exception();
                if (c.Base.FooA != null && c.Base.FooA.Length > 100)
                    throw new Exception();
            }
        }
        if (c.MyString != null && c.MyString.Length > 100)
            throw new Exception();
        if (c.MyList is not null)
            foreach (var item1 in c.MyList)
            {
                if (item1 == null) continue;
                if (item1.NameClass2 != null && item1.NameClass2.Length > 100)
                    throw new Exception();
                if (item1.List3 is not null)
                    foreach (var item2 in item1.List3)
                    {
                        if (item2 != null && item2.Length > 100)
                            throw new Exception();
                    }
            }
        if (c.List2 is not null)
            foreach (var item1 in c.List2)
            {
                if (item1 != null && item1.Length > 100)
                    throw new Exception();
            }
        if (c.NewProp != null)
        {
            if (c.NewProp.NameClass2 != null && c.NewProp.NameClass2.Length > 100)
                throw new Exception();
            if (c.NewProp.List3 is not null)
                foreach (var item1 in c.NewProp.List3)
                {
                    if (item1 != null && item1.Length > 100)
                        throw new Exception();
                }
        }
    }
}



