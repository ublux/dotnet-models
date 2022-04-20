namespace Ublux.Communications.Domain.Attributes;

/// <summary>
///     Used to modify a logWebService request. If it has a value it will be replaced
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class LogWebServiceRequestOverrideOptionsAttribute : Attribute
{
    /// <summary>
    ///     How expensive this method is? 
    /// </summary>
    public int Charge { get; set; } = 1;

    /// <summary>
    ///     All GET requests will not save response. This only works with other http verbs
    /// </summary>
    public bool PreventSavingResponse { get; set; }

    /// <summary>
    ///     All GET requests will not save the request. This only works with other verbs
    /// </summary>
    public bool PreventSavingRequest { get; set; }


    /// <summary>
    ///     Prevent saving query string. For example on method login we may not want to save username and password on DB
    /// </summary>
    public bool PreventSavingQueryString { get; set; }

    /// <summary>
    ///     There may be occasions that we do not want to store on database a specific request.
    ///     By default all requests are saved
    /// </summary>
    public bool PreventSavingToDatabase { get; set; }
}
